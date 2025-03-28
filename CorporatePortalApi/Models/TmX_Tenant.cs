using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Tenant
    {
        [Key] 
        public int Tenant_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Tenant_Name { get; set; } = string.Empty;

		public DateTime? Tenant_Registration_Date { get; set; }

        public DateTime? Tenant_Activation_Date { get; set; }

        public bool? Tenant_Blocked_Flag { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

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

    }
}
