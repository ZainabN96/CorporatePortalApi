using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IAspNetUserRoleService
    {
        Task<AspNetUser> GetWithUserId(int userId);
        Task<AspNetRole> GetWithRoleId(string roleId);
        Task<IEnumerable<AspNetUserRole>> GetAspNetUserRoleAsync();
        AspNetUserRole Add(AspNetUserRole userRole);
        Task<bool> IsAspNetUserRoleExist(string roleId, int userId);
    }
}
