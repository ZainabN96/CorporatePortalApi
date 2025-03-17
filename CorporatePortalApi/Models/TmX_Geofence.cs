using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
	public class TmX_Geofence
	{
		[Key]
		public int Geofence_Id { get; set; }

		[MaxLength(50)]
		public string? Geofence_Code { get; set; }

		[MaxLength(50)]
		public string? Geofence_Name { get; set; }
	}
}
