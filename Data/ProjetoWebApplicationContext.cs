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

        public DbSet<ProjetoWebApplication.Models.Department> Department { get; set; }
    }
}
