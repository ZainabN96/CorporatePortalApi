using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporatePortalApi.Models
{
	public class TmX_Loan_Application_Checklist
	{
		[Key]
		public int Loan_Application_Checklist_ID { get; set; }

		[MaxLength(500)]
		public string? Attachment_Url { get; set; }

		public int? Loan_Product_Checklist_Id { get; set; }
		public int? Loan_Application_ID { get; set; }
		public int Tenant_ID { get; set; }
		public bool Active_Flag { get; set; }

		[Required]
		public DateTime Effective_Start_Date { get; set; }

		[Required]
		public DateTime Effective_End_Date { get; set; }

		[Required]
		[MaxLength(100)]
		public string Created_By { get; set; }

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(100)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }
		public string? Image_Data { get; set; }
		public bool? Verification_Required { get; set; }
		public int? Location_ID { get; set; }
		public int? Account_Application_ID { get; set; }

		[MaxLength(50)]
		public string? User_ID { get; set; }

		public Guid? Mobile_ID { get; set; }
		public int? Tab_ID { get; set; }
		public int? Verification_Outcome_Lkp { get; set; }

		[MaxLength(1000)]
		public string? Comments { get; set; }

		[MaxLength(150)]
		public string? Attachment_Name { get; set; }

		public bool Is_Front_Side { get; set; } = true;

		[ForeignKey("Location_ID")]
		public virtual TmX_Location Location { get; set; }

		[ForeignKey("Account_Application_ID")]
		public virtual TmX_Account_Application Account_Application { get; set; }

		[ForeignKey("User_ID")]
		public virtual TmX_User User { get; set; }

		[ForeignKey("Tab_ID")]
		public virtual TmX_Tab Tab { get; set; }

		[ForeignKey("Loan_Application_ID")]
		public virtual TmX_Loan_Application Loan_Application { get; set; }

		[ForeignKey("Loan_Product_Checklist_Id")]
		public virtual TmX_Product_Checklist Product_Checklist { get; set; }

		[ForeignKey("Tenant_ID")]
		public virtual TmX_Tenant Tenant { get; set; }
	}
}
