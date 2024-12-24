using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ICorporateService
    {
        Task<TmX_Corporate> Get(int id);
        Task<TmX_Corporate> GetWithName(string name);
        Task<IEnumerable<TmX_Corporate>> GetOrganizationAsync();
        TmX_Corporate Add(TmX_Corporate TmX_Corporate);
        Task<bool> IsCorporateExist(string name);
        Task<bool> IsCorporateExistInUpdate(string name, int id);
    }
}
