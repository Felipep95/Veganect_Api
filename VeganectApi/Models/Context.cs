using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeganectApi.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipies { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(ConnectionString: @"Server=127.0.0.1 ;Port=5432; Database=VeganectApi; User Id=postgres; Password=postgres;");
        //}

    }
}
