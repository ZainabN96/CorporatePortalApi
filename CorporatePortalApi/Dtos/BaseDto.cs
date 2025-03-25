namespace CorporatePortalApi.Dtos
{
	public class BaseDto
	{
		public DateTime Created_Date { get; set; } = DateTime.UtcNow;
		public DateTime? Last_Updated_Date { get; set; }
	}
}
