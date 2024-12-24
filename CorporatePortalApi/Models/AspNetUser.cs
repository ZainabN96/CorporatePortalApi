using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class AspNetUser
    {
        [Key]
        public int Id { get; set; }
        public string? Hometown { get; set; }

        [MaxLength(256)]
        [Required]
        public string Email { get; set; }

        [Required]
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [Required]
        [MaxLength(256)]
        public string UserName { get; set; }

        public int? Address_ID { get; set; }
        public virtual TmX_Address Address { get; set; }

        public int? Locale_ID { get; set; }
        public virtual TmX_Locale Locale { get; set; }

        public int? Time_Zone_ID { get; set; }
        public virtual TmX_Time_Zone TimeZone { get; set; }

        public int? Tenant_ID { get; set; }
        public virtual TmX_Tenant Tenant { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public DateTime PasswordExpiryDate { get; set; }

        public string? Status { get; set; }

        public DateTime? LastLoginDate { get; set; }

        [Required]
        public bool FirstPasswordChange { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Url]
        public string? ImageURL { get; set; }

        public bool IsTwoFAEnabled { get; set; }

        public string? TwoFASecretKey { get; set; }
        public virtual ICollection<AspNetUserRole> UserRoles { get; set; }
    }

}
