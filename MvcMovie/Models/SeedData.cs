using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Love, Kennedy",
                        ReleaseDate = DateTime.Parse("2017-09-26"),
                        Genre = "Romantic Comedy",
                        Rating = "A",
                        Price = 14.64M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-09-13"),
                        Genre = "Drama",
                        Rating = "A",
                        Price = 11.87M
                    },

                    new Movie
                    {
                        Title = "Just Let Go",
                        ReleaseDate = DateTime.Parse("2016-01-5"),
                        Genre = "Drama",
                        Rating = "A",
                        Price = 13.39M
                    },

                    new Movie
                    {
                        Title = "Saratov Approach",
                        ReleaseDate = DateTime.Parse("2015-4-15"),
                        Genre = "Drama",
                        Rating = "A",
                        Price = 3.99M
                    },
                    
                    new Movie
                    {
                       Title = "Meet the Mormons",
                       ReleaseDate = DateTime.Parse("2014-10-10"),
                       Genre = "Documenal",
                       Rating = "A",
                       Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
