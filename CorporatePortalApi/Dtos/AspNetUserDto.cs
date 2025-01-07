
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
    public class AspNetUserDto
    {
        // AspNetUser Fields
        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [MaxLength(256)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int? Address_ID { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public DateTime PasswordExpiryDate { get; set; }
        public bool FirstPasswordChange { get; set; } = false;
        public string SecurityStamp { get; set; }

        // TmX_Address Fields
        [MaxLength(1000)]
        public string? AddressLine1 { get; set; }
        [MaxLength(100)]
        public string? AddressLine2 { get; set; }

        [MaxLength(100)]
        public string? AddressLine3 { get; set; }

        [MaxLength(100)]
        public string? AddressLine4 { get; set; }


        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(50)]
        public string? Country { get; set; }

        [MaxLength(50)]
        public string? PostalZipCode { get; set; }

        [Required]
        public DateTime EffectiveStartDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime EffectiveEndDate { get; set; } = DateTime.UtcNow.AddYears(1);

        [Required]
        public bool ActiveFlag { get; set; } = true;
        public string Created_By { get; set; }
        public int TenantId { get; set; }
        public int Tenant_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Tenant_Name { get; set; }

        public DateTime? Tenant_Registration_Date { get; set; }

        public DateTime? Tenant_Activation_Date { get; set; }

        public bool? Tenant_Blocked_Flag { get; set; }

        [Required]
        public DateTime Effective_Start_Date { get; set; }

        [Required]
        public DateTime Effective_End_Date { get; set; }

        [Required]
        public DateTime? Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }
        public string Language { get; set; }

        [Required]
        [MaxLength(4)]
        public string Locale_LCID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country_Region { get; set; }
        public string? Time_Zone_Code { get; set; }

        [MaxLength(100)]
        public string? Time_Zone_Name { get; set; }

        [MaxLength(100)]
        public string? Time_Zone_Description { get; set; }

    }
}
