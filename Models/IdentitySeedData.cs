using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        private const string adminRoleName = "Admin";

        public static async void EnsurePopulated(IApplicationBuilder app) {

            RoleManager<IdentityRole> roleManager = app.ApplicationServices
               .GetRequiredService<RoleManager<IdentityRole>>();

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByNameAsync(adminUser);

            IdentityRole adminRole = await roleManager.FindByNameAsync(adminRoleName);

            if (adminRole == null)
            {
                adminRole = new IdentityRole(adminRoleName);
                await roleManager.CreateAsync(adminRole);
            }

            if (user == null)
            {
                user = new IdentityUser(adminUser);
                await userManager.CreateAsync(user, adminPassword);
            }
            else
            {
                if (!(await userManager.IsInRoleAsync(user, adminRoleName)))
                {
                    await userManager.AddToRoleAsync(user, adminRoleName);
                }
            }
        }
    }
}
