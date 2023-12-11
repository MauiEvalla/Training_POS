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
    }
}
