using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class AspNetUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TmX_Address_Geography",
                columns: table => new
                {
                    Geography_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Address_Geography", x => x.Geography_ID);
                });

            migrationBuilder.CreateTable(
                name: "TMX_Locale",
                columns: table => new
                {
                    Locale_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Locale_LCID = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Country_Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMX_Locale", x => x.Locale_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Lookup",
                columns: table => new
                {
                    Lookup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Lookup", x => x.Lookup_ID);
                });

            migrationBuilder.CreateTable(
                name: "TMX_Tenants",
                columns: table => new
                {
                    Tenant_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tenant_Registration_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tenant_Activation_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tenant_Blocked_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMX_Tenants", x => x.Tenant_ID);
                });

            migrationBuilder.CreateTable(
                name: "TMX_Time_Zone",
                columns: table => new
                {
                    Time_Zone_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time_Zone_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Time_Zone_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Time_Zone_Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMX_Time_Zone", x => x.Time_Zone_ID);
                });

            migrationBuilder.CreateTable(
                name: "TMX_Address",
                columns: table => new
                {
                    Address_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address_Geography_ID = table.Column<int>(type: "int", nullable: true),
                    AddressGeographyGeography_ID = table.Column<int>(type: "int", nullable: false),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Tenant_ID1 = table.Column<int>(type: "int", nullable: false),
                    UDF_Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address_Line_1 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Address_Line_2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address_Line_3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address_Line_4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Postal_Zip_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address_Coordinates = table.Column<string>(type: "geography", nullable: true),
                    Address_Type_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    AddressTypeLookupLookup_ID = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMX_Address", x => x.Address_ID);
                    table.ForeignKey(
                        name: "FK_TMX_Address_TMX_Tenants_Tenant_ID1",
                        column: x => x.Tenant_ID1,
                        principalTable: "TMX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TMX_Address_TmX_Address_Geography_AddressGeographyGeography_ID",
                        column: x => x.AddressGeographyGeography_ID,
                        principalTable: "TmX_Address_Geography",
                        principalColumn: "Geography_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TMX_Address_TmX_Lookup_AddressTypeLookupLookup_ID",
                        column: x => x.AddressTypeLookupLookup_ID,
                        principalTable: "TmX_Lookup",
                        principalColumn: "Lookup_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hometown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Address_ID = table.Column<int>(type: "int", nullable: true),
                    Address_ID1 = table.Column<int>(type: "int", nullable: false),
                    Locale_ID = table.Column<int>(type: "int", nullable: true),
                    Locale_ID1 = table.Column<int>(type: "int", nullable: false),
                    Time_Zone_ID = table.Column<int>(type: "int", nullable: true),
                    TimeZoneTime_Zone_ID = table.Column<int>(type: "int", nullable: false),
                    Tenant_ID = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID1 = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstPasswordChange = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTwoFAEnabled = table.Column<bool>(type: "bit", nullable: false),
                    TwoFASecretKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TMX_Address_Address_ID1",
                        column: x => x.Address_ID1,
                        principalTable: "TMX_Address",
                        principalColumn: "Address_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TMX_Locale_Locale_ID1",
                        column: x => x.Locale_ID1,
                        principalTable: "TMX_Locale",
                        principalColumn: "Locale_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TMX_Tenants_Tenant_ID1",
                        column: x => x.Tenant_ID1,
                        principalTable: "TMX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TMX_Time_Zone_TimeZoneTime_Zone_ID",
                        column: x => x.TimeZoneTime_Zone_ID,
                        principalTable: "TMX_Time_Zone",
                        principalColumn: "Time_Zone_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Address_ID1",
                table: "AspNetUsers",
                column: "Address_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Locale_ID1",
                table: "AspNetUsers",
                column: "Locale_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tenant_ID1",
                table: "AspNetUsers",
                column: "Tenant_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TimeZoneTime_Zone_ID",
                table: "AspNetUsers",
                column: "TimeZoneTime_Zone_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TMX_Address_AddressGeographyGeography_ID",
                table: "TMX_Address",
                column: "AddressGeographyGeography_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TMX_Address_AddressTypeLookupLookup_ID",
                table: "TMX_Address",
                column: "AddressTypeLookupLookup_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TMX_Address_Tenant_ID1",
                table: "TMX_Address",
                column: "Tenant_ID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TMX_Address");

            migrationBuilder.DropTable(
                name: "TMX_Locale");

            migrationBuilder.DropTable(
                name: "TMX_Time_Zone");

            migrationBuilder.DropTable(
                name: "TMX_Tenants");

            migrationBuilder.DropTable(
                name: "TmX_Address_Geography");

            migrationBuilder.DropTable(
                name: "TmX_Lookup");
        }
    }
}
