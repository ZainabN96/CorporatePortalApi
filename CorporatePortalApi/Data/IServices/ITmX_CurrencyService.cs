using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_CurrencyService
    {
        Task<TmX_Currency> Get(int id);
        TmX_Currency Add(TmX_Currency TmX_Currency);
    }
}
