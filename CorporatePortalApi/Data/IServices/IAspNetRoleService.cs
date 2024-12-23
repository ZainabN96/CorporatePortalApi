using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IAspNetRoleService
    {
        Task<AspNetRole> Get(int id);
        AspNetRole Add(AspNetRole AspNetRole);
    }
}
