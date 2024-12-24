using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

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
            //userRole.Last_Updated_Date = DateTime.Now;
            dc.AspNetUserRoles.Add(userRole);

            return userRole;
        }

        public async Task<AspNetUserRole> Get(int id)
        {
            return await dc.AspNetUserRoles.FindAsync(id);
        }

        public async Task<AspNetUserRole> GetWithUserId(string userId)
        {
            return await dc.AspNetUserRoles.Where(x => x.UserId == userId)
                                       .FirstOrDefaultAsync();
        } 
        public async Task<AspNetUserRole> GetWithRoleId(string roleId)
        {
            return await dc.AspNetUserRoles.Where(x => x.RoleId == roleId)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AspNetUserRole>> GetAspNetUserRoleAsync()
        {
            return await dc.AspNetUserRoles
                                       .OrderBy(x => x.RoleId)
                                       .ToListAsync();
        }

        public async Task<bool> IsAspNetUserRoleExist(string roleId)
        {
            return await dc.AspNetUserRoles.AnyAsync(x => x.RoleId == roleId);
        }

      
    }
}
