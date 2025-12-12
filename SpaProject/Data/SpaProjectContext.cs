using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaProject.Models;

namespace SpaProject.Data
{
    public class SpaProjectContext : DbContext
    {
        public SpaProjectContext (DbContextOptions<SpaProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SpaProject.Models.Service> Service { get; set; } = default!;
    }
}
