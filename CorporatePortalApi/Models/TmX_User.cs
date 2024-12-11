using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_User
    {
        [Key]
        [MaxLength(50)]
        public string User_ID { get; set; }

        [MaxLength(50)]
        public string Parent_User_ID { get; set; }

        [Required]
        public int Tenant_ID { get; set; }

        public int? Location_ID { get; set; }
        public int? Address_ID { get; set; }
        public int? Time_Zone_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string User_Name { get; set; }

        [MaxLength(100)]
        public string First_Name { get; set; }

        [MaxLength(100)]
        public string Email_Address { get; set; }

        [MaxLength(100)]
        public string Middle_Name { get; set; }

        [MaxLength(100)]
        public string Last_Name { get; set; }

        [MaxLength(20)]
        public string Contact_Number { get; set; }

        [MaxLength(255)]
        public string User_Image_URL { get; set; }

        [MaxLength(100)]
        public string Primary_National_Identifier_Value { get; set; }

        public bool? Mobile_User_Flag { get; set; }

        [Required]
        public bool Active_Flag { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        [Required]
        public DateTime Effective_End_Date { get; set; }

        [Required]
        [MaxLength(100)]
        public string Created_By { get; set; }

        [Required]
        public DateTime Created_Date { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        [MaxLength(100)]
        public string Last_Updated_By { get; set; }

        public int? Primary_National_ID_Type_Lkp_ID { get; set; }
        public int? User_Type_Lkp_ID { get; set; }
        public int? Designation_Lkp_ID { get; set; }

        [MaxLength(50)]
        public string Server_User_ID { get; set; }

        [MaxLength(50)]
        public string Server_Branch_ID { get; set; }

        // Navigation Properties
        [ForeignKey("Parent_User_ID")]
        public virtual TmX_User ParentUser { get; set; }

        [ForeignKey("Tenant_ID")]
        public virtual TMX_Tenant Tenant { get; set; }

        [ForeignKey("Location_ID")]
        public virtual TmX_Location Location { get; set; }

        [ForeignKey("Address_ID")]
        public virtual TMX_Address Address { get; set; }

        [ForeignKey("Time_Zone_ID")]
        public virtual TMX_Time_Zone TimeZone { get; set; }

        [ForeignKey("User_Type_Lkp_ID")]
        public virtual TmX_Lookup UserType { get; set; }

        [ForeignKey("Designation_Lkp_ID")]
        public virtual TmX_Lookup Designation { get; set; }
    }
}
