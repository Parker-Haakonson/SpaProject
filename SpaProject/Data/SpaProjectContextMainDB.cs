using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaProject.Models;

namespace SpaProject.Data
{
    public class SpaProjectContextMainDB : DbContext
    {
        public SpaProjectContextMainDB (DbContextOptions<SpaProjectContextMainDB> options)
            : base(options)
        {
        }

        public DbSet<SpaProject.Models.Main> Main { get; set; } = default!;
    }
}
