using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Product_Checklist
	{
		[Key]
		public int Product_Checklist_Id { get; set; }

		[MaxLength(500)]
		public string? Attachment_Url { get; set; }
		public bool Active_Flag { get; set; }
	}
}
