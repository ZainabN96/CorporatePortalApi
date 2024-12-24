using CorporatePortalApi.Data;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

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
            users.LastLoginDate = DateTime.Now;
            dc.AspNetUsers.Add(users);

            return users;
        }

        public async Task<AspNetUser> Get(int id)
        {
            return await dc.AspNetUsers.FindAsync(id);
        }

        public async Task<AspNetUser> GetWithName(string firstname, string lastname)
        {
            return await dc.AspNetUsers.Where(x => x.FirstName == firstname && x.LastName == lastname)
                                       .FirstOrDefaultAsync();
        }
        public async Task<AspNetUser> GetWithTenantID(int tenantID)
        {
            return await dc.AspNetUsers.Where(x => x.Tenant_ID == tenantID)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AspNetUser>> GetAspNetUserAsync()
        {
            return await dc.AspNetUsers.Where(x => x.Status == "Active")
                                       .OrderBy(x => x.Id)
                                       .ToListAsync();
        }

        public async Task<bool> IsAspNetUserExist(int Id)
        {
            return await dc.AspNetUsers.AnyAsync(x => x.Id == Id);
        }
    }
}
