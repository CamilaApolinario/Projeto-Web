using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoWebApplication.Models;

namespace ProjetoWebApplication.Data
{
    public class SeedingService
    {
        private ProjetoWebApplicationContext _context;
        public SeedingService(ProjetoWebApplicationContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Ana Paula", "anap@gmail.com", new DateTime(1999, 5, 21), 1000.0, d1);

        }
    }
}
