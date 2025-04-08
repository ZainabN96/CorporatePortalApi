using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CorporatePortalApi.Models
{
	public class TmX_Person_Expense_Detail
	{
		[Key]
		public int Person_Expense_Detail_ID { get; set; }

		public int? Expense_Source_Lkp { get; set; }

		[Required]
		public int Tenant_ID { get; set; }

		public int? Currency_ID { get; set; }

		[MaxLength(100)]
		public string? Created_By { get; set; }

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(100)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		[Column(TypeName = "decimal(17,3)")]
		public decimal? Monthly_Expense_Amount { get; set; }

		public bool? Active_Flag { get; set; }

		public DateTime? Effective_Start_Date { get; set; }

		public DateTime? Effective_End_Date { get; set; }

		[Required]
		public int Person_ID { get; set; }

		public int? Expense_Mode_Lkp { get; set; }

		public Guid? Mobile_ID { get; set; }

		public int? Order_ID { get; set; }

		[Column(TypeName = "decimal(18,0)")]
		public decimal? Total_Monthly_Expenses { get; set; }


		[ForeignKey("Tenant_ID")]
		public virtual TmX_Tenant? Tenant { get; set; }

		[ForeignKey("Currency_ID")]
		public virtual TmX_Currency? Currency { get; set; }

		[ForeignKey("Person_ID")]
		public virtual TmX_Person? Person { get; set; }

		[ForeignKey("Order_ID")]
		public virtual TmX_Order? Order { get; set; }
	}
}
