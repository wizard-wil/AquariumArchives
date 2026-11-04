using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquariumArchives.Models
{
    [BsonIgnoreExtraElements]
    public class Fish
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public byte[]? ImageData { get; set; }
        public string ImageContentType { get; set; } = "";

        [BsonIgnore] 
        public string ImageFile { get; set; } = "";
        [BsonIgnore] 
        public bool HasImage => !string.IsNullOrEmpty(ImageContentType);
    }
}
