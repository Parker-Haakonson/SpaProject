using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaProject.Models;

namespace SpaProject.Data
{
    public class SpaProjectRegisterDB : DbContext
    {
        public SpaProjectRegisterDB (DbContextOptions<SpaProjectRegisterDB> options)
            : base(options)
        {
        }

        public DbSet<SpaProject.Models.Register> Register { get; set; } = default!;
    }
}
