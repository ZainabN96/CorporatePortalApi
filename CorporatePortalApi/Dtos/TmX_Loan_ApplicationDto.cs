namespace CorporatePortalApi.Dtos
{
	public class TmX_Loan_ApplicationDto
	{
		public int Loan_Application_ID { get; set; }
		public int Company_Branch_Id { get; set; }
		public int Tenant_Id { get; set; }
		public int Loan_Product_Id { get; set; }
		public string? Client_Reference_Number { get; set; }
		public DateTime Loan_Application_Date { get; set; }
		public decimal? Requested_Loan_Amount { get; set; }
		public decimal? Approved_Loan_Amount { get; set; }
		public decimal? Total_Recieiveable_Amount { get; set; }
		public DateTime? Loan_Disbursement_Date { get; set; }
		public DateTime? Loan_Maturity_Date { get; set; }
		public int? Total_Installments { get; set; }
		public decimal? Installment_Amount { get; set; }
		public string? User_Id { get; set; }
		public int? Currency_Id { get; set; }
		public decimal? Insurance_Premium_Amount { get; set; }
		public decimal? Asset_Insurance_Premium_Amount { get; set; }
		public int Application_Status_Lkp { get; set; }
		public string Created_By { get; set; }
		public DateTime Created_Date { get; set; }
		public string? Last_Updated_By { get; set; }
		public DateTime? Last_Updated_Date { get; set; }
		public string? Loan_Application_Number { get; set; }
		public int? Total_Tenure { get; set; }
		public string? Other_Loan_Institute_Name { get; set; }
		public decimal? Other_Loan_Total_Amount { get; set; }
		public string? Other_Loan_Usage { get; set; }
		public decimal? Service_Charges { get; set; }
		public decimal? Documentation_Fee { get; set; }
		public Guid? Process_Instance_Id { get; set; }
		public int? Loan_Cycle { get; set; } = 1;
		public string? Channel_Reference_Id { get; set; }
		public int? Geofence_Id { get; set; }
		public string? Status { get; set; }
		public string? Error { get; set; }
		public decimal? Accumulative_Poverty_Score { get; set; }
		public decimal? Accumulated_Credit_Score { get; set; }
		public int? Type_Of_Screening_Lkp { get; set; }
		public int? Loan_Type { get; set; }
		public string? Utilization_Comments { get; set; }
		public string? App_Version_Number { get; set; }
		public decimal? Other_Loan_Outstanding_Amount { get; set; }
		public decimal? Total_Loan_Utilization { get; set; }
		public decimal? Previous_Loan_Amount { get; set; }
		public DateTime? Other_Loan_Completion_Date { get; set; }
		public decimal? Previous_Psc_Score { get; set; }
		public decimal? Training_Fee { get; set; }
		public string? Loan_Purpose { get; set; }
		public int? Is_Nominee_Available { get; set; }
		public DateTime? MW_Posted_Date { get; set; }
		public int? Multiple_Loan_Indicator_Lkp { get; set; }
		public int? Loan_Utilization_Check_Lkp { get; set; }
		public decimal? Takaful_Amount { get; set; }
		public Guid? Mobile_ID { get; set; }
		public bool? Is_Attached { get; set; } = false;
		public int? Customer_Master_Id { get; set; }
		public int? Order_ID { get; set; }
		public DateTime? Loan_Application_Submission_Date { get; set; }
		public string? Loan_Disclosure_Report_Name { get; set; }
		public decimal? Overriden_Loan_Limit { get; set; }
		public bool Overriden_Loan_Limit_Flag { get; set; } = false;
	}
}
