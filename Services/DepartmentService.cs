using ProjetoWebApplication.Data;
using ProjetoWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWebApplication.Services
{
    public class DepartmentService
    {
        private readonly ProjetoWebApplicationContext _context;

        public DepartmentService(ProjetoWebApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
