using Microsoft.EntityFrameworkCore;
using SiteManagement.Entities;
using System;

namespace SiteManagement.DataAcces
{
    public class SiteDbContext: DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GMITUKI;Initial Catalog=SiteManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
       public DbSet<Resident>  Residents { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
    }
}
