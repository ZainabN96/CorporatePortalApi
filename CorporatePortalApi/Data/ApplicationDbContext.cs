﻿using CorporatePortalApi.Data.Services;
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
        public DbSet<TmX_Address_Geography> TmX_Address_Geography { get; set; }
        public DbSet<TmX_Lookup> TmX_Lookup { get; set; }
        public DbSet<TmX_Tenant> TmX_Tenants { get; set; }
        public DbSet<TmX_Address> TmX_Address { get; set; }
        public DbSet<TmX_Locale> TmX_Locale { get; set; }
        public DbSet<TmX_Time_Zone> TmX_Time_Zone { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public DbSet<TmX_Bank> TmX_Bank { get; set; }
        public DbSet<TmX_Location> TmX_Location { get; set; }
        public DbSet<TmX_Currency> TmX_Currency { get; set; }
        public DbSet<TmX_Product> TmX_Product { get; set; }
        public DbSet<TmX_User> TmX_User { get; set; }
        public DbSet<TmX_User_To_Corporate_Mapping> TmX_User_To_Corporate_Mapping { get; set; }

        public DbSet<AspNetRole>  AspNetRole { get; set; }

		public DbSet<TmX_Loan_Application_Checklist> TmX_Loan_Application_Checklist { get; set; }
		public DbSet<TmX_Tab> TmX_Tab { get; set; }
        public DbSet<TmX_Account_Application> TmX_Account_Application { get; set; }
		public DbSet<TmX_Product_Checklist> TmX_Product_Checklist { get; set; }

		public DbSet<TmX_Loan_Application> TmX_Loan_Application { get; set; }
		public DbSet<TmX_Company_Branch> TmX_Company_Branch { get; set; }
		public DbSet<TmX_Geofence> TmX_Geofence { get; set; }
		public DbSet<TmX_Customer_Master> TmX_Customer_Master { get; set; }
		public DbSet<TmX_Order> TmX_Order { get; set; }

		public DbSet<TmX_Transaction> TmX_Transaction { get; set; }
		public DbSet<TmX_Institute> TmX_Institute { get; set; }
		public DbSet<TmX_Person> TmX_Person { get; set; }
		public DbSet<TmX_Customer_Detail> TmX_Customer_Detail { get; set; }
		public DbSet<TmX_Person_Income_Detail> TmX_Person_Income_Detail { get; set; }
		public DbSet<TmX_Person_Expense_Detail> TmX_Person_Expense_Detail { get; set; }
		public DbSet<TmX_Person_Address_Contact> TmX_Person_Address_Contact { get; set; }
		public DbSet<TmX_Person_To_Address_Mapping> TmX_Person_To_Address_Mapping { get; set; }
		public DbSet<TmX_Person_National_Identifier> TmX_Person_National_Identifier { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the value converter to convert Point to WKT string and vice versa
            var pointToStringConverter = new ValueConverter<Point?, string?>(
                point => point == null ? null : point.ToString(),  // Point to string
                str => string.IsNullOrEmpty(str) ? null : ParsePointFromString(str) // String to Point
            );

            modelBuilder.Entity<TmX_Address>()
                .Property(a => a.Address_Coordinates)
                .HasConversion(pointToStringConverter)
                .HasColumnType("geography");

            modelBuilder.Entity<AspNetUserRole>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<AspNetUserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AspNetUserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TmX_User>()
                 .HasOne(u => u.ParentUser)
                 .WithMany()
                 .HasForeignKey(u => u.Parent_User_ID)
                 .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete for the self-referencing relationship

            // Configure other relationships
            modelBuilder.Entity<TmX_User>()
                .HasOne(u => u.Tenant)
                .WithMany()
                .HasForeignKey(u => u.Tenant_ID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure TmX_Address and its relationships
            modelBuilder.Entity<TmX_Address>()
                .HasOne(a => a.Tenant)
                .WithMany()
                .HasForeignKey(a => a.Tenant_ID)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<AspNetUser>()
                .HasOne(a => a.Tenant)
                .WithMany()
                .HasForeignKey(a => a.Tenant_ID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<TmX_Address>()
                .HasOne(a => a.AddressGeography)
                .WithMany()
                .HasForeignKey(a => a.Address_Geography_ID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<TmX_Address>()
                .HasOne(a => a.AddressTypeLookup)
                .WithMany()
                .HasForeignKey(a => a.Address_Type_Lkp_ID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            modelBuilder.Entity<AspNetUser>()
                .HasOne(u => u.Address)
                .WithMany()
                .HasForeignKey(u => u.Address_ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AspNetUser>()
                .HasOne(u => u.Locale)
                .WithMany()
                .HasForeignKey(u => u.Locale_ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AspNetUser>()
                .HasOne(u => u.TimeZone)
                .WithMany()
                .HasForeignKey(u => u.Time_Zone_ID)
                .OnDelete(DeleteBehavior.Restrict);

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
