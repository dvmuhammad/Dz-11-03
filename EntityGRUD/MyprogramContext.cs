using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dz_11_03
{
    public class MyprogramContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

		public MyprogramContext()
        {
            Database.EnsureCreated();
        }
		
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MUHAMMAD\\SQLEXPRESS;Database=Test;Trusted_Connection=True;");
        }
    }
}