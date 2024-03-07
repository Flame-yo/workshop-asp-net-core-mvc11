using SalesWebMvc11.Models;
using SalesWebMvc11.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMvc11.Data
{
    public class SeedingService
    {
        private SalesWebMvc11Context _context;

        public SeedingService(SalesWebMvc11Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Eletronics");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(2000, 1, 1), 1000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 1), 10000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1);

            _context.Seller.AddRange(s1);

            _context.SalesRecord.AddRange(r1);

            _context.SaveChanges();
        }
    }
}
