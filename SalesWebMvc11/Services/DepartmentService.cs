using SalesWebMvc11.Data;
using SalesWebMvc11.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc11.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc11Context _context;

        public DepartmentService(SalesWebMvc11Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
