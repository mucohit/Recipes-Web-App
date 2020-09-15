using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IRecipeRepository repository;

        public AdminController(IRecipeRepository repo)
        {
            repository = repo;
        }


        public ViewResult Index() => View(repository.Recipes);


        public ViewResult Edit(int recipeId) => View(repository.Recipes.FirstOrDefault(r => r.RecipeID == recipeId));

       
        
        [HttpPost]
        public IActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.RecipeName} has been saved!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult Create()
        {
            return View("Edit",new Recipe()); 
        }

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(recipeId);

            if(deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.RecipeName} was deleted! ";
            }
            return RedirectToAction("Index");
        }
    }
}