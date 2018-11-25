using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMoviee.Models
{
    public class MvcMovieeContext : DbContext
    {
        public MvcMovieeContext (DbContextOptions<MvcMovieeContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMoviee.Models.Movie> Movie { get; set; }
    }
}
