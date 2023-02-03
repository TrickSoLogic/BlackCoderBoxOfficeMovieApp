using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackCoderBoxOfficeMovieApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlackCoderBoxOfficeMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<BlackCoderBoxOfficeMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "MovieName1",
                        ReleaseDate = DateTime.Parse("2015-03-05"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}
