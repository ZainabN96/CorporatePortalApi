using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITenantService
    {
        Task<TmX_Tenant> Get(int id);
        Task<TmX_Tenant> GetWithName(string name);
        Task<IEnumerable<TmX_Tenant>> GetAllTenantAsync();
        TmX_Tenant Add(TmX_Tenant TmX_Tenant);
        Task<bool> IsTenantExist(string name);
        Task<bool> IsTenantExistInUpdate(string name, int id);
    }
}
