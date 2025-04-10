using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using oop_a_2025_movies_74476.Models;

namespace oop_a_2025_movies_74476.Data
{
    public class oop_a_2025_movies_74476Context : DbContext
    {
        public oop_a_2025_movies_74476Context (DbContextOptions<oop_a_2025_movies_74476Context> options)
            : base(options)
        {
        }

        public DbSet<oop_a_2025_movies_74476.Models.Movie> Movie { get; set; } = default!;
        public DbSet<Actor> Actor { get; set; } = default!;
    }
}
