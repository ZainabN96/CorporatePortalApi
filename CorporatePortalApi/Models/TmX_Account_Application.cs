using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Account_Application
	{
		[Key]
		public int Account_Application_ID { get; set; }

		[MaxLength(100)]
		public string? Account_Number { get; set; }
		public string? Balance { get; set; }
		public DateTime Account_Application_Date { get; set; }

	}
}
