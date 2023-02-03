using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlackCoderBoxOfficeMovieApp.Models
{
    public class BlackCoderBoxOfficeMovieContext : DbContext
    {
        public BlackCoderBoxOfficeMovieContext (DbContextOptions<BlackCoderBoxOfficeMovieContext> options)
            : base(options)
        {
        }

        public DbSet<BlackCoderBoxOfficeMovieApp.Models.Movie> Movie { get; set; }
    }
}
