using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_Corporate : Migration
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
                name: "TMX_Tenant",
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
                    table.PrimaryKey("PK_TMX_Tenant", x => x.Tenant_ID);
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
                        name: "FK_TMX_Address_TMX_Tenant_Tenant_ID1",
                        column: x => x.Tenant_ID1,
                        principalTable: "TMX_Tenant",
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
                name: "TmX_Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Product_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Product_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Product_Type_Lkp = table.Column<int>(type: "int", nullable: false),
                    Product_Tenure_Months = table.Column<int>(type: "int", nullable: true),
                    Repayment_Mode_Lkp = table.Column<int>(type: "int", nullable: true),
                    Repayment_Frequency_Lkp = table.Column<int>(type: "int", nullable: true),
                    Documentation_Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Service_Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Processing_Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Currency_ID = table.Column<int>(type: "int", nullable: false),
                    Group_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Workflow_Scheme_Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Individual_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Product_Classification_Lkp = table.Column<int>(type: "int", nullable: true),
                    Bank_Id = table.Column<int>(type: "int", nullable: true),
                    Execute_Parser_Scorecard_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Manual_Doc_Collection_Enabled_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Monthly_Repayment_Due_Day = table.Column<int>(type: "int", nullable: true),
                    Shortlisting_Rules_Lookup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Max_Allowed_Loan_Limit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Max_Sub_Product_Count = table.Column<int>(type: "int", nullable: true),
                    Ask_Bank_Details_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Company_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDC_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Payment_Allowed = table.Column<bool>(type: "bit", nullable: false),
                    Onboarded_Corportate_Employees = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Product", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Product_TMX_Tenant_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TMX_Tenant",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "TmX_Corporate",
                columns: table => new
                {
                    Corporate_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Corporate_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Corporate_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Corporate_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Corporate_NTN_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Corporate_Bank_Account = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Corporate_Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Corporate_Email_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Corporate_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Corporate_URL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Default_Product_Id = table.Column<int>(type: "int", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Corporate_Default_Product_Id",
                table: "TmX_Corporate",
                column: "Default_Product_Id");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TMX_Address");

            migrationBuilder.DropTable(
                name: "TmX_Corporate");

            migrationBuilder.DropTable(
                name: "TmX_Address_Geography");

            migrationBuilder.DropTable(
                name: "TmX_Lookup");

            migrationBuilder.DropTable(
                name: "TmX_Product");

            migrationBuilder.DropTable(
                name: "TMX_Tenant");

            migrationBuilder.DropTable(
                name: "TmX_Bank");

            migrationBuilder.DropTable(
                name: "TmX_Currency");
        }
    }
}
