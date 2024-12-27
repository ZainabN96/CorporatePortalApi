using CorporatePortalApi.Models;
using CorporatePortalApi.Data.IServices;
using Microsoft.EntityFrameworkCore;

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
        public async Task<AspNetRole> Get(string id)
        {
            return await dc.AspNetRole.FindAsync(id);
        }
		public async Task<AspNetRole> GetWithName(string name)
		{
			return await dc.AspNetRole.Where(x => x.Name == name)
									   .FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<AspNetRole>> GetAllRoleAsync()
		{
			return await dc.AspNetRole.OrderBy(x => x.Name)
									   .ToListAsync();
		}

		public async Task<bool> IsRoleExist(string name)
		{
			return await dc.AspNetRole.AnyAsync(x => x.Name == name);
		}

		public async Task<bool> IsRoleExistInUpdate(string name, string id)
		{
			return await dc.AspNetRole.AnyAsync(x => x.Name == name && x.Id != id);
		}
	}
}
