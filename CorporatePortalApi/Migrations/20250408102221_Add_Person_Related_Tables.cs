using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class Add_Person_Related_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TmX_Person",
                columns: table => new
                {
                    Person_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Person_Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Person_Gender_Lkp = table.Column<int>(type: "int", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Person_Middle_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Person_Last_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Person_Marital_Status_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Birth_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Person_Calling_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Person_Education_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Residence_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Residence_Duration = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Person_Religion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Family_Head_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Person_Technical_Vocational_Training = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Person_Technical_Vocational_Training_Type_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Disability_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Person_Disability_Nature = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Family_Earning_Member_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Person_Health_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Profession_Type_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Total_Income_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Person_Total_Expense_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Person_Wedding_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Person_Current_Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Person_Permanent_Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Currency_ID = table.Column<int>(type: "int", nullable: true),
                    Person_Family_Identifier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Family_Children_Count = table.Column<int>(type: "int", nullable: true),
                    Family_Dependent_Count = table.Column<int>(type: "int", nullable: true),
                    Family_Members_Count = table.Column<int>(type: "int", nullable: true),
                    Family_Migrants_Count = table.Column<int>(type: "int", nullable: true),
                    Family_Earning_Members_Count = table.Column<int>(type: "int", nullable: true),
                    Person_Nationality_Lkp = table.Column<int>(type: "int", nullable: true),
                    Place_Of_Birth_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_Hobbies = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Person_Language_Preference_Lkp = table.Column<int>(type: "int", nullable: true),
                    UDF_Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Person", x => x.Person_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Person_TmX_Currency_Currency_ID",
                        column: x => x.Currency_ID,
                        principalTable: "TmX_Currency",
                        principalColumn: "Currency_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Person_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Customer_Detail",
                columns: table => new
                {
                    Customer_Detail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tax_Filer = table.Column<int>(type: "int", nullable: true),
                    National_Tax_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Customer_Relationship_Contract = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Existing_Account_Holder = table.Column<int>(type: "int", nullable: true),
                    Priority_Customer = table.Column<int>(type: "int", nullable: true),
                    Loyalty_Points = table.Column<int>(type: "int", nullable: true),
                    Ever_Discontinued_Priority = table.Column<int>(type: "int", nullable: true),
                    Reason_For_Discontinuity_Lkp = table.Column<int>(type: "int", nullable: true),
                    Frequency_Of_Contracting_RM_Lkp = table.Column<int>(type: "int", nullable: true),
                    Preferred_Mode_Of_Communication_Lkp = table.Column<int>(type: "int", nullable: true),
                    Relation_With_Banks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Customer_Master_Id = table.Column<int>(type: "int", nullable: false),
                    SMS_Alert = table.Column<int>(type: "int", nullable: true),
                    Website_Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Customer_Profile = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    High_Risk_Approval = table.Column<int>(type: "int", nullable: true),
                    Political_Figure_Approved_Obtained = table.Column<int>(type: "int", nullable: true),
                    Political_Figure_Name = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: true),
                    Relative_Political_Figure = table.Column<int>(type: "int", nullable: true),
                    Risk_Level = table.Column<int>(type: "int", nullable: true),
                    Sources_Of_Funds = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    Expected_Cities_Txn = table.Column<int>(type: "int", nullable: true),
                    Expected_Countries_Txn = table.Column<int>(type: "int", nullable: true),
                    Expected_Counter_Parties = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
                    Branch_Comments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Customer_Total_Family_Income_Amount = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    Customer_Total_Family_Expense_Amount = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    Currency_ID = table.Column<int>(type: "int", nullable: true),
                    Person_ID = table.Column<int>(type: "int", nullable: true),
                    Customer_Total_Self_Income_Amount = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    Customer_Total_Self_Expense_Amount = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Currency_ID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Customer_Detail", x => x.Customer_Detail_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Detail_TmX_Currency_Currency_ID1",
                        column: x => x.Currency_ID1,
                        principalTable: "TmX_Currency",
                        principalColumn: "Currency_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Detail_TmX_Customer_Master_Customer_Master_Id",
                        column: x => x.Customer_Master_Id,
                        principalTable: "TmX_Customer_Master",
                        principalColumn: "Customer_Master_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Detail_TmX_Person_Person_ID",
                        column: x => x.Person_ID,
                        principalTable: "TmX_Person",
                        principalColumn: "Person_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Customer_Detail_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Person_Expense_Detail",
                columns: table => new
                {
                    Person_Expense_Detail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expense_Source_Lkp = table.Column<int>(type: "int", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Currency_ID = table.Column<int>(type: "int", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Monthly_Expense_Amount = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Person_ID = table.Column<int>(type: "int", nullable: false),
                    Expense_Mode_Lkp = table.Column<int>(type: "int", nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Order_ID = table.Column<int>(type: "int", nullable: true),
                    Total_Monthly_Expenses = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Person_Expense_Detail", x => x.Person_Expense_Detail_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Person_Expense_Detail_TmX_Currency_Currency_ID",
                        column: x => x.Currency_ID,
                        principalTable: "TmX_Currency",
                        principalColumn: "Currency_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Person_Expense_Detail_TmX_Order_Order_ID",
                        column: x => x.Order_ID,
                        principalTable: "TmX_Order",
                        principalColumn: "Order_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Person_Expense_Detail_TmX_Person_Person_ID",
                        column: x => x.Person_ID,
                        principalTable: "TmX_Person",
                        principalColumn: "Person_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Person_Expense_Detail_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Person_Income_Detail",
                columns: table => new
                {
                    Person_Income_Detail_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Income_Source_Lkp = table.Column<int>(type: "int", nullable: true),
                    Monthly_Income_Amount = table.Column<decimal>(type: "decimal(17,3)", nullable: true),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Currency_ID = table.Column<int>(type: "int", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: true),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary_Income_Mode_Lkp = table.Column<int>(type: "int", nullable: true),
                    Person_ID = table.Column<int>(type: "int", nullable: false),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UDF_Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Person_Income_Detail", x => x.Person_Income_Detail_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Person_Income_Detail_TmX_Currency_Currency_ID",
                        column: x => x.Currency_ID,
                        principalTable: "TmX_Currency",
                        principalColumn: "Currency_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Person_Income_Detail_TmX_Order_Order_ID",
                        column: x => x.Order_ID,
                        principalTable: "TmX_Order",
                        principalColumn: "Order_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Person_Income_Detail_TmX_Person_Person_ID",
                        column: x => x.Person_ID,
                        principalTable: "TmX_Person",
                        principalColumn: "Person_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Person_Income_Detail_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Person_National_Identifier",
                columns: table => new
                {
                    Person_National_Identifier_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    National_ID_Type_Lkp = table.Column<int>(type: "int", nullable: false),
                    National_Identifier_Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    National_ID_Issue_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    National_ID_Expiry_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Person_ID = table.Column<int>(type: "int", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Document_Type = table.Column<int>(type: "int", nullable: true),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Place_Of_Issue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nationality_Lkp = table.Column<int>(type: "int", nullable: true),
                    Order_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Person_National_Identifier", x => x.Person_National_Identifier_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Person_National_Identifier_TmX_Order_Order_ID",
                        column: x => x.Order_ID,
                        principalTable: "TmX_Order",
                        principalColumn: "Order_ID");
                    table.ForeignKey(
                        name: "FK_TmX_Person_National_Identifier_TmX_Person_Person_ID",
                        column: x => x.Person_ID,
                        principalTable: "TmX_Person",
                        principalColumn: "Person_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Person_National_Identifier_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Person_To_Address_Mapping",
                columns: table => new
                {
                    Person_To_Address_Map_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address_Id = table.Column<int>(type: "int", nullable: false),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Person_To_Address_Mapping", x => x.Person_To_Address_Map_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Person_To_Address_Mapping_TmX_Address_Address_Id",
                        column: x => x.Address_Id,
                        principalTable: "TmX_Address",
                        principalColumn: "Address_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TmX_Person_To_Address_Mapping_TmX_Person_Person_Id",
                        column: x => x.Person_Id,
                        principalTable: "TmX_Person",
                        principalColumn: "Person_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmX_Person_Address_Contact",
                columns: table => new
                {
                    Person_Address_Contact_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenant_ID = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Updated_By = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Contact_Type_Lkp = table.Column<int>(type: "int", nullable: false),
                    Active_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Effective_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Effective_End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact_Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Contact_Extension = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Primary_Contact_Flag = table.Column<bool>(type: "bit", nullable: false),
                    Contact_Email_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Person_To_Address_Map_ID = table.Column<int>(type: "int", nullable: false),
                    Mobile_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmX_Person_Address_Contact", x => x.Person_Address_Contact_ID);
                    table.ForeignKey(
                        name: "FK_TmX_Person_Address_Contact_TmX_Person_To_Address_Mapping_Person_To_Address_Map_ID",
                        column: x => x.Person_To_Address_Map_ID,
                        principalTable: "TmX_Person_To_Address_Mapping",
                        principalColumn: "Person_To_Address_Map_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TmX_Person_Address_Contact_TmX_Tenants_Tenant_ID",
                        column: x => x.Tenant_ID,
                        principalTable: "TmX_Tenants",
                        principalColumn: "Tenant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Detail_Currency_ID1",
                table: "TmX_Customer_Detail",
                column: "Currency_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Detail_Customer_Master_Id",
                table: "TmX_Customer_Detail",
                column: "Customer_Master_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Detail_Person_ID",
                table: "TmX_Customer_Detail",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Customer_Detail_Tenant_ID",
                table: "TmX_Customer_Detail",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Currency_ID",
                table: "TmX_Person",
                column: "Currency_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Tenant_ID",
                table: "TmX_Person",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Address_Contact_Person_To_Address_Map_ID",
                table: "TmX_Person_Address_Contact",
                column: "Person_To_Address_Map_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Address_Contact_Tenant_ID",
                table: "TmX_Person_Address_Contact",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Expense_Detail_Currency_ID",
                table: "TmX_Person_Expense_Detail",
                column: "Currency_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Expense_Detail_Order_ID",
                table: "TmX_Person_Expense_Detail",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Expense_Detail_Person_ID",
                table: "TmX_Person_Expense_Detail",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Expense_Detail_Tenant_ID",
                table: "TmX_Person_Expense_Detail",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Income_Detail_Currency_ID",
                table: "TmX_Person_Income_Detail",
                column: "Currency_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Income_Detail_Order_ID",
                table: "TmX_Person_Income_Detail",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Income_Detail_Person_ID",
                table: "TmX_Person_Income_Detail",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_Income_Detail_Tenant_ID",
                table: "TmX_Person_Income_Detail",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_National_Identifier_Order_ID",
                table: "TmX_Person_National_Identifier",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_National_Identifier_Person_ID",
                table: "TmX_Person_National_Identifier",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_National_Identifier_Tenant_ID",
                table: "TmX_Person_National_Identifier",
                column: "Tenant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_To_Address_Mapping_Address_Id",
                table: "TmX_Person_To_Address_Mapping",
                column: "Address_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TmX_Person_To_Address_Mapping_Person_Id",
                table: "TmX_Person_To_Address_Mapping",
                column: "Person_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TmX_Customer_Detail");

            migrationBuilder.DropTable(
                name: "TmX_Person_Address_Contact");

            migrationBuilder.DropTable(
                name: "TmX_Person_Expense_Detail");

            migrationBuilder.DropTable(
                name: "TmX_Person_Income_Detail");

            migrationBuilder.DropTable(
                name: "TmX_Person_National_Identifier");

            migrationBuilder.DropTable(
                name: "TmX_Person_To_Address_Mapping");

            migrationBuilder.DropTable(
                name: "TmX_Person");
        }
    }
}
