using System.ComponentModel.DataAnnotations;
namespace CorporatePortalApi.Models
{
    public class TmX_Address_Geography
    {
        [Key]
        public int Address_Geography_ID { get; set; }
        public int? Parent_Geography_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Geography_Name { get; set; } = string.Empty;

		[MaxLength(100)]
        public string? Geography_Description { get; set; }

        [MaxLength(50)]
        public string? Geography_Short_Code  { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }
        [Required]
        public DateTime Effective_End_Date { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; } = string.Empty;

		[Required]
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        [Required]
        public int Tenant_ID { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        public int? Geography_Type_Lkp_ID { get; set; }

    }
}
