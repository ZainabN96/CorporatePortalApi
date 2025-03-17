using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Transaction
	{
		[Key]
		public int Transaction_Id { get; set; }
		public int Transaction_code { get; set; }
		public string Transaction_type { get; set; }
		public int Amount { get; set; }

		[MaxLength(50)]
		public string? Transaction_desc { get; set; }
	}
}
