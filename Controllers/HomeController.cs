using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;
using Microsoft.AspNetCore.Authorization;

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository repository;

        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }

       
        
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RecipeList()
        {
            return View(repository.Recipes);
        }

        [HttpGet]
        public IActionResult RecipeList(string s)
        {
            var searchedRecipe = repository.Recipes;

            if (!string.IsNullOrEmpty(s))
            {
                searchedRecipe = searchedRecipe.Where(selectedRecipe => (selectedRecipe.RecipeName.Contains(s) || selectedRecipe.Chef.Contains(s)
                || selectedRecipe.Description.Contains(s) || selectedRecipe.Ingredients.Contains(s)));
                
            }
            

            return View(searchedRecipe.ToList());
        }
       

        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            repository.SaveRecipe(recipe);
            return View( recipe);
        }

        public ViewResult ReviewRecipe()
        {
            return View();
        }
        
        public ViewResult ViewRecipe(int id)
        {
            Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeID == id);
            return View("ViewRecipe", recipe);
        }

        

    }
}