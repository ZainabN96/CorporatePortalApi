using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Location
    {
        [Key] // Primary Key
        public int Location_ID { get; set; }
        public int? Parent_Location_ID { get; set; }
        public virtual TmX_Location Parent_Location{ get; set; }
        public int Tenant_ID { get; set; }
        public virtual TMX_Tenant Tenant { get; set; }

        [MaxLength(50)]
        public string Location_Code { get; set; }

        [MaxLength(200)]
        public string? Location_Name { get; set; }

        public bool Active_Flag { get; set; }

        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }

        [MaxLength(100)]
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }
        public int Location_Type_Lkp_ID { get; set; }

        public virtual TmX_Lookup Location_Lookup { get; set; }
    }
}
