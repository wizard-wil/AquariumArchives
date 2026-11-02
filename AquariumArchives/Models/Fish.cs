using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquariumArchives.Models
{
    public class Fish
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Photo_URL { get; set; } = "";
    }
}
