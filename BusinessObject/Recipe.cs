using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public int UserID { get; set; }
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public int CookingTime { get; set; }
        public int Servings { get; set; }

        public byte[] RecipeImage { get; set; }

        public Recipe()
        {


        }
        public Recipe(int RecipeID, string recipeName, string ingredients, int cookingTime, int servings)
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            CookingTime = cookingTime;
            Servings = servings;

        }

        public Recipe(string recipeName, string ingredients, int cookingTime, int servings,byte[] recipeImage )
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            CookingTime = cookingTime;
            Servings = servings;
            RecipeImage = recipeImage;

        }

        public Recipe(int recipeID, string recipeName, string ingredients, int cookingTime, int servings, byte[] recipeImage)
        {
            RecipeID = recipeID; 
            RecipeName = recipeName;
            Ingredients = ingredients;
            CookingTime = cookingTime;
            Servings = servings;
            RecipeImage = recipeImage;

        }
    }

}
