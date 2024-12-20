namespace CorporatePortalApi.Data.IServices
{
    public interface IUnitOfWork
    {
        IAspNetUserService AspNetUserService { get; }
        ITmX_CorporateService TmX_CorporateService { get; }
        ITmX_BankService TmX_BankService { get; }
        ITmX_CurrencyService TmX_CurrencyService { get; }
        ITmX_LocationService TmX_LocationService { get; }
        ITmX_AddressService TmX_AddressService { get; }
        ITmX_TenantService TmX_TenantService { get; }
        ITmX_LocaleService TmX_LocaleService { get; }
        ITmX_Time_ZoneService TmX_Time_ZoneService { get; }

        Task<bool> SaveAsync();
    }
}
