using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaProject.Models;

namespace SpaProject.Data
{
    public class SpaProjectAdminDB : DbContext
    {
        public SpaProjectAdminDB (DbContextOptions<SpaProjectAdminDB> options)
            : base(options)
        {
        }

        public DbSet<SpaProject.Models.Admin> Admin { get; set; } = default!;
    }
}
