using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_CorporateService
    {
        Task<TmX_Corporate> Get(int id);
        Task<TmX_Corporate> GetWithName(string name);
        Task<IEnumerable<TmX_Corporate>> GetTmX_CorporateAsync();
        TmX_Corporate Add(TmX_Corporate TmX_Corporate);
        Task<bool> IsTmX_CorporateExist(string name);
        Task<bool> IsTmX_CorporateExistInUpdate(string name, int id);
    }
}
