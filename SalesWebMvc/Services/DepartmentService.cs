using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //return departments sorted by name 
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList(); 
        }
    }
}
