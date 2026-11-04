using MongoDB.Driver;
using AquariumArchives.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquariumArchives.Models
{
    public class DatabaseService
    {
        private readonly IMongoCollection<Fish> _fish;
        private readonly IMongoCollection<User> _users;
        private static readonly Collation _ignoreCase = new Collation("en", strength: CollationStrength.Secondary);

        public DatabaseService()
        {
            string ConnectionString = "mongodb+srv://hurleya2_db_user:mEbFJiSNBekOISwa@cluster0.wttphvy.mongodb.net/";
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase("AquariumArchivesDB");
            _fish = db.GetCollection<Fish>("Fish");
            _users = db.GetCollection<User>("Users");

            // Usernames must be unique (case-insensitive).
            _users.Indexes.CreateOne(new CreateIndexModel<User>(
                Builders<User>.IndexKeys.Ascending(u => u.username),
                new CreateIndexOptions { Unique = true, Collation = _ignoreCase }));

            foreach (var fish in SampleData.list)
            {
                var exists = _fish.Find(f => f.Id == fish.Id).FirstOrDefault();
                if (exists == null)
                {
                    _fish.InsertOne(fish);
                }
            }
        }

        public async Task<User?> GetUserByUsernameAsync(string username) =>
        await _users.Find(u => u.username == username, new FindOptions { Collation = _ignoreCase })
                .FirstOrDefaultAsync();

        // Returns the new user, or null if the username is already taken.
        public async Task<User?> TryCreateUserAsync(string username, string email, string password)
        {
            for (var attempt = 0; attempt < 5; attempt++)
            {
                if (await GetUserByUsernameAsync(username) != null) return null;

                var last = await _users.Find(_ => true).SortByDescending(u => u.Id).Limit(1).FirstOrDefaultAsync();
                var user = new User
                {
                    Id = (last?.Id ?? 0) + 1,
                    username = username,
                    email = email,
                    password = password
                };

                try
                {
                    await _users.InsertOneAsync(user);
                    return user;
                }
                catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
                {
                    // Username or id was just taken by someone else; re-check and retry.
                }
            }
            throw new InvalidOperationException("Could not create the account. Please try again.");
        }

        public async Task<List<Fish>> GetAllFishAsync() =>
            await _fish.Find(_ => true).SortBy(f => f.Id).ToListAsync();

        public async Task AddFishToUserAsync(int userId, int fishId) =>
            await _users.UpdateOneAsync(u => u.Id == userId,
                Builders<User>.Update.AddToSet(u => u.FishCollection, fishId));

        public async Task SetDailyFishAsync(int userId, string date, int fishId) =>
            await _users.UpdateOneAsync(u => u.Id == userId,
                Builders<User>.Update.Set(u => u.DailyDate, date).Set(u => u.DailyFishId, fishId));


    }
}