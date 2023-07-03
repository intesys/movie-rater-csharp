using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieRaterWebApp.Models;

namespace MovieRaterWebApp.Data
{
    public class MovieRaterWebAppContext : DbContext
    {
        public MovieRaterWebAppContext (DbContextOptions<MovieRaterWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieRaterWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
