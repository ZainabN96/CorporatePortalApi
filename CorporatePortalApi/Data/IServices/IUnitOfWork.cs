using CorporatePortalApi.Data.Services;

namespace CorporatePortalApi.Data.IServices
{
    public interface IUnitOfWork
    {
        IAspNetUserService AspNetUsersService { get; }
        ITmX_CorporateService TmX_CorporateService { get; }
        ITmX_BankService TmX_BankService { get; }
        ITmX_CurrencyService TmX_CurrencyService { get; }
        ITmX_LocationService TmX_LocationService { get; }
        ITmX_AddressService TmX_AddressService { get; }
        ITmX_TenantService TmX_TenantService { get; }
        ITmX_LocaleService TmX_LocaleService { get; }
        ITmX_Time_ZoneService TmX_Time_ZoneService { get; }
        IAspNetUserRoleService AspNetUserRolesService { get; }
        ITmX_ProductService TmX_ProductService { get; }
        ITmX_UserService TmX_UserService { get; }
        ITmX_User_To_Corporate_MappingService TmX_User_To_Corporate_MappingService { get; }


        IAspNetRoleService AspNetRoleService { get; }

        ITmX_Address_GeographyService TmX_Address_GeographyService { get; }

        ITmX_LookupService TmX_LookupService { get; }

        Task<bool> SaveAsync();
    }
}
