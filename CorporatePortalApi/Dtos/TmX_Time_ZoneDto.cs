namespace CorporatePortalApi.Dtos
{
    public class TmX_Time_ZoneDto: BaseDto
	{
        public int Time_Zone_ID { get; set; }
        public string? Time_Zone_Code { get; set; }
        public string? Time_Zone_Name { get; set; }
        public string? Time_Zone_Description { get; set; }
        public string Created_By { get; set; }
        public string? Last_Updated_By { get; set; }
        public bool Active_Flag { get; set; }
    }
}
