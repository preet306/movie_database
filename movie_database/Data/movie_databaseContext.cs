using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movie_database.Models;

namespace movie_database.Data
{
    public class movie_databaseContext : DbContext
    {
        public movie_databaseContext (DbContextOptions<movie_databaseContext> options)
            : base(options)
        {
        }

        public DbSet<movie_database.Models.Movie_details> Movie_details { get; set; }
    }
}
