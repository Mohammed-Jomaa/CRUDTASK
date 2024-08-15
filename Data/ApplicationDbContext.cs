using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskC.Model;

namespace TaskC.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;Database= TaskC;Trusted_Connection= True;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
        public  DbSet<Order> Orders { get; set; }

    }
}
