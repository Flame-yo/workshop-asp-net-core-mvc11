using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc11.Models;

namespace SalesWebMvc11.Data
{
    public class SalesWebMvc11Context : DbContext
    {
        public SalesWebMvc11Context (DbContextOptions<SalesWebMvc11Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
