using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IAspNetUserRoleService
    {
        Task<AspNetUserRole> Get(int id);
        Task<AspNetUserRole> GetWithUserId(string userId);
        Task<AspNetUserRole> GetWithRoleId(string roleId);
        Task<IEnumerable<AspNetUserRole>> GetAspNetUserRoleAsync();
        AspNetUserRole Add(AspNetUserRole userRole);
        Task<bool> IsAspNetUserRoleExist(string roleId);
    }
}
