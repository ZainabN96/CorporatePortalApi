using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TMX_Address> TMX_Address { get; set; }
        public DbSet<TMX_Tenants> TMX_Tenants { get; set; }
        public DbSet<TMX_Locale> TMX_Locale { get; set; }
        public DbSet<TMX_Time_Zone> TMX_Time_Zone { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
