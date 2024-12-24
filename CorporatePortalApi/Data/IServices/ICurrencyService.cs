using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ICurrencyService
    {
        Task<TmX_Currency> Get(int id);
        TmX_Currency Add(TmX_Currency TmX_Currency);
        Task<TmX_Currency> GetWithCurrency_Symbol(string currency);
        Task<IEnumerable<TmX_Currency>> GetAllCurrencyAsync();
        Task<bool> IsCurrencyExist(string currency);
        Task<bool> IsCurrencyExistInUpdate(string currencyS, int id);

	}
}
