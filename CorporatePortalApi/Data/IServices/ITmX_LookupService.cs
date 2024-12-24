using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_LookupService
    {
         
        Task<TmX_Lookup> Get(int id);
        Task<IEnumerable<TmX_Lookup>> GetAllLookupAsync();
        TmX_Lookup Add(TmX_Lookup TmX_Lookup);
        //Task<TmX_Lookup> GetWithLookupName(string lookupname);
        //Task<IEnumerable<TmX_Lookup>> GetTmX_LookupAsync();
        Task<bool> IsTmX_LookupExist(string lookupName);
        Task<bool> IsTmX_LookupExistInUpdate(string lookupName, int id);

    }

}
