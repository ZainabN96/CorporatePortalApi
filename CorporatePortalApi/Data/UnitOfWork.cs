using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Data.Services;
using CorporatePortalApi.Data;

namespace CorporatePortalApi
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dc;

        public UnitOfWork(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public IAspNetUserService AspNetUsersService => new AspNetUserService(dc);
        public ITmX_CorporateService TmX_CorporateService => new TmX_CorporateService(dc);
        public ITmX_BankService TmX_BankService => new TmX_BankService(dc);
        public ITmX_CurrencyService TmX_CurrencyService => new TmX_CurrencyService(dc);
        public ITmX_LocationService TmX_LocationService => new TmX_LocationService(dc);
        public ITmX_AddressService TmX_AddressService => new TmX_AddressService(dc);
        public ITmX_TenantService TmX_TenantService => new TmX_TenantService(dc);
        public ITmX_LocaleService TmX_LocaleService => new TmX_LocaleService(dc);
        public ITmX_Time_ZoneService TmX_Time_ZoneService => new TmX_Time_ZoneService(dc);
        public IAspNetUserRoleService AspNetUserRolesService => new AspNetUserRoleService(dc);
        public IProductService ProductService => new ProductService(dc);
        public ITmX_UserService TmX_UserService => new TmX_UserService(dc);
        public ITmX_User_To_Corporate_MappingService TmX_User_To_Corporate_MappingService => new TmX_User_To_Corporate_MappingService(dc);

        public IAspNetRoleService AspNetRoleService => new AspNetRoleService(dc);   

      public ITmX_Address_GeographyService TmX_Address_GeographyService => new TmX_Address_GeographyService(dc);    

        public ITmX_LookupService TmX_LookupService => new TmX_LookupService(dc);

        public async Task<bool> SaveAsync()
        {
            try
            {
                return await dc.SaveChangesAsync() > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
