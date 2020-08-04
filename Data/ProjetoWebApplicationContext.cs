using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWebApplication.Models;

namespace ProjetoWebApplication.Data
{
    public class ProjetoWebApplicationContext : DbContext
    {
        public ProjetoWebApplicationContext (DbContextOptions<ProjetoWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
