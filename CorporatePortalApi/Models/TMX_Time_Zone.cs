using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TMX_Time_Zone
    {
        [Key] // Primary Key
        public int Time_Zone_ID { get; set; }

        [MaxLength(50)]
        public string? Time_Zone_Code { get; set; }

        [MaxLength(100)]
        public string? Time_Zone_Name { get; set; }

        [MaxLength(100)]
        public string? Time_Zone_Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        [Required]
        public bool Active_Flag { get; set; }
    }
}
