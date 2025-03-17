using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Order
	{
		[Key]
		public int Order_ID { get; set; }

		[Required]
		public int Tenant_ID { get; set; }

		[Required]
		[MaxLength(100)]
		public string Created_By { get; set; }

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(100)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		public DateTime? Order_Date { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Order_Gross_Amount { get; set; }

		[Required]
		public int Customer_Master_ID { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Discount_Amount { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Order_Net_Amount { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Tax_Amount { get; set; }

		[MaxLength(50)]
		public string? Order_Number { get; set; }

		[MaxLength(100)]
		public string? Financing_Status_Lkp { get; set; }

		public string? UDF_Data { get; set; }

		[MaxLength(50)]
		public string? Dlp_Order_Number { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal Financing_Amount { get; set; } = 0;

		public DateTime? Accepted_Date { get; set; }
		public DateTime? Cancelled_Date { get; set; }
		public DateTime? Rejected_Date { get; set; }
		public DateTime? Goods_Issuance_Date { get; set; }
		public DateTime? Delivered_Date { get; set; }

		[MaxLength(100)]
		public string? Delivered_By { get; set; }

		public int? Institute_Id { get; set; }
		public int? Product_Id { get; set; }
		public bool? Is_Ecib_Evaluation_Successful { get; set; }
		public bool Execute_Parser_Scorecard_Flag { get; set; } = false;
		public string? Executed_Rules_Json { get; set; }
		public DateTime? Expected_Degree_Completion_Date { get; set; }
		public bool? Student_Bill_Paid { get; set; } = false;
		public int? Corporate_Id { get; set; }

		[ForeignKey("Tenant_ID")]
		public virtual TmX_Tenant Tenant { get; set; }

		[ForeignKey("Customer_Master_ID")]
		public virtual TmX_Customer_Master CustomerMaster { get; set; }

		[ForeignKey("Institute_Id")]
		public virtual TmX_Institute Institute { get; set; }

		[ForeignKey("Product_Id")]
		public virtual TmX_Product Product { get; set; }

		[ForeignKey("Corporate_Id")]
		public virtual TmX_Corporate Corporate { get; set; }
	}
}
