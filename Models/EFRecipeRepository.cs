using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public void AddRecipe(Recipe recipe)
        {
            context.Add(recipe);
        }

        public void SaveRecipe(Recipe recipe)
        {
            if(recipe.RecipeID == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe recipeEnty = context.Recipes
                    .FirstOrDefault(r => r.RecipeID == recipe.RecipeID);

                if(recipeEnty != null)
                {
                    recipeEnty.RecipeName = recipe.RecipeName;
                    recipeEnty.Description = recipe.Description;
                    recipeEnty.Chef = recipe.Chef;
                    recipeEnty.Ingredients = recipe.Ingredients;
                    recipeEnty.PreparationTime = recipe.PreparationTime;
                }
            }
            context.SaveChanges();

           
        }

        
        public Recipe DeleteRecipe(int recipeID)
        {
            Recipe recipeEnty = context.Recipes
                   .FirstOrDefault(r => r.RecipeID == recipeID);

            if(recipeEnty != null)
            {
                context.Recipes.Remove(recipeEnty);
                context.SaveChanges();
            }

            return recipeEnty;
        }
    }
}
