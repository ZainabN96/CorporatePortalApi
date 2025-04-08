using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
	public class TmX_Loan_Application_ChecklistDto: BaseDto
	{
		public int Loan_Application_Checklist_ID { get; set; }
		public string? Attachment_Url { get; set; }
		public int? Loan_Product_Checklist_Id { get; set; }
		public int? Loan_Application_ID { get; set; }
		public int Tenant_ID { get; set; }
		public bool Active_Flag { get; set; }
		public DateTime Effective_Start_Date { get; set; }
		public DateTime Effective_End_Date { get; set; }
		public string Created_By { get; set; }
		public string? Last_Updated_By { get; set; }
		public string? Image_Data { get; set; }
		public bool? Verification_Required { get; set; }
		public int? Location_ID { get; set; }
		public int? Account_Application_ID { get; set; }
		public Guid? User_ID { get; set; }
		public Guid? Mobile_ID { get; set; }
		public int? Tab_ID { get; set; }
		public int? Verification_Outcome_Lkp { get; set; }
		public string? Comments { get; set; }
		public string? Attachment_Name { get; set; }
		public bool Is_Front_Side { get; set; } = true;
	}
}
