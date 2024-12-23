using CorporatePortalApi.Data;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class AspNetUserService : IAspNetUserService
    {
        private ApplicationDbContext dc;

        public AspNetUserService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public AspNetUser Add(AspNetUser users)
        {
            users.Last_Updated_Date = DateTime.Now;
            dc.AspNetUser.Add(users);

            return users;
        }

        public async Task<AspNetUser> Get(int id)
        {
            return await dc.AspNetUser.FindAsync(id);
        }

        public async Task<AspNetUser> GetWithName(string firstname, string lastname)
        {
            return await dc.AspNetUser.Where(x => x.FirstName == firstname && x.LastName == lastname)
                                       .FirstOrDefaultAsync();
        }
        public async Task<AspNetUser> GetWithTenantID(int tenantID)
        {
            return await dc.AspNetUser.Where(x => x.Tenant_ID == tenantID)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AspNetUser>> GetAspNetUserAsync()
        {
            return await dc.AspNetUser.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Id)
                                       .ToListAsync();
        }

        public async Task<bool> IsAspNetUserExist(int Id)
        {
            return await dc.AspNetUser.AnyAsync(x => x.Id == Id);
        }
    }
}
