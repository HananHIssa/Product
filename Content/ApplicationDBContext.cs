using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Modular;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Content
{
    internal class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Asp99;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
