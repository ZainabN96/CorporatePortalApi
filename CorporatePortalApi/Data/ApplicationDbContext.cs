using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

namespace CorporatePortalApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TmX_Corporate> TmX_Corporate { get; set; }
        /*public DbSet<TmX_Address_Geography> TmX_Address_Geography { get; set; }
        public DbSet<TmX_Lookup> TmX_Lookup { get; set; }
        public DbSet<TmX_Tenant> TmX_Tenants { get; set; }
        public DbSet<TmX_Address> TmX_Address { get; set; }
        public DbSet<TmX_Locale> TmX_Locale { get; set; }
        public DbSet<TmX_Time_Zone> TmX_Time_Zone { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }*/
        public DbSet<TmX_Bank> TmX_Bank { get; set; }
        public DbSet<TmX_Location> TmX_Location { get; set; }
        public DbSet<TmX_Currency> TmX_Currency { get; set; }

        public DbSet<AspNetRole>  AspNetRole { get; set; }

        public DbSet<TmX_Lookup> TmX_Lookup { get; set; }

        public DbSet<TmX_Address_Geography> TmX_Address_Geography { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the value converter to convert Point to WKT string and vice versa
            var pointToStringConverter = new ValueConverter<Point?, string?>(
                point => point == null ? null : point.ToString(),  // Point to string
                str => string.IsNullOrEmpty(str) ? null : ParsePointFromString(str) // String to Point
            );

            modelBuilder.Entity<TMX_Address>()
                .Property(a => a.Address_Coordinates)
                .HasConversion(pointToStringConverter)
                .HasColumnType("geography");
        }

        // Helper function to parse Point from the WKT string format "POINT (longitude latitude)"
        private Point ParsePointFromString(string wkt)
        {
            // Remove "POINT (" and ")"
            var coordinatesString = wkt.Replace("POINT (", "").Replace(")", "");

            // Split the string by space to get longitude and latitude
            var coordinates = coordinatesString.Split(' ');

            // Parse the values into doubles (Longitude, Latitude)
            var longitude = double.Parse(coordinates[0]);
            var latitude = double.Parse(coordinates[1]);

            // Create a new Point object from parsed coordinates
            return new Point(longitude, latitude);
        }

    }
}
