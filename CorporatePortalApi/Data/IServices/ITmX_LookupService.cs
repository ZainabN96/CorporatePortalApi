using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_LookupService
    {
         
        Task<TmX_Lookup> Get(int id);
        TmX_Lookup Add(TmX_Lookup TmX_Lookup);
    }

}
