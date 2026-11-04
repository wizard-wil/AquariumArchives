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

        public static readonly Dictionary<string, int> StartingFish = new()
        {
            ["North America"] = 2,
            ["South America"] = 3,
            ["Europe"] = 4,
            ["Asia"] = 5,
            ["Africa"] = 6,
            ["Oceania"] = 7,
            ["Antarctica"] = 8
        };
        public const int FactRewardFishId = 9;
        public static bool IsRandomPoolFish(int id) => !StartingFish.ContainsValue(id) && id != FactRewardFishId;

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

            var imageDir = Path.Combine(AppContext.BaseDirectory, "SeedImages");

            foreach (var fish in SampleData.list)
            {
                if (_fish.CountDocuments(f => f.Id == fish.Id) == 0)
                    _fish.InsertOne(fish);

                // Attach the image if this fish doesn't have one yet
                var path = Path.Combine(imageDir, fish.ImageFile);
                var hasImage = _fish.CountDocuments(f => f.Id == fish.Id && f.ImageContentType != "" && f.ImageContentType != null) > 0;
                if (!hasImage && !string.IsNullOrEmpty(fish.ImageFile) && File.Exists(path))
                {
                    var type = Path.GetExtension(path).ToLowerInvariant() switch
                    {
                        ".png" => "image/png",
                        ".webp" => "image/webp",
                        ".gif" => "image/gif",
                        _ => "image/jpeg"
                    };
                    _fish.UpdateOne(f => f.Id == fish.Id,
                        Builders<Fish>.Update
                            .Set(f => f.ImageData, File.ReadAllBytes(path))
                            .Set(f => f.ImageContentType, type));
                }
            }
        }

        public async Task<User?> GetUserByUsernameAsync(string username) =>
        await _users.Find(u => u.username == username, new FindOptions { Collation = _ignoreCase })
                .FirstOrDefaultAsync();

        // Returns the new user, or null if the username is already taken.
        public async Task<User?> TryCreateUserAsync(string username, string email, string password, string continent)
        {
            if (!StartingFish.TryGetValue(continent, out var startingFishId))
                throw new ArgumentException("Invalid continent.", nameof(continent));

            for (var attempt = 0; attempt < 5; attempt++)
            {
                if (await GetUserByUsernameAsync(username) != null) return null;

                var last = await _users.Find(_ => true).SortByDescending(u => u.Id).Limit(1).FirstOrDefaultAsync();
                var user = new User
                {
                    Id = (last?.Id ?? 0) + 1,
                    username = username,
                    email = email,
                    password = password,
                    Continent = continent,
                    FishCollection = new List<int> { startingFishId }
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
            await _fish.Find(_ => true).Project<Fish>(Builders<Fish>.Projection.Exclude(f => f.ImageData)).SortBy(f => f.Id).ToListAsync();

        public async Task<Fish?> GetFishImageAsync(int id) =>
            await _fish.Find(f => f.Id == id).FirstOrDefaultAsync();

        public async Task AddFishToUserAsync(int userId, int fishId) =>
            await _users.UpdateOneAsync(u => u.Id == userId,
                Builders<User>.Update.AddToSet(u => u.FishCollection, fishId));

        public async Task SetDailyFishAsync(int userId, string date, int fishId) =>
            await _users.UpdateOneAsync(u => u.Id == userId,
                Builders<User>.Update.Set(u => u.DailyDate, date).Set(u => u.DailyFishId, fishId));

        public async Task SetFactIndexAsync(int userId, int index) =>
            await _users.UpdateOneAsync(u => u.Id == userId,
                Builders<User>.Update.Set(u => u.FactIndex, index));
    }
}