using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeganectApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        [Required( ErrorMessage ="O campo nome é obrigatório")]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Recipe> Recipes = new List<Recipe>();
    }
}
