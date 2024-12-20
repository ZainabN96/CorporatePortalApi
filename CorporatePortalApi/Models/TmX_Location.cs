using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporatePortalApi.Models
{
    public class TmX_Location
    {
        [Key] // Primary Key
        public int Location_ID { get; set; }

        public int? Parent_Location_ID { get; set; }

        [ForeignKey("Parent_Location_ID")]
        public virtual TmX_Location Parent_Location { get; set; }

        [Required]
        public int Tenant_ID { get; set; }

        [ForeignKey("Tenant_ID")]
        public virtual TmX_Tenant Tenant { get; set; }

        [Required]
        [MaxLength(50)]
        public string Location_Code { get; set; }

        [MaxLength(200)]
        public string? Location_Name { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        [Required]
        public DateTime Effective_End_Date { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        [Required]
        public int Location_Type_Lkp_ID { get; set; }

        [ForeignKey("Location_Type_Lkp_ID")]
        public virtual TmX_Lookup Location_Lookup { get; set; }
    }
}
