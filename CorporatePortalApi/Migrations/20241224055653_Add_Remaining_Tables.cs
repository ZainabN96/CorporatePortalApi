using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class Add_Remaining_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TMX_Address_TMX_Tenant_Tenant_ID1",
                table: "TMX_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_TMX_Address_TmX_Address_Geography_AddressGeographyGeography_ID",
                table: "TMX_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_TMX_Address_TmX_Lookup_AddressTypeLookupLookup_ID",
                table: "TMX_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_TmX_Product_TMX_Tenant_Tenant_ID",
                table: "TmX_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TMX_Address",
                table: "TMX_Address");

            migrationBuilder.DropIndex(
                name: "IX_TMX_Address_AddressGeographyGeography_ID",
                table: "TMX_Address");

            migrationBuilder.DropIndex(
                name: "IX_TMX_Address_AddressTypeLookupLookup_ID",
                table: "TMX_Address");

            migrationBuilder.DropIndex(
                name: "IX_TMX_Address_Tenant_ID1",
                table: "TMX_Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TMX_Tenant",
                table: "TMX_Tenant");

            migrationBuilder.DropColumn(
                name: "AddressGeographyGeography_ID",
                table: "TMX_Address");

            migrationBuilder.DropColumn(
                name: "AddressTypeLookupLookup_ID",
                table: "TMX_Address");

            migrationBuilder.DropColumn(
                name: "Tenant_ID1",
                table: "TMX_Address");

            migrationBuilder.RenameTable(
                name: "TMX_Address",
                newName: "TmX_Address");

            migrationBuilder.RenameTable(
                name: "TMX_Tenant",
                newName: "TmX_Tenants");

            migrationBuilder.RenameColumn(
                name: "Geography_ID",
                table: "TmX_Address_Geography",
                newName: "Address_Geography_ID");

            migrationBuilder.AddColumn<bool>(
                name: "Active_Flag",
                table: "TmX_Lookup",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "TmX_Lookup",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Created_Date",
                table: "TmX_Lookup",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TmX_Lookup",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hidden_Value",
                table: "TmX_Lookup",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "TmX_Lookup",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Updated_By",
                table: "TmX_Lookup",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Last_Updated_Date",
                table: "TmX_Lookup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Locale_ID",
                table: "TmX_Lookup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Locale_Label",
                table: "TmX_Lookup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lookup_Name",
                table: "TmX_Lookup",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lookup_Type",
                table: "TmX_Lookup",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent_Lookup_ID",
                table: "TmX_Lookup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sort_Order",
                table: "TmX_Lookup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tenant_ID",
                table: "TmX_Lookup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_Editable",
                table: "TmX_Lookup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Visible_Value",
                table: "TmX_Lookup",
                type: "nvarchar(999)",
                maxLength: 999,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active_Flag",
                table: "TmX_Address_Geography",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "TmX_Address_Geography",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_Date",
                table: "TmX_Address_Geography",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Effective_End_Date",
                table: "TmX_Address_Geography",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Effective_Start_Date",
                table: "TmX_Address_Geography",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Geography_Description",
                table: "TmX_Address_Geography",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Geography_Name",
                table: "TmX_Address_Geography",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Geography_Short_Code",
                table: "TmX_Address_Geography",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Geography_Type_Lkp_ID",
                table: "TmX_Address_Geography",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Updated_By",
                table: "TmX_Address_Geography",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Last_Updated_Date",
                table: "TmX_Address_Geography",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent_Geography_ID",
                table: "TmX_Address_Geography",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tenant_ID",
                table: "TmX_Address_Geography",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TmX_Address",
                table: "TmX_Address",
                column: "Address_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TmX_Tenants",
                table: "TmX_Tenants",
                column: "Tenant_ID");

            migrationBuilder.CreateTable(
                name: "AspNetRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Locale",
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
                    table.PrimaryKey("PK_TmX_Locale", x => x.Locale_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Location",
                columns: table => new
                {
                    Location_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parent_Location_ID = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Location_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location_Type_Lkp_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Location", x => x.Location_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Location_TmX_Location_Parent_Location_ID",
                        column: x => x.Parent_Location_ID,
                        principalTable: "TmX_Location",
                        principalColumn: "Location_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Location_TmX_Lookup_Location_Type_Lkp_ID",
                        column: x => x.Location_Type_Lkp_ID,
                        principalTable: "TmX_Lookup",
                        principalColumn: "Lookup_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Location_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Time_Zone",
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
                    table.PrimaryKey("PK_TmX_Time_Zone", x => x.Time_Zone_ID);
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
                        name: "FK_AspNetUsers_TmX_Address_Address_ID1",
                        column: x => x.Address_ID1,
                        principalTable: "TmX_Address",
                        principalColumn: "Address_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TmX_Locale_Locale_ID1",
                        column: x => x.Locale_ID1,
                        principalTable: "TmX_Locale",
                        principalColumn: "Locale_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TmX_Tenants_Tenant_ID1",
                        column: x => x.Tenant_ID1,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TmX_Time_Zone_TimeZoneTime_Zone_ID",
                        column: x => x.TimeZoneTime_Zone_ID,
                        principalTable: "TmX_Time_Zone",
                        principalColumn: "Time_Zone_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmX_User",
                columns: table => new
                {
                    User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Parent_User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    Address_ID = table.Column<int>(type: "int", nullable: true),
                    Time_Zone_ID = table.Column<int>(type: "int", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Middle_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contact_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    User_Image_URL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Primary_National_Identifier_Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile_User_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Primary_National_ID_Type_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    User_Type_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    Designation_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    Server_User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Server_Branch_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_User", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_Address_Address_ID",
                        column: x => x.Address_ID,
                        principalTable: "TmX_Address",
                        principalColumn: "Address_ID");
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_Location_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "TmX_Location",
                        principalColumn: "Location_ID");
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_Lookup_Designation_Lkp_ID",
                        column: x => x.Designation_Lkp_ID,
                        principalTable: "TmX_Lookup",
                        principalColumn: "Lookup_ID");
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_Lookup_User_Type_Lkp_ID",
                        column: x => x.User_Type_Lkp_ID,
                        principalTable: "TmX_Lookup",
                        principalColumn: "Lookup_ID");
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_Time_Zone_Time_Zone_ID",
                        column: x => x.Time_Zone_ID,
                        principalTable: "TmX_Time_Zone",
                        principalColumn: "Time_Zone_ID");
                    table.ForeignKey(
                        name: "FK_TmX_User_TmX_User_Parent_User_ID",
                        column: x => x.Parent_User_ID,
                        principalTable: "TmX_User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmX_User_To_Corporate_Mapping",
                columns: table => new
                {
                    User_To_Corporate_Mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Corporate_Id = table.Column<int>(type: "int", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_User_To_Corporate_Mapping", x => x.User_To_Corporate_Mapping_Id);
                    table.ForeignKey(
                        name: "FK_TmX_User_To_Corporate_Mapping_TmX_Corporate_Corporate_Id",
                        column: x => x.Corporate_Id,
                        principalTable: "TmX_Corporate",
                        principalColumn: "Corporate_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_User_To_Corporate_Mapping_TmX_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "TmX_User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Address_Address_Geography_ID",
                table: "TmX_Address",
                column: "Address_Geography_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Address_Address_Type_Lkp_ID",
                table: "TmX_Address",
                column: "Address_Type_Lkp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Address_Tenant_ID",
                table: "TmX_Address",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

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
                name: "IX_TmX_Location_Location_Type_Lkp_ID",
                table: "TmX_Location",
                column: "Location_Type_Lkp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Location_Parent_Location_ID",
                table: "TmX_Location",
                column: "Parent_Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Location_Tenant_ID",
                table: "TmX_Location",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_Address_ID",
                table: "TmX_User",
                column: "Address_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_Designation_Lkp_ID",
                table: "TmX_User",
                column: "Designation_Lkp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_Location_ID",
                table: "TmX_User",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_Parent_User_ID",
                table: "TmX_User",
                column: "Parent_User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_Tenant_ID",
                table: "TmX_User",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_Time_Zone_ID",
                table: "TmX_User",
                column: "Time_Zone_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_User_Type_Lkp_ID",
                table: "TmX_User",
                column: "User_Type_Lkp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_To_Corporate_Mapping_Corporate_Id",
                table: "TmX_User_To_Corporate_Mapping",
                column: "Corporate_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_User_To_Corporate_Mapping_User_Id",
                table: "TmX_User_To_Corporate_Mapping",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TmX_Address_TmX_Address_Geography_Address_Geography_ID",
                table: "TmX_Address",
                column: "Address_Geography_ID",
                principalTable: "TmX_Address_Geography",
                principalColumn: "Address_Geography_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TmX_Address_TmX_Lookup_Address_Type_Lkp_ID",
                table: "TmX_Address",
                column: "Address_Type_Lkp_ID",
                principalTable: "TmX_Lookup",
                principalColumn: "Lookup_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TmX_Address_TmX_Tenants_Tenant_ID",
                table: "TmX_Address",
                column: "Tenant_ID",
                principalTable: "TmX_Tenants",
                principalColumn: "Tenant_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TmX_Product_TmX_Tenants_Tenant_ID",
                table: "TmX_Product",
                column: "Tenant_ID",
                principalTable: "TmX_Tenants",
                principalColumn: "Tenant_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TmX_Address_TmX_Address_Geography_Address_Geography_ID",
                table: "TmX_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_TmX_Address_TmX_Lookup_Address_Type_Lkp_ID",
                table: "TmX_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_TmX_Address_TmX_Tenants_Tenant_ID",
                table: "TmX_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_TmX_Product_TmX_Tenants_Tenant_ID",
                table: "TmX_Product");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "TmX_User_To_Corporate_Mapping");

            migrationBuilder.DropTable(
                name: "AspNetRole");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TmX_User");

            migrationBuilder.DropTable(
                name: "TmX_Locale");

            migrationBuilder.DropTable(
                name: "TmX_Location");

            migrationBuilder.DropTable(
                name: "TmX_Time_Zone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TmX_Address",
                table: "TmX_Address");

            migrationBuilder.DropIndex(
                name: "IX_TmX_Address_Address_Geography_ID",
                table: "TmX_Address");

            migrationBuilder.DropIndex(
                name: "IX_TmX_Address_Address_Type_Lkp_ID",
                table: "TmX_Address");

            migrationBuilder.DropIndex(
                name: "IX_TmX_Address_Tenant_ID",
                table: "TmX_Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TmX_Tenants",
                table: "TmX_Tenants");

            migrationBuilder.DropColumn(
                name: "Active_Flag",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Created_Date",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Hidden_Value",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Last_Updated_By",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Last_Updated_Date",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Locale_ID",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Locale_Label",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Lookup_Name",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Lookup_Type",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Parent_Lookup_ID",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Sort_Order",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Tenant_ID",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "User_Editable",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Visible_Value",
                table: "TmX_Lookup");

            migrationBuilder.DropColumn(
                name: "Active_Flag",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Created_Date",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Effective_End_Date",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Effective_Start_Date",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Geography_Description",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Geography_Name",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Geography_Short_Code",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Geography_Type_Lkp_ID",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Last_Updated_By",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Last_Updated_Date",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Parent_Geography_ID",
                table: "TmX_Address_Geography");

            migrationBuilder.DropColumn(
                name: "Tenant_ID",
                table: "TmX_Address_Geography");

            migrationBuilder.RenameTable(
                name: "TmX_Address",
                newName: "TMX_Address");

            migrationBuilder.RenameTable(
                name: "TmX_Tenants",
                newName: "TMX_Tenant");

            migrationBuilder.RenameColumn(
                name: "Address_Geography_ID",
                table: "TmX_Address_Geography",
                newName: "Geography_ID");

            migrationBuilder.AddColumn<int>(
                name: "AddressGeographyGeography_ID",
                table: "TMX_Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressTypeLookupLookup_ID",
                table: "TMX_Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tenant_ID1",
                table: "TMX_Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TMX_Address",
                table: "TMX_Address",
                column: "Address_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TMX_Tenant",
                table: "TMX_Tenant",
                column: "Tenant_ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TMX_Address_TMX_Tenant_Tenant_ID1",
                table: "TMX_Address",
                column: "Tenant_ID1",
                principalTable: "TMX_Tenant",
                principalColumn: "Tenant_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TMX_Address_TmX_Address_Geography_AddressGeographyGeography_ID",
                table: "TMX_Address",
                column: "AddressGeographyGeography_ID",
                principalTable: "TmX_Address_Geography",
                principalColumn: "Geography_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TMX_Address_TmX_Lookup_AddressTypeLookupLookup_ID",
                table: "TMX_Address",
                column: "AddressTypeLookupLookup_ID",
                principalTable: "TmX_Lookup",
                principalColumn: "Lookup_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TmX_Product_TMX_Tenant_Tenant_ID",
                table: "TmX_Product",
                column: "Tenant_ID",
                principalTable: "TMX_Tenant",
                principalColumn: "Tenant_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
