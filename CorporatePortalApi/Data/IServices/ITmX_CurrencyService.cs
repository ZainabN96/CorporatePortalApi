using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_CurrencyService
    {
        Task<TmX_Currency> Get(int id);
        TmX_Currency Add(TmX_Currency TmX_Currency);
        Task<TmX_Currency> GetWithCurrency_Symbol(string currency);
        Task<IEnumerable<TmX_Currency>> GetTmX_CurrencyAsync();
        Task<bool> IsTmX_CurrencyExist(string currency);
        Task<bool> IsTmX_CurrencyExistInUpdate(string currencyS, int id);

	}
}
