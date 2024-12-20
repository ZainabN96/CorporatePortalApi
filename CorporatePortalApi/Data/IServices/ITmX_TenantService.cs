using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_TenantService
    {
        Task<TmX_Tenant> Get(int id);
        Task<TmX_Tenant> GetWithName(string name);
        Task<IEnumerable<TmX_Tenant>> GetTmX_TenantAsync();
        TmX_Tenant Add(TmX_Tenant TmX_Tenant);
        Task<bool> IsTmX_TenantExist(string name);
        Task<bool> IsTmX_TenantExistInUpdate(string name, int id);
    }
}
