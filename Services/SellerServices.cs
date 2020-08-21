using ProjetoWebApplication.Controllers;
using ProjetoWebApplication.Data;
using ProjetoWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebApplication.Services
{
    public class SellerServices
    {
        private readonly ProjetoWebApplicationContext _context;

        public SellerServices(ProjetoWebApplicationContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        internal void Insert(SellersController seller)
        {
            throw new NotImplementedException();
        }
    }
}
