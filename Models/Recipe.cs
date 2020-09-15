using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class Recipe
    {
        public string RecipeName { get; set ; }
        public string Chef { get; set; }
        public string Description { get; set; }
        public double PreparationTime { get; set; }
        public string Ingredients { get; set; }
        public int RecipeID { get; set; }

    }
}
