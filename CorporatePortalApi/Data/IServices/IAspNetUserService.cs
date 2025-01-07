using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IAspNetUserService
    {
        AspNetUser Add(AspNetUser users);
        void AddUser(AspNetUser user, TmX_Address address, TmX_Tenant tenant, TmX_Locale locale, TmX_Time_Zone time);
        Task<AspNetUser> Get(int id);
        Task<AspNetUser> GetWithName(string firstname, string lastname);
        Task<AspNetUser> GetWithTenantID(int tenantID);
        Task<IEnumerable<AspNetUser>> GetAspNetUserAsync();
        Task<bool> IsUserExist(string Email);
    }
}
