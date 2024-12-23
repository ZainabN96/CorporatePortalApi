using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
    public class TmX_Address_GeographyDto
    {
        public int Address_Geography_ID { get; set; }
        public int? Parent_Geography_ID { get; set; }

        public string Geography_Name { get; set; }

        public string? Geography_Description { get; set; }

        public string? Geography_Short_Code { get; set; }

        public DateTime Effective_Start_Date { get; set; }

        public DateTime Effective_End_Date { get; set; }

        public string Created_By { get; set; }

        public DateTime Created_Date { get; set; }

        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        public int Tenant_ID { get; set; }

        public bool Active_Flag { get; set; }

        public int? Geography_Type_Lkp_ID { get; set; }


    }
}
