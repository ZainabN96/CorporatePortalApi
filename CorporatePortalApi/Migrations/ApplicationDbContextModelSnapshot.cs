﻿// <auto-generated />
using System;
using CorporatePortalApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CorporatePortalApi.Models.AspNetUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("Address_ID")
                        .HasColumnType("int");

                    b.Property<int>("Address_ID1")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("FirstPasswordChange")
                        .HasColumnType("bit");

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTwoFAEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Locale_ID")
                        .HasColumnType("int");

                    b.Property<int>("Locale_ID1")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PasswordExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tenant_ID")
                        .HasColumnType("int");

                    b.Property<int>("Tenant_ID1")
                        .HasColumnType("int");

                    b.Property<int>("TimeZoneTime_Zone_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Time_Zone_ID")
                        .HasColumnType("int");

                    b.Property<string>("TwoFASecretKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Address_ID1");

                    b.HasIndex("Locale_ID1");

                    b.HasIndex("Tenant_ID1");

                    b.HasIndex("TimeZoneTime_Zone_ID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TMX_Address", b =>
                {
                    b.Property<int>("Address_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Address_ID"));

                    b.Property<bool>("Active_Flag")
                        .HasColumnType("bit");

                    b.Property<int>("AddressGeographyGeography_ID")
                        .HasColumnType("int");

                    b.Property<int>("AddressTypeLookupLookup_ID")
                        .HasColumnType("int");

                    b.Property<string>("Address_Coordinates")
                        .HasColumnType("geography");

                    b.Property<int?>("Address_Geography_ID")
                        .HasColumnType("int");

                    b.Property<string>("Address_Line_1")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Address_Line_2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address_Line_3")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address_Line_4")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Address_Type_Lkp_ID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Created_By")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Effective_End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Effective_Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_Updated_By")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Last_Updated_Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Mobile_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Postal_Zip_Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Province")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tenant_ID")
                        .HasColumnType("int");

                    b.Property<int>("Tenant_ID1")
                        .HasColumnType("int");

                    b.Property<string>("UDF_Data")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Address_ID");

                    b.HasIndex("AddressGeographyGeography_ID");

                    b.HasIndex("AddressTypeLookupLookup_ID");

                    b.HasIndex("Tenant_ID1");

                    b.ToTable("TMX_Address");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TMX_Locale", b =>
                {
                    b.Property<int>("Locale_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Locale_ID"));

                    b.Property<string>("Country_Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Locale_LCID")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Locale_ID");

                    b.ToTable("TMX_Locale");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TMX_Tenant", b =>
                {
                    b.Property<int>("Tenant_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tenant_ID"));

                    b.Property<bool>("Active_Flag")
                        .HasColumnType("bit");

                    b.Property<string>("Created_By")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Effective_End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Effective_Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_Updated_By")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Last_Updated_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Tenant_Activation_Date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Tenant_Blocked_Flag")
                        .HasColumnType("bit");

                    b.Property<string>("Tenant_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Tenant_Registration_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Tenant_ID");

                    b.ToTable("TMX_Tenants");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TMX_Time_Zone", b =>
                {
                    b.Property<int>("Time_Zone_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Time_Zone_ID"));

                    b.Property<bool>("Active_Flag")
                        .HasColumnType("bit");

                    b.Property<string>("Created_By")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_Updated_By")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Last_Updated_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Time_Zone_Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Time_Zone_Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Time_Zone_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Time_Zone_ID");

                    b.ToTable("TMX_Time_Zone");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TmX_Address_Geography", b =>
                {
                    b.Property<int>("Geography_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Geography_ID"));

                    b.HasKey("Geography_ID");

                    b.ToTable("TmX_Address_Geography");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TmX_Lookup", b =>
                {
                    b.Property<int>("Lookup_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lookup_ID"));

                    b.HasKey("Lookup_ID");

                    b.ToTable("TmX_Lookup");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.AspNetUser", b =>
                {
                    b.HasOne("CorporatePortalApi.Models.TMX_Address", "Address")
                        .WithMany()
                        .HasForeignKey("Address_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CorporatePortalApi.Models.TMX_Locale", "Locale")
                        .WithMany()
                        .HasForeignKey("Locale_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CorporatePortalApi.Models.TMX_Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("Tenant_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CorporatePortalApi.Models.TMX_Time_Zone", "TimeZone")
                        .WithMany()
                        .HasForeignKey("TimeZoneTime_Zone_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Locale");

                    b.Navigation("Tenant");

                    b.Navigation("TimeZone");
                });

            modelBuilder.Entity("CorporatePortalApi.Models.TMX_Address", b =>
                {
                    b.HasOne("CorporatePortalApi.Models.TmX_Address_Geography", "AddressGeography")
                        .WithMany()
                        .HasForeignKey("AddressGeographyGeography_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CorporatePortalApi.Models.TmX_Lookup", "AddressTypeLookup")
                        .WithMany()
                        .HasForeignKey("AddressTypeLookupLookup_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CorporatePortalApi.Models.TMX_Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("Tenant_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressGeography");

                    b.Navigation("AddressTypeLookup");

                    b.Navigation("Tenant");
                });
#pragma warning restore 612, 618
        }
    }
}