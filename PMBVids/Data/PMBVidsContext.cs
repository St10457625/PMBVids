using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PMBVids.Models;

namespace PMBVids.Data
{
    public class PMBVidsContext : DbContext
    {
        public PMBVidsContext (DbContextOptions<PMBVidsContext> options)
            : base(options)
        {
        }

        public DbSet<PMBVids.Models.Movie> Movie { get; set; } = default!;
    }
}
