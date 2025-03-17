using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Institute
	{
		[Key]
		public int Institute_ID { get; set; }

		[MaxLength(100)]
		public string? Institute_Name { get; set; }

		[MaxLength(50)]
		public string? Institute_Code { get; set; }
	}
}
