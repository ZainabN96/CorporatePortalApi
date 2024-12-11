using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Corporate
    {
        [Key]
        public int Corporate_Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Corporate_Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Corporate_Code { get; set; }

        public string Corporate_Description { get; set; }

        [MaxLength(50)]
        public string Corporate_NTN_Number { get; set; }

        [MaxLength(100)]
        public string Corporate_Bank_Account { get; set; }

        [MaxLength(100)]
        public string Corporate_Image { get; set; }

        [MaxLength(100)]
        public string Corporate_Email_Address { get; set; }

        public string Corporate_Address { get; set; }

        [MaxLength(255)]
        public string Corporate_URL { get; set; }

        public int? Default_Product_Id { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        // Navigation Properties
        [ForeignKey("Default_Product_Id")]
        public virtual TmX_Product Default_Product { get; set; }

    }
}
