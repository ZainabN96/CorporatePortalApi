using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporatePortalApi.Models
{
	public class TmX_Loan_Application
	{
		[Key]
		public int Loan_Application_ID { get; set; }

		[Required]
		public int Company_Branch_Id { get; set; }

		[Required]
		public int Tenant_Id { get; set; }

		[Required]
		public int Loan_Product_Id { get; set; }

		[MaxLength(100)]
		public string? Client_Reference_Number { get; set; }

		public DateTime Loan_Application_Date { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Requested_Loan_Amount { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Approved_Loan_Amount { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Total_Recieiveable_Amount { get; set; }

		public DateTime? Loan_Disbursement_Date { get; set; }

		public DateTime? Loan_Maturity_Date { get; set; }

		public int? Total_Installments { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Installment_Amount { get; set; }

		[MaxLength(50)]
		public string? User_Id { get; set; }

		public int? Currency_Id { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Insurance_Premium_Amount { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Asset_Insurance_Premium_Amount { get; set; }

		[Required]
		public int Application_Status_Lkp { get; set; }

		[Required, MaxLength(100)]
		public string Created_By { get; set; }

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(100)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		[MaxLength(100)]
		public string? Loan_Application_Number { get; set; }

		public int? Total_Tenure { get; set; }

		[MaxLength(100)]
		public string? Other_Loan_Institute_Name { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Other_Loan_Total_Amount { get; set; }

		[MaxLength(200)]
		public string? Other_Loan_Usage { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Service_Charges { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Documentation_Fee { get; set; }

		public Guid? Process_Instance_Id { get; set; }

		public int? Loan_Cycle { get; set; } = 1;

		[MaxLength(100)]
		public string? Channel_Reference_Id { get; set; }

		public int? Geofence_Id { get; set; }

		[Column(TypeName = "nchar(50)")]
		public string? Status { get; set; }

		[MaxLength(500)]
		public string? Error { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Accumulative_Poverty_Score { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Accumulated_Credit_Score { get; set; }

		public int? Type_Of_Screening_Lkp { get; set; }

		public int? Loan_Type { get; set; }

		[MaxLength(999)]
		public string? Utilization_Comments { get; set; }

		[MaxLength(50)]
		public string? App_Version_Number { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Other_Loan_Outstanding_Amount { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Total_Loan_Utilization { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Previous_Loan_Amount { get; set; }

		public DateTime? Other_Loan_Completion_Date { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Previous_Psc_Score { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Training_Fee { get; set; }

		[MaxLength(999)]
		public string? Loan_Purpose { get; set; }

		public int? Is_Nominee_Available { get; set; }

		public DateTime? MW_Posted_Date { get; set; }

		public int? Multiple_Loan_Indicator_Lkp { get; set; }

		public int? Loan_Utilization_Check_Lkp { get; set; }

		[Column(TypeName = "decimal(13,4)")]
		public decimal? Takaful_Amount { get; set; }

		public Guid? Mobile_ID { get; set; }

		public bool? Is_Attached { get; set; } = false;

		public int? Customer_Master_Id { get; set; }

		public int? Order_ID { get; set; }

		public DateTime? Loan_Application_Submission_Date { get; set; }

		[MaxLength(100)]
		public string? Loan_Disclosure_Report_Name { get; set; }

		[Column(TypeName = "decimal(18,4)")]
		public decimal? Overriden_Loan_Limit { get; set; }

		public bool Overriden_Loan_Limit_Flag { get; set; } = false;

		[ForeignKey("Currency_Id")]
		public virtual TmX_Currency Currency { get; set; }

		[ForeignKey("Order_ID")]
		public virtual TmX_Order Order { get; set; }

		[ForeignKey("Company_Branch_Id")]
		public virtual TmX_Company_Branch Company_Branch { get; set; }

		[ForeignKey("Geofence_Id")]
		public virtual TmX_Geofence Geofence { get; set; }

		[ForeignKey("Loan_Product_Id")]
		public virtual TmX_Product Product { get; set; }

		[ForeignKey("Customer_Master_Id")]
		public virtual TmX_Customer_Master Customer_Master { get; set; }

		[ForeignKey("User_Id")]
		public virtual TmX_User User { get; set; }

		[ForeignKey("Tenant_Id")]
		public virtual TmX_Tenant Tenant { get; set; }
	}
}
