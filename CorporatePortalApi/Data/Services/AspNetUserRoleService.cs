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

        public async Task<AspNetUser> GetWithUserId(int userId)
        {
			return await dc.AspNetUsers
	              .Include(x => x.Address)
	              .Include(x => x.Tenant)
	              .Include(x => x.Locale)
	              .Include(x => x.TimeZone)
	              .Include(x => x.UserRoles)
		              .ThenInclude(ur => ur.Role)
				  .FirstOrDefaultAsync(x => x.Id == userId);
		} 
        public async Task<AspNetRole> GetWithRoleId(string roleId)
        {
            return await dc.AspNetRole.Where(x => x.Id == roleId)
				                        .Include(x => x.UserRoles)
									   .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AspNetUserRole>> GetAspNetUserRoleAsync()
        {
            return await dc.AspNetUserRoles
                                       .OrderBy(x => x.RoleId)
                                       .Include(x=> x.User)
                                       .Include(x => x.Role)
									   .ToListAsync();
        }

        public async Task<bool> IsAspNetUserRoleExist(string roleId, int userId)
        {
            return await dc.AspNetUserRoles.AnyAsync(x => x.RoleId == roleId && x.UserId == userId);
        }

      
    }
}
