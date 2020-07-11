using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleEFCore.Models;

namespace SampleEFCore.Data
{
    public class SampleEFCoreContext : DbContext
    {
        public SampleEFCoreContext (DbContextOptions<SampleEFCoreContext> options)
            : base(options)
        {
        }

        public DbSet<SampleEFCore.Models.Movie> Movie { get; set; }
    }
}
