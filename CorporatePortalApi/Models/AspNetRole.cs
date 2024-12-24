using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class AspNetRole
    {
        [Key]
        [MaxLength(128)]
        public string Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        [Required]
        public  DateTime Effective_End_Date { get; set; }
        public virtual ICollection<AspNetUserRole> UserRoles { get; set; }
    }
}
