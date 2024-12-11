using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;

namespace CorporatePortalApi.Models
{
    public class TMX_Address
    {
        [Key] // Primary Key
        public int Address_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        public int? Address_Geography_ID { get; set; }
        public virtual TmX_Address_Geography AddressGeography { get; set; }

        [Required]
        public int Tenant_ID { get; set; }
        public virtual TMX_Tenant Tenant { get; set; }

        public string? UDF_Data { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        [Required]
        public DateTime Effective_End_Date { get; set; }

        [MaxLength(1000)]
        public string? Address_Line_1 { get; set; }

        [MaxLength(100)]
        public string? Address_Line_2 { get; set; }

        [MaxLength(100)]
        public string? Address_Line_3 { get; set; }

        [MaxLength(100)]
        public string? Address_Line_4 { get; set; }

        [MaxLength(50)]
        public string? Postal_Zip_Code { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        public Point? Address_Coordinates { get; set; } // Geography type mapped to NetTopologySuite Point
        
        public int? Address_Type_Lkp_ID { get; set; }
        public virtual TmX_Lookup AddressTypeLookup { get; set; }

        [MaxLength(50)]
        public string? Country { get; set; }

        [MaxLength(50)]
        public string? Province { get; set; }

        public Guid? Mobile_ID { get; set; }
    }
}
