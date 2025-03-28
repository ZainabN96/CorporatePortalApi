using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Lookup
    {
        [Key]
        public int Lookup_ID { get; set; }

        public int? Parent_Lookup_ID { get; set; }

        [Required]
        public int Tenant_ID { get; set; }

        [MaxLength(100)]
        public string? Lookup_Type { get; set; }

        
        [MaxLength(500)]
        public string? Description { get; set; }

        public bool? Is_Active { get; set; }

        [MaxLength(100)]
        public string? Hidden_Value { get; set; }

        [MaxLength(999)]
        public string? Visible_Value { get; set; }

        public int? User_Editable  { get; set; }
        public int? Sort_Order { get; set; }

        [MaxLength(100)]
        public string? Lookup_Name { get; set; }


        public bool? Active_Flag { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; } = string.Empty;

		[MaxLength(100)]
        public string? Created_Date { get; set; } // in script the datatype was nvarchar

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }
      
        public string? Locale_Label { get; set; }

        [Required]
        public int Locale_ID { get; set; }




    }
}
