using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models.ViewModel;

namespace Recipes.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;


        public AccountController(UserManager<IdentityUser> userManger, 
           SignInManager<IdentityUser> signInManger)
        {
            userManager = userManger;
            signInManager = signInManger;
        }

        [AllowAnonymous]
        public ViewResult Login (string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel) //Aysnc method required a await.
        {

            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.Name); //Finding User

                if (user != null)
                {
                    if ((await signInManager.PasswordSignInAsync(user, 
                        loginModel.Password, false, false)).Succeeded)  // the method chech username and password matched?
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Admin/Index"); //if returnURl null
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }

    }

}