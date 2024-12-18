namespace CorporatePortalApi.Data.IServices
{
    public interface IUnitOfWork
    {
        IAspNetUserService AspNetUserService { get; }
        ITmX_CorporateService TmX_CorporateService { get; }
        ITmX_BankService TmX_BankService { get; }
        ITmX_CurrencyService TmX_CurrencyService { get; }
        ITmX_LocationService TmX_LocationService { get; }

        Task<bool> SaveAsync();
    }
}
