using CorporatePortalApi.Models;
using NetTopologySuite.Geometries;


namespace CorporatePortalApi.Dtos
{
    public class TmX_AddressDto: BaseDto
	{
        public int Address_ID { get; set; }
        public string Created_By { get; set; }
        public string? Last_Updated_By { get; set; }
        public int? Address_Geography_ID { get; set; }
        public int Tenant_ID { get; set; }
        public string? UDF_Data { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public string? Address_Line_1 { get; set; }
        public string? Address_Line_2 { get; set; }
        public string? Address_Line_3 { get; set; }
        public string? Address_Line_4 { get; set; }
        public string? Postal_Zip_Code { get; set; }
        public string? City { get; set; }
        public Point? Address_Coordinates { get; set; } 
        public int? Address_Type_Lkp_ID { get; set; }
        public string? Country { get; set; }
        public string? Province { get; set; }
        public Guid? Mobile_ID { get; set; }
    }
}
