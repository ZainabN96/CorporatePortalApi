using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_LocaleService
    {
        Task<TmX_Locale> Get(int id);
        Task<IEnumerable<TmX_Locale>> GetTmX_LocaleAsync();
        TmX_Locale Add(TmX_Locale TmX_Locale);
    }
}
