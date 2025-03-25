using CorporatePortalApi.Models;

namespace CorporatePortalApi.Dtos
{
    public class TmX_LocationDto: BaseDto
	{
        public int Location_ID { get; set; }
        public int? Parent_Location_ID { get; set; }
        public int Tenant_ID { get; set; }
        public string Location_Code { get; set; }
        public string? Location_Name { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public string Created_By { get; set; }
        public string? Last_Updated_By { get; set; }
        public int Location_Type_Lkp_ID { get; set; }
    }
}
