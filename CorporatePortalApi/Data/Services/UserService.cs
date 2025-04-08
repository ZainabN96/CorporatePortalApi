using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class UserService: IUserService
    {
        private readonly ApplicationDbContext dc;

        public UserService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_User Add(TmX_User user)
        {
            user.User_ID = Guid.NewGuid();
            user.Last_Updated_Date = DateTime.Now;
            dc.TmX_User.Add(user);

            return user;
        }

        public async Task<TmX_User> Get(Guid id)
        {
            return await dc.TmX_User.FindAsync(id);
        }
		public async Task<TmX_User?> GetByParentId(Guid id)
		{
			return await dc.TmX_User.FirstOrDefaultAsync(u => u.Parent_User_ID == id);
		}
		public async Task<TmX_User> GetWithName(string firstname, string lastname)
        {
            return await dc.TmX_User.Where(x => x.First_Name == firstname && x.Last_Name == lastname).FirstOrDefaultAsync();
        }
        public async Task<TmX_User> GetWithServer_User_ID(string serverUId)
        {
            return await dc.TmX_User.Where(x => x.Server_User_ID == serverUId)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_User>> GetAllUsersAsync()
        {
            return await dc.TmX_User.Where(x => x.Active_Flag == true)
                                    .OrderBy(x => x.User_ID)
									.Include(x => x.ParentUser)
				                    .Include(x => x.Tenant)
				                    .Include(x => x.Location)
				                    .Include(x => x.Address)
				                    .Include(x => x.TimeZone)
				                    .Include(x => x.UserType)
				                    .Include(x => x.Designation)
									.ToListAsync();
        }

        public async Task<bool> IsUserExist(string firstname, string lastname)
        {
            return await dc.TmX_User.AnyAsync(x => x.First_Name == firstname && x.Last_Name== lastname);
        }

        public async Task<bool> IsUserExistInUpdate(string firstname, string lastname, Guid id)
        {
            return await dc.TmX_User.AnyAsync(x => x.First_Name == firstname && x.Last_Name == lastname && x.User_ID != id);
        }
    }
}
