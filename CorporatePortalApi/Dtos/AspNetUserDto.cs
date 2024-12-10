
namespace CorporatePortalApi.Dtos
{
    public class AspNetUserDto
    {
        public int? Id { get; set; }
        public string? Hometown { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string? PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }

        public int? Address_ID { get; set; }

        public int? Locale_ID { get; set; }

        public int? Time_Zone_ID { get; set; }

        public int? Tenant_ID { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime PasswordExpiryDate { get; set; }

        public string? Status { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public bool FirstPasswordChange { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? ImageURL { get; set; }

        public bool IsTwoFAEnabled { get; set; }

        public string? TwoFASecretKey { get; set; }

    }
}
