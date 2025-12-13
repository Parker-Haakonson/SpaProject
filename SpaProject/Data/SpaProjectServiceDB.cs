using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaProject.Models;

namespace SpaProject.Data
{
    public class SpaProjectServiceDB : DbContext
    {
        public SpaProjectServiceDB (DbContextOptions<SpaProjectServiceDB> options)
            : base(options)
        {
        }

        public DbSet<SpaProject.Models.Service> Service { get; set; } = default!;
    }
}
