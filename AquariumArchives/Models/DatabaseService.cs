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

        public DatabaseService()
        {
            string ConnectionString = "mongodb+srv://hurleya2_db_user:mEbFJiSNBekOISwa@cluster0.wttphvy.mongodb.net/";
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase("AquariumArchivesDB");
            _fish = db.GetCollection<Fish>("Fish");

            foreach (var fish in SampleData.list)
            {
                var exists = _fish.Find(f => f.Id == fish.Id).FirstOrDefault();
                if (exists == null)
                {
                    _fish.InsertOne(fish);
                }
            }
        }
    }
}