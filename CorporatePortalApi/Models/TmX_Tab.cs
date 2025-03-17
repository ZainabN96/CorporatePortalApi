using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Tab
	{
		[Key]
		public int Tab_Id { get; set; }

		[MaxLength(50)]
		public string? Tab_Code { get; set; }

		[MaxLength(50)]
		public string? Tab_Name { get; set; }
	}
}
