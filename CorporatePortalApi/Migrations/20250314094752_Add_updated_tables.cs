using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorporatePortalApi.Migrations
{
    /// <inheritdoc />
    public partial class Add_updated_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
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
                    User_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                        principalColumn: "Customer_Branch_Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
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
                    User_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TmX_Loan_Application_Checklist");

            migrationBuilder.DropTable(
                name: "TmX_Account_Application");

            migrationBuilder.DropTable(
                name: "TmX_Loan_Application");

            migrationBuilder.DropTable(
                name: "TmX_Product_Checklist");

            migrationBuilder.DropTable(
                name: "TmX_Tab");

            migrationBuilder.DropTable(
                name: "TmX_Company_Branch");

            migrationBuilder.DropTable(
                name: "TmX_Geofence");

            migrationBuilder.DropTable(
                name: "TmX_Order");

            migrationBuilder.DropTable(
                name: "TmX_Customer_Master");

            migrationBuilder.DropTable(
                name: "TmX_Institute");

            migrationBuilder.DropTable(
                name: "TmX_Transaction");
        }
    }
}
