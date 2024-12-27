using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IAspNetRoleService
    {
        Task<AspNetRole> Get(string id);
        AspNetRole Add(AspNetRole AspNetRole);
        Task<AspNetRole> GetWithName(string name);
        Task<IEnumerable<AspNetRole>> GetAllRoleAsync();
        Task<bool> IsRoleExist(string name);
        Task<bool> IsRoleExistInUpdate(string name, string id);

	}
}
