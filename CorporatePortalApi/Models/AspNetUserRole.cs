using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class AspNetUserRole
    {
        [Key, Column(Order = 0)]
        [Required]
        [MaxLength(128)]
        public int UserId { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        [MaxLength(128)]
        public string RoleId { get; set; }

        // Navigation Properties
        [ForeignKey("RoleId")]
        public virtual AspNetRole Role { get; set; }

        [ForeignKey("UserId")]
        public virtual AspNetUser User { get; set; }
    }
}
