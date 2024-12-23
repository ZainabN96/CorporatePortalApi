using CorporatePortalApi.Models;
using CorporatePortalApi.Data.IServices;

namespace CorporatePortalApi.Data.Services
{
    public class AspNetRoleService : IAspNetRoleService 
    {
        private readonly ApplicationDbContext dc;

        public AspNetRoleService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public AspNetRole Add(AspNetRole AspNetRole)
        {
            dc.AspNetRole.Add(AspNetRole);

            return AspNetRole;

            
        }

        public async Task<AspNetRole> Get(int id)
        {
            return await dc.AspNetRole.FindAsync(id);
        }
    }
}
