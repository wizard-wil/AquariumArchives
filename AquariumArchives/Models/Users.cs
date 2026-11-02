using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace AquariumArchives.Models
{
    public class User
    {
        [BsonId]
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public List<int> FishCollection { get; set; } = new();
    }
}