using System;

namespace AquariumArchives.Models
{
    public class SampleData
    {
        public static List<Fish> list = new List<Fish>
        {
            new()
            {
                Id=1,
                Name = "Orca Whale",
                Description = "",
                Photo_URL = "Meow"
            }
        };
    }
}

