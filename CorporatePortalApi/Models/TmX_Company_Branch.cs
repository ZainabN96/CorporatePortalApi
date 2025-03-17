using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Company_Branch
	{
		[Key]
		public int Customer_Branch_Id { get; set; }

		[MaxLength(50)]
		public string? Branch_Code { get; set; }

		[MaxLength(50)]
		public string? Branch_Title { get; set; }

		[MaxLength(100)]
		public string? Branch_Name { get; set; }

		public int? Branch_Type_Lkp { get; set; }

	}
}
