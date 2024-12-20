using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Locale
    {
        [Key]
        public int Locale_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Language { get; set; }

        [Required]
        [MaxLength(4)]
        public string Locale_LCID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country_Region { get; set; }
    }
}
