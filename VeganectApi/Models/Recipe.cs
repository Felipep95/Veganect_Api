using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganectApi.Models
{
//id
//image
//name
//igredients
//prepareMode
//category
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string PrepareMode { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
