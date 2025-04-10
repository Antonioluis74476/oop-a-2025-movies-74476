using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using oop_a_2025_movies_74476.Data; // My actual namespace

namespace oop_a_2025_movies_74476.Models // Match my project’s namespace
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new oop_a_2025_movies_74476Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<oop_a_2025_movies_74476Context>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null oop_a_2025_movies_74476Context");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R",
                        Director = "Rob Reiner",
                        Cast = "Billy Crystal, Meg Ryan",
                        IMDbRating= 7.6M,
                        BoxOfficeRevenue= 92823000M,
                        ReleaseCountry= "USA"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R",
                        Director = "Ivan Reitman",
                        Cast = "Bill Murray, Dan Aykroyd",
                        IMDbRating= 7.8M,
                        BoxOfficeRevenue = 295000000M,
                        ReleaseCountry="USA"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "R",
                        Director = "Ivan Reitman",
                        Cast= "Bill Murray, Dan Aykroyd",
                        IMDbRating= 7.8M,
                        BoxOfficeRevenue= 395000000M,
                        ReleaseCountry = "USA"

                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R",
                        Director = "Howard Hawks",
                        Cast= "John Wayne, Dean Martin",
                        IMDbRating= 7.6M,
                        BoxOfficeRevenue= 5000000M,
                        ReleaseCountry="USA"

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
