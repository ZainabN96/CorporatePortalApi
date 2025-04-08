using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CorporatePortalApi.Models
{
	public class TmX_Person_National_Identifier
	{
		[Required]
		public int Tenant_ID { get; set; }

		[Key]
		public int Person_National_Identifier_ID { get; set; }

		[Required]
		public int National_ID_Type_Lkp { get; set; }

		[MaxLength(100)]
		public string? National_Identifier_Value { get; set; }

		public DateTime? National_ID_Issue_Date { get; set; }

		public DateTime? National_ID_Expiry_Date { get; set; }

		[Required]
		[MaxLength(100)]
		public string Created_By { get; set; }

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(100)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		[Required]
		public int Person_ID { get; set; }

		[Required]
		public bool Active_Flag { get; set; }

		[Required]
		public DateTime Effective_Start_Date { get; set; }

		[Required]
		public DateTime Effective_End_Date { get; set; }

		public int? Document_Type { get; set; }

		public Guid? Mobile_ID { get; set; }

		[MaxLength(100)]
		public string? Place_Of_Issue { get; set; }

		public int? Nationality_Lkp { get; set; }

		public int? Order_ID { get; set; }


		[ForeignKey("Order_ID")]
		public virtual TmX_Order? Order { get; set; }

		[ForeignKey("Tenant_ID")]
		public virtual TmX_Tenant? Tenant { get; set; }

		[ForeignKey("Person_ID")]
		public virtual TmX_Person? Person { get; set; }
	}
}
