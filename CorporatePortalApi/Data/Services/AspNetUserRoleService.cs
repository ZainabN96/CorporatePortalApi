using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class AspNetUserRoleService: IAspNetUserRoleService
    {
        private readonly ApplicationDbContext dc;

        public AspNetUserRoleService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public AspNetUserRole Add(AspNetUserRole userRole)
        {
            userRole.Last_Updated_Date = DateTime.Now;
            dc.AspNetUserRole.Add(userRole);

            return userRole;
        }

        public async Task<AspNetUserRole> Get(int id)
        {
            return await dc.AspNetUserRole.FindAsync(id);
        }

        public async Task<AspNetUserRole> GetWithUserId(string userId)
        {
            return await dc.AspNetUserRole.Where(x => x.UserId == userId)
                                       .FirstOrDefaultAsync();
        } 
        public async Task<AspNetUserRole> GetWithRoleId(string roleId)
        {
            return await dc.AspNetUserRole.Where(x => x.RoleId == roleId)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AspNetUserRole>> GetAspNetUserRoleAsync()
        {
            return await dc.AspNetUserRole.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.RoleId)
                                       .ToListAsync();
        }

        public async Task<bool> IsAspNetUserRoleExist(string roleId)
        {
            return await dc.AspNetUserRole.AnyAsync(x => x.RoleId == roleId);
        }

      
    }
}
