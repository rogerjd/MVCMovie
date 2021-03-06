﻿using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MVCMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Movie.Any())
            {
                return; //DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "A"
                },
                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "B"
                },
                new Movie
                {
                    Title = "Gkhostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23 "),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "C"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "D"
                }
                );
            context.SaveChanges();
        }
    }
}
