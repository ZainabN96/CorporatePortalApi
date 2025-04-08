using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_LocationService: ITmX_LocationService
    {
        private readonly ApplicationDbContext dc;

        public TmX_LocationService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Location Add(TmX_Location TmX_Location)
        {
            dc.TmX_Location.Add(TmX_Location);

            return TmX_Location;
        }

        public async Task<TmX_Location> Get(int id)
        {
            return await dc.TmX_Location.FindAsync(id);
        }
		public async Task<IEnumerable<TmX_Location>> GetAll()
		{
			return await dc.TmX_Location.Where(x => x.Active_Flag == true)
									   .OrderBy(x => x.Location_Code)
									   .Include(x => x.Parent_Location)
									   .Include(x => x.Tenant)
									   .Include(x => x.Location_Lookup)
									   .ToListAsync();
		}
	}
}
