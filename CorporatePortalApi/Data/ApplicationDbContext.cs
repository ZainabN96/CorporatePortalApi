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
        public DbSet<TMX_Tenant> TMX_Tenants { get; set; }
        public DbSet<TMX_Address> TMX_Address { get; set; }
        public DbSet<TMX_Locale> TMX_Locale { get; set; }
        public DbSet<TMX_Time_Zone> TMX_Time_Zone { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }*/
        
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
