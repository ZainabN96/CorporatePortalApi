using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Currency
    {
        [Key] // Primary Key
        public int Currency_ID { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        [Required]
        public DateTime Effective_End_Date { get; set; }

        [MaxLength(20)]
        public string? Currency_Code { get; set; }

        [Required]
        [MaxLength(20)]
        public string Currency_Symbol { get; set; } = string.Empty;

		[MaxLength(100)]
        public string? Currency_Description { get; set; }

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
