using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_User_To_Corporate_Mapping
    {
        [Key]
        public int User_To_Corporate_Mapping_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public Guid User_Id { get; set; }

        [Required]
        public int Corporate_Id { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        public DateTime? Effective_End_Date { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; } = string.Empty;

		[Required]
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        // Navigation Properties
        [ForeignKey("User_Id")]
        public virtual required TmX_User User { get; set; }

        [ForeignKey("Corporate_Id")]
        public virtual required TmX_Corporate Corporate { get; set; }
    }
}
