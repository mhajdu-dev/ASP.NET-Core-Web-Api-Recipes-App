namespace Recipes.API.Models.Domain
{
    public class Recipe
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int TimeToCookInMinutes { get; set; }
        public string? RecipeImageUrl { get; set; }

        public Guid DifficultyId { get; set; }

        public Guid TypeOfDishId { get; set; }

        //Navigation properties
        public Difficulty Difficulty { get; set; }

        public TypeOfDish TypeOfDish { get; set; }

    }
}
