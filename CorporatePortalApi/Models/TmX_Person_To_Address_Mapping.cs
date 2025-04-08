using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Person_To_Address_Mapping
	{
		[Key]
		public int Person_To_Address_Map_ID { get; set; }

		[Required]
		public int Address_Id { get; set; }

		[Required]
		public int Person_Id { get; set; }

		[Required]
		[MaxLength(50)]
		public string Created_By { get; set; } = string.Empty;

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(50)]
		public string? Last_Updated_By { get; set; }

		public DateTime? Last_Updated_Date { get; set; }

		[ForeignKey("Address_Id")]
		public virtual required TmX_Address Address { get; set; }

		[ForeignKey("Person_Id")]
		public virtual required TmX_Person Person { get; set; }
	}
}
