using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VeganectApi.Models
{

    public class Recipe
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string Ingredients { get; set; }
        
        public string PrepareMode { get; set; }

        public int CategoryId { get; set; }
        
        [JsonIgnore]
        public Category Category { get; set; }
    }
}
