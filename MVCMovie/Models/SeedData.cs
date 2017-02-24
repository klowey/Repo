using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;

namespace MVCMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))

            {
                //look for any records, if there are records do nothing
                if (context.Movie.Any())
                {
                    return;
                }


                context.Movie.AddRange(

                    new Movie
                    {
                        Title = "Lemmy",
                        ReleaseDate = DateTime.Parse("2001-01-01"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "NR"
                    },
                    new Movie
                    {
                        Title = "Secret Life of Birds",
                        ReleaseDate = DateTime.Parse("2001-01-01"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "NR"

                    },
                    new Movie
                    {
                        Title = "Man Bites Dog",
                        ReleaseDate = DateTime.Parse("2001-01-01"),
                        Genre = "Foreign",
                        Price = 9.99M,
                        Rating = "NC-17"
                    },
                    new Movie
                    {
                        Title = "Repo Man",
                        ReleaseDate = DateTime.Parse("2001-01-01"),
                        Genre = "Cult Classic",
                        Price = 9.99M,
                        Rating = "R"

                    }

                    );

                context.SaveChanges();
            }

        }


    }
}
