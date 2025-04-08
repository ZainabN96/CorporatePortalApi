using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class Add_Tables_Again_ChangeDatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TmX_Account_Application",
                columns: table => new
                {
                    Account_Application_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account_Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Balance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account_Application_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Account_Application", x => x.Account_Application_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Address_Geography",
                columns: table => new
                {
                    Address_Geography_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parent_Geography_ID = table.Column<int>(type: "int", nullable: true),
                    Geography_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Geography_Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Geography_Short_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Geography_Type_Lkp_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Address_Geography", x => x.Address_Geography_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Bank",
                columns: table => new
                {
                    Bank_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bank_API_Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Admin_Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Admin_Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bank_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bank_Contact_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Data_Sync_Enabled = table.Column<bool>(type: "bit", nullable: true),
                    Cloud_API_Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cloud_Admin_Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cloud_Admin_Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Parent1_To_Admin_Sync = table.Column<bool>(type: "bit", nullable: true),
                    Admin_To_Parent2_Sync = table.Column<bool>(type: "bit", nullable: true),
                    Parent2_To_Admin_Sync = table.Column<bool>(type: "bit", nullable: true),
                    Employment_Type_Hint = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: true),
                    Iframe_Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Bypass_OTP_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Is_Visible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Bank", x => x.Bank_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Company_Branch",
                columns: table => new
                {
                    Customer_Branch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Branch_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Branch_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Branch_Type_Lkp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Company_Branch", x => x.Customer_Branch_Id);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Currency",
                columns: table => new
                {
                    Currency_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Currency_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Currency_Symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Currency_Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Currency", x => x.Currency_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Geofence",
                columns: table => new
                {
                    Geofence_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Geofence_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Geofence_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Geofence", x => x.Geofence_Id);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Institute",
                columns: table => new
                {
                    Institute_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Institute_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Institute_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Institute", x => x.Institute_ID);
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
                name: "TmX_Lookup",
                columns: table => new
                {
                    Lookup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parent_Lookup_ID = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Lookup_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: true),
                    Hidden_Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Visible_Value = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    User_Editable = table.Column<int>(type: "int", nullable: true),
                    Sort_Order = table.Column<int>(type: "int", nullable: true),
                    Lookup_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Locale_Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locale_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Lookup", x => x.Lookup_ID);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Product_Checklist",
                columns: table => new
                {
                    Product_Checklist_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attachment_Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Product_Checklist", x => x.Product_Checklist_Id);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Tab",
                columns: table => new
                {
                    Tab_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tab_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tab_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Tab", x => x.Tab_Id);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Tenants",
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
                    table.PrimaryKey("PK_TmX_Tenants", x => x.Tenant_ID);
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
                name: "TmX_Transaction",
                columns: table => new
                {
                    Transaction_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transaction_code = table.Column<int>(type: "int", nullable: false),
                    Transaction_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Transaction_desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Transaction", x => x.Transaction_Id);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Address",
                columns: table => new
                {
                    Address_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address_Geography_ID = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
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
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Address", x => x.Address_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Address_TmX_Address_Geography_Address_Geography_ID",
                        column: x => x.Address_Geography_ID,
                        principalTable: "TmX_Address_Geography",
                        principalColumn: "Address_Geography_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TmX_Address_TmX_Lookup_Address_Type_Lkp_ID",
                        column: x => x.Address_Type_Lkp_ID,
                        principalTable: "TmX_Lookup",
                        principalColumn: "Lookup_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TmX_Address_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "TmX_Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Product_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Product_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Product_Type_Lkp = table.Column<int>(type: "int", nullable: false),
                    Product_Tenure_Months = table.Column<int>(type: "int", nullable: true),
                    Repayment_Mode_Lkp = table.Column<int>(type: "int", nullable: true),
                    Repayment_Frequency_Lkp = table.Column<int>(type: "int", nullable: true),
                    Documentation_Fee = table.Column<decimal>(type: "numeric(9,4)", nullable: true),
                    Service_Fee = table.Column<decimal>(type: "numeric(9,4)", nullable: true),
                    Processing_Fee = table.Column<decimal>(type: "numeric(9,4)", nullable: true),
                    Currency_ID = table.Column<int>(type: "int", nullable: false),
                    Group_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Workflow_Scheme_Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Individual_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Product_Classification_Lkp = table.Column<int>(type: "int", nullable: true),
                    Bank_Id = table.Column<int>(type: "int", nullable: true),
                    Execute_Parser_Scorecard_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Manual_Doc_Collection_Enabled_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Monthly_Repayment_Due_Day = table.Column<int>(type: "int", nullable: true),
                    Shortlisting_Rules_Lookup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Max_Allowed_Loan_Limit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Max_Sub_Product_Count = table.Column<int>(type: "int", nullable: true),
                    Ask_Bank_Details_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Company_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDC_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Payment_Allowed = table.Column<bool>(type: "bit", nullable: false),
                    Onboarded_Corportate_Employees = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Product", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Product_TmX_Bank_Bank_Id",
                        column: x => x.Bank_Id,
                        principalTable: "TmX_Bank",
                        principalColumn: "Bank_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Product_TmX_Currency_Currency_ID",
                        column: x => x.Currency_ID,
                        principalTable: "TmX_Currency",
                        principalColumn: "Currency_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Product_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
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
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Address_ID = table.Column<int>(type: "int", nullable: true),
                    Locale_ID = table.Column<int>(type: "int", nullable: true),
                    Time_Zone_ID = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_AspNetUsers_TmX_Address_Address_ID",
                        column: x => x.Address_ID,
                        principalTable: "TmX_Address",
                        principalColumn: "Address_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TmX_Locale_Locale_ID",
                        column: x => x.Locale_ID,
                        principalTable: "TmX_Locale",
                        principalColumn: "Locale_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TmX_Time_Zone_Time_Zone_ID",
                        column: x => x.Time_Zone_ID,
                        principalTable: "TmX_Time_Zone",
                        principalColumn: "Time_Zone_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Customer_Master",
                columns: table => new
                {
                    Customer_Master_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Customer_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Customer_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Customer_Type_Lkp = table.Column<int>(type: "int", nullable: true),
                    Customer_Classification_Lkp = table.Column<int>(type: "int", nullable: true),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tenant_Id = table.Column<int>(type: "int", nullable: false),
                    Location_Id = table.Column<int>(type: "int", nullable: true),
                    Multi_Site_Customer_Flag = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    National_ID_Type_Lkp = table.Column<int>(type: "int", nullable: true),
                    National_Identifier_Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Customer_Status_Lkp = table.Column<int>(type: "int", nullable: true),
                    FATCA_Class_Lkp = table.Column<int>(type: "int", nullable: true),
                    Relationship_Code_Lkp = table.Column<int>(type: "int", nullable: true),
                    Customer_Segment_Lkp = table.Column<int>(type: "int", nullable: true),
                    Customer_Sub_Segment_Lkp = table.Column<int>(type: "int", nullable: true),
                    Entity_Type_Lkp = table.Column<int>(type: "int", nullable: true),
                    Same_As_Above_Lkp = table.Column<int>(type: "int", nullable: true),
                    ETB_Flag = table.Column<int>(type: "int", nullable: true),
                    udf_data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NTI_Flag = table.Column<bool>(type: "bit", nullable: false),
                    FRMU_Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SLS_Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    neg_customer = table.Column<bool>(type: "bit", nullable: true),
                    neg_area = table.Column<bool>(type: "bit", nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Transaction_Id = table.Column<int>(type: "int", nullable: true),
                    Suggested_Loan_Amount = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    Is_SA_User = table.Column<bool>(type: "bit", nullable: true),
                    SA_User_Created = table.Column<bool>(type: "bit", nullable: true),
                    Customer_Phone_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Customer_Email_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Customer_Total_Limit = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Customer_Master", x => x.Customer_Master_Id);
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Master_TmX_Location_Location_Id",
                        column: x => x.Location_Id,
                        principalTable: "TmX_Location",
                        principalColumn: "Location_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Master_TmX_Tenants_Tenant_Id",
                        column: x => x.Tenant_Id,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Master_TmX_Transaction_Transaction_Id",
                        column: x => x.Transaction_Id,
                        principalTable: "TmX_Transaction",
                        principalColumn: "Transaction_Id");
                });

            migrationBuilder.CreateTable(
                name: "TmX_User",
                columns: table => new
                {
                    User_ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    Parent_User_ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    Address_ID = table.Column<int>(type: "int", nullable: true),
                    Time_Zone_ID = table.Column<int>(type: "int", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Middle_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Contact_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    User_Image_URL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Primary_National_Identifier_Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Mobile_User_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Primary_National_ID_Type_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    User_Type_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    Designation_Lkp_ID = table.Column<int>(type: "int", nullable: true),
                    Server_User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Server_Branch_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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
                name: "TmX_Corporate",
                columns: table => new
                {
                    Corporate_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Corporate_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Corporate_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Corporate_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corporate_NTN_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Corporate_Bank_Account = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Corporate_Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Corporate_Email_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Corporate_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corporate_URL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Default_Product_Id = table.Column<int>(type: "int", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Corporate", x => x.Corporate_Id);
                    table.ForeignKey(
                        name: "FK_TmX_Corporate_TmX_Product_Default_Product_Id",
                        column: x => x.Default_Product_Id,
                        principalTable: "TmX_Product",
                        principalColumn: "Product_ID");
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
                name: "TmX_Order",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order_Gross_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Customer_Master_ID = table.Column<int>(type: "int", nullable: false),
                    Discount_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Order_Net_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Order_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Financing_Status_Lkp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UDF_Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dlp_Order_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Financing_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Accepted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cancelled_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rejected_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Goods_Issuance_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delivered_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delivered_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Institute_Id = table.Column<int>(type: "int", nullable: true),
                    Product_Id = table.Column<int>(type: "int", nullable: true),
                    Is_Ecib_Evaluation_Successful = table.Column<bool>(type: "bit", nullable: true),
                    Execute_Parser_Scorecard_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Executed_Rules_Json = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expected_Degree_Completion_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Student_Bill_Paid = table.Column<bool>(type: "bit", nullable: true),
                    Corporate_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Order", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Order_TmX_Corporate_Corporate_Id",
                        column: x => x.Corporate_Id,
                        principalTable: "TmX_Corporate",
                        principalColumn: "Corporate_Id");
                    table.ForeignKey(
                        name: "FK_TmX_Order_TmX_Customer_Master_Customer_Master_ID",
                        column: x => x.Customer_Master_ID,
                        principalTable: "TmX_Customer_Master",
                        principalColumn: "Customer_Master_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TmX_Order_TmX_Institute_Institute_Id",
                        column: x => x.Institute_Id,
                        principalTable: "TmX_Institute",
                        principalColumn: "Institute_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Order_TmX_Product_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "TmX_Product",
                        principalColumn: "Product_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Order_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmX_User_To_Corporate_Mapping",
                columns: table => new
                {
                    User_To_Corporate_Mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    Corporate_Id = table.Column<int>(type: "int", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "TmX_Loan_Application",
                columns: table => new
                {
                    Loan_Application_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Branch_Id = table.Column<int>(type: "int", nullable: false),
                    Tenant_Id = table.Column<int>(type: "int", nullable: false),
                    Loan_Product_Id = table.Column<int>(type: "int", nullable: false),
                    Client_Reference_Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Loan_Application_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Requested_Loan_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Approved_Loan_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Total_Recieiveable_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Loan_Disbursement_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Loan_Maturity_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total_Installments = table.Column<int>(type: "int", nullable: true),
                    Installment_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    User_Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    Currency_Id = table.Column<int>(type: "int", nullable: true),
                    Insurance_Premium_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Asset_Insurance_Premium_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Application_Status_Lkp = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Loan_Application_Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Total_Tenure = table.Column<int>(type: "int", nullable: true),
                    Other_Loan_Institute_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Other_Loan_Total_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Other_Loan_Usage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Service_Charges = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Documentation_Fee = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Process_Instance_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Loan_Cycle = table.Column<int>(type: "int", nullable: true),
                    Channel_Reference_Id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Geofence_Id = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nchar(50)", nullable: true),
                    Error = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Accumulative_Poverty_Score = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Accumulated_Credit_Score = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Type_Of_Screening_Lkp = table.Column<int>(type: "int", nullable: true),
                    Loan_Type = table.Column<int>(type: "int", nullable: true),
                    Utilization_Comments = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    App_Version_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Other_Loan_Outstanding_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Total_Loan_Utilization = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Previous_Loan_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Other_Loan_Completion_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Previous_Psc_Score = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Training_Fee = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Loan_Purpose = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    Is_Nominee_Available = table.Column<int>(type: "int", nullable: true),
                    MW_Posted_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Multiple_Loan_Indicator_Lkp = table.Column<int>(type: "int", nullable: true),
                    Loan_Utilization_Check_Lkp = table.Column<int>(type: "int", nullable: true),
                    Takaful_Amount = table.Column<decimal>(type: "decimal(13,4)", nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Is_Attached = table.Column<bool>(type: "bit", nullable: true),
                    Customer_Master_Id = table.Column<int>(type: "int", nullable: true),
                    Order_ID = table.Column<int>(type: "int", nullable: true),
                    Loan_Application_Submission_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Loan_Disclosure_Report_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Overriden_Loan_Limit = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Overriden_Loan_Limit_Flag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Loan_Application", x => x.Loan_Application_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Company_Branch_Company_Branch_Id",
                        column: x => x.Company_Branch_Id,
                        principalTable: "TmX_Company_Branch",
                        principalColumn: "Customer_Branch_Id");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Currency_Currency_Id",
                        column: x => x.Currency_Id,
                        principalTable: "TmX_Currency",
                        principalColumn: "Currency_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Customer_Master_Customer_Master_Id",
                        column: x => x.Customer_Master_Id,
                        principalTable: "TmX_Customer_Master",
                        principalColumn: "Customer_Master_Id");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Geofence_Geofence_Id",
                        column: x => x.Geofence_Id,
                        principalTable: "TmX_Geofence",
                        principalColumn: "Geofence_Id");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Order_Order_ID",
                        column: x => x.Order_ID,
                        principalTable: "TmX_Order",
                        principalColumn: "Order_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Product_Loan_Product_Id",
                        column: x => x.Loan_Product_Id,
                        principalTable: "TmX_Product",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_Tenants_Tenant_Id",
                        column: x => x.Tenant_Id,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_TmX_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "TmX_User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateTable(
                name: "TmX_Loan_Application_Checklist",
                columns: table => new
                {
                    Loan_Application_Checklist_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attachment_Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Loan_Product_Checklist_Id = table.Column<int>(type: "int", nullable: true),
                    Loan_Application_ID = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image_Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verification_Required = table.Column<bool>(type: "bit", nullable: true),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    Account_Application_ID = table.Column<int>(type: "int", nullable: true),
                    User_ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tab_ID = table.Column<int>(type: "int", nullable: true),
                    Verification_Outcome_Lkp = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Attachment_Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Is_Front_Side = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Loan_Application_Checklist", x => x.Loan_Application_Checklist_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_Account_Application_Account_Application_ID",
                        column: x => x.Account_Application_ID,
                        principalTable: "TmX_Account_Application",
                        principalColumn: "Account_Application_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_Loan_Application_Loan_Application_ID",
                        column: x => x.Loan_Application_ID,
                        principalTable: "TmX_Loan_Application",
                        principalColumn: "Loan_Application_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_Location_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "TmX_Location",
                        principalColumn: "Location_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_Product_Checklist_Loan_Product_Checklist_Id",
                        column: x => x.Loan_Product_Checklist_Id,
                        principalTable: "TmX_Product_Checklist",
                        principalColumn: "Product_Checklist_Id");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_Tab_Tab_ID",
                        column: x => x.Tab_ID,
                        principalTable: "TmX_Tab",
                        principalColumn: "Tab_Id");
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Loan_Application_Checklist_TmX_User_User_ID",
                        column: x => x.User_ID,
                        principalTable: "TmX_User",
                        principalColumn: "User_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Address_ID",
                table: "AspNetUsers",
                column: "Address_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Locale_ID",
                table: "AspNetUsers",
                column: "Locale_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tenant_ID",
                table: "AspNetUsers",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Time_Zone_ID",
                table: "AspNetUsers",
                column: "Time_Zone_ID");

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
                name: "IX_TmX_Corporate_Default_Product_Id",
                table: "TmX_Corporate",
                column: "Default_Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Master_Location_Id",
                table: "TmX_Customer_Master",
                column: "Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Master_Tenant_Id",
                table: "TmX_Customer_Master",
                column: "Tenant_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Master_Transaction_Id",
                table: "TmX_Customer_Master",
                column: "Transaction_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Company_Branch_Id",
                table: "TmX_Loan_Application",
                column: "Company_Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Currency_Id",
                table: "TmX_Loan_Application",
                column: "Currency_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Customer_Master_Id",
                table: "TmX_Loan_Application",
                column: "Customer_Master_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Geofence_Id",
                table: "TmX_Loan_Application",
                column: "Geofence_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Loan_Product_Id",
                table: "TmX_Loan_Application",
                column: "Loan_Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Order_ID",
                table: "TmX_Loan_Application",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Tenant_Id",
                table: "TmX_Loan_Application",
                column: "Tenant_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_User_Id",
                table: "TmX_Loan_Application",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_Account_Application_ID",
                table: "TmX_Loan_Application_Checklist",
                column: "Account_Application_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_Loan_Application_ID",
                table: "TmX_Loan_Application_Checklist",
                column: "Loan_Application_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_Loan_Product_Checklist_Id",
                table: "TmX_Loan_Application_Checklist",
                column: "Loan_Product_Checklist_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_Location_ID",
                table: "TmX_Loan_Application_Checklist",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_Tab_ID",
                table: "TmX_Loan_Application_Checklist",
                column: "Tab_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_Tenant_ID",
                table: "TmX_Loan_Application_Checklist",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Loan_Application_Checklist_User_ID",
                table: "TmX_Loan_Application_Checklist",
                column: "User_ID");

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
                name: "IX_TmX_Order_Corporate_Id",
                table: "TmX_Order",
                column: "Corporate_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Order_Customer_Master_ID",
                table: "TmX_Order",
                column: "Customer_Master_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Order_Institute_Id",
                table: "TmX_Order",
                column: "Institute_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Order_Product_Id",
                table: "TmX_Order",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Order_Tenant_ID",
                table: "TmX_Order",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Product_Bank_Id",
                table: "TmX_Product",
                column: "Bank_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Product_Currency_ID",
                table: "TmX_Product",
                column: "Currency_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Product_Tenant_ID",
                table: "TmX_Product",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "TmX_Loan_Application_Checklist");

            migrationBuilder.DropTable(
                name: "TmX_User_To_Corporate_Mapping");

            migrationBuilder.DropTable(
                name: "AspNetRole");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TmX_Account_Application");

            migrationBuilder.DropTable(
                name: "TmX_Loan_Application");

            migrationBuilder.DropTable(
                name: "TmX_Product_Checklist");

            migrationBuilder.DropTable(
                name: "TmX_Tab");

            migrationBuilder.DropTable(
                name: "TmX_Locale");

            migrationBuilder.DropTable(
                name: "TmX_Company_Branch");

            migrationBuilder.DropTable(
                name: "TmX_Geofence");

            migrationBuilder.DropTable(
                name: "TmX_Order");

            migrationBuilder.DropTable(
                name: "TmX_User");

            migrationBuilder.DropTable(
                name: "TmX_Corporate");

            migrationBuilder.DropTable(
                name: "TmX_Customer_Master");

            migrationBuilder.DropTable(
                name: "TmX_Institute");

            migrationBuilder.DropTable(
                name: "TmX_Address");

            migrationBuilder.DropTable(
                name: "TmX_Time_Zone");

            migrationBuilder.DropTable(
                name: "TmX_Product");

            migrationBuilder.DropTable(
                name: "TmX_Location");

            migrationBuilder.DropTable(
                name: "TmX_Transaction");

            migrationBuilder.DropTable(
                name: "TmX_Address_Geography");

            migrationBuilder.DropTable(
                name: "TmX_Bank");

            migrationBuilder.DropTable(
                name: "TmX_Currency");

            migrationBuilder.DropTable(
                name: "TmX_Lookup");

            migrationBuilder.DropTable(
                name: "TmX_Tenants");
        }
    }
}
