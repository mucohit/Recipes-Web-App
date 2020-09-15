using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "Manti",
                        Chef = "Mucahit",
                        PreparationTime = 230,
                        Description="Hamuru Ac Icine Kiymayi koy Buk sonra firina ver veya Direk Kanyar suda hasla sonra yogurtla servis et",
                        Ingredients ="Hamur, Kiyma, Sogan, Karabiber, Tuz"
                    },
                    new Recipe
                    {
                        RecipeName = "Sarma",
                        Chef = "Mucahit",
                        PreparationTime = 330,
                        Description = "Sarma yapraginin icine harci koy",
                        Ingredients = "Yaprak, Kiyma, Ic Harc, Karabiber, Tuz"
                    }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}
