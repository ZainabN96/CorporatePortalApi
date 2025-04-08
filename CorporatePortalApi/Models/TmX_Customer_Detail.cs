using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CorporatePortalApi.Models
{
	public class TmX_Customer_Detail
	{
		[Key]
		public int Customer_Detail_ID { get; set; }

		public int? Tax_Filer { get; set; }

		[MaxLength(50)]
		public string? National_Tax_Number { get; set; }

		public DateTime? Customer_Relationship_Contract { get; set; }

		public int? Existing_Account_Holder { get; set; }

		public int? Priority_Customer { get; set; }

		public int? Loyalty_Points { get; set; }

		public int? Ever_Discontinued_Priority { get; set; }

		public int? Reason_For_Discontinuity_Lkp { get; set; }

		public int? Frequency_Of_Contracting_RM_Lkp { get; set; }

		public int? Preferred_Mode_Of_Communication_Lkp { get; set; }

		[MaxLength(200)]
		public string? Relation_With_Banks { get; set; }

		[Required]
		[ForeignKey("CustomerMaster")]
		public int Customer_Master_Id { get; set; }

		public int? SMS_Alert { get; set; }

		[MaxLength(250)]
		public string? Website_Address { get; set; }

		[MaxLength(999)]
		public string? Customer_Profile { get; set; }

		public int? High_Risk_Approval { get; set; }

		public int? Political_Figure_Approved_Obtained { get; set; }

		[MaxLength(99)]
		public string? Political_Figure_Name { get; set; }

		public int? Relative_Political_Figure { get; set; }

		public int? Risk_Level { get; set; }

		[MaxLength(999)]
		public string? Sources_Of_Funds { get; set; }

		public int? Expected_Cities_Txn { get; set; }

		public int? Expected_Countries_Txn { get; set; }

		[MaxLength(999)]
		public string? Expected_Counter_Parties { get; set; }

		[MaxLength(200)]
		public string? Branch_Comments { get; set; }

		[Required]
		[ForeignKey("Tenant")]
		public int Tenant_ID { get; set; }

		[Required]
		[MaxLength(100)]
		public string Created_By { get; set; } = string.Empty;

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(100)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		[Column(TypeName = "decimal(17,3)")]
		public decimal? Customer_Total_Family_Income_Amount { get; set; }

		[Column(TypeName = "decimal(17,3)")]
		public decimal? Customer_Total_Family_Expense_Amount { get; set; }

		
		public int? Currency_ID { get; set; }

		[ForeignKey("Person")]
		public int? Person_ID { get; set; }

		[Column(TypeName = "decimal(17,3)")]
		public decimal? Customer_Total_Self_Income_Amount { get; set; }

		[Column(TypeName = "decimal(17,3)")]
		public decimal? Customer_Total_Self_Expense_Amount { get; set; }

		[Required]
		public bool Active_Flag { get; set; }

		[Required]
		public DateTime Effective_Start_Date { get; set; }

		[Required]
		public DateTime Effective_End_Date { get; set; }

		public Guid? Mobile_ID { get; set; }

		public virtual TmX_Customer_Master? CustomerMaster { get; set; }
		public virtual TmX_Person? Person { get; set; }
		public virtual TmX_Tenant? Tenant { get; set; }
		public virtual TmX_Currency? Currency { get; set; }

	}
}
