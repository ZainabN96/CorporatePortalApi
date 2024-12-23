using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IAspNetUserService
    {
        AspNetUser Add(AspNetUser users);
        Task<AspNetUser> Get(int id);
        Task<AspNetUser> GetWithName(string firstname, string lastname);
        Task<AspNetUser> GetWithTenantID(int tenantID);
        Task<IEnumerable<AspNetUser>> GetAspNetUserAsync();
        Task<bool> IsAspNetUserExist(int Id);
    }
}
