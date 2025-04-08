using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Person_Address_Contact
	{
		[Required]
		public int Tenant_ID { get; set; }

		[Key]
		public int Person_Address_Contact_ID { get; set; }

		[Required]
		[MaxLength(50)]
		public string Created_By { get; set; } = string.Empty;

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(50)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		[Required]
		public int Contact_Type_Lkp { get; set; }

		[Required]
		public bool Active_Flag { get; set; }

		[Required]
		public DateTime Effective_Start_Date { get; set; }

		[Required]
		public DateTime Effective_End_Date { get; set; }

		[MaxLength(100)]
		public string? Contact_Number { get; set; }

		[MaxLength(100)]
		public string? Contact_Extension { get; set; }

		[Required]
		public bool Primary_Contact_Flag { get; set; }

		[MaxLength(100)]
		public string? Contact_Email_Address { get; set; }

		[Required]
		public int Person_To_Address_Map_ID { get; set; }

		public Guid? Mobile_ID { get; set; }

		[ForeignKey("Tenant_ID")]
		public virtual TmX_Tenant? Tenant { get; set; }

		[ForeignKey("Person_To_Address_Map_ID")]
		public virtual TmX_Person_To_Address_Mapping? PersonToAddressMapping { get; set; }
	}
}
