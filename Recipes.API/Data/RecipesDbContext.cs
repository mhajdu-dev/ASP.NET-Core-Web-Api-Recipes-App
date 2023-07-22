using Microsoft.EntityFrameworkCore;
using Recipes.API.Models.Domain;

namespace Recipes.API.Data
{
    public class RecipesDbContext: DbContext
    {
        public RecipesDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
                        
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<TypeOfDish> TypeOfDishes { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
