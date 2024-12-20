using CorporatePortalApi.Models;
using CorporatePortalApi.Data.IServices;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_Time_ZoneService: ITmX_Time_ZoneService
    {
        private readonly ApplicationDbContext dc;

        public TmX_Time_ZoneService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Time_Zone Add(TmX_Time_Zone Time_Zone)
        {
            Time_Zone.Last_Updated_Date = DateTime.Now;
            dc.TmX_Time_Zone.Add(Time_Zone);

            return Time_Zone;
        }

        public async Task<TmX_Time_Zone> Get(int id)
        {
            return await dc.TmX_Time_Zone.FindAsync(id);
        }

        public async Task<TmX_Time_Zone> GetWithName(string name)
        {
            return await dc.TmX_Time_Zone.Where(x => x.Time_Zone_Name == name)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_Time_Zone>> GetTmX_Time_ZoneAsync()
        {
            return await dc.TmX_Time_Zone.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Time_Zone_Name)
                                       .ToListAsync();
        }

        public async Task<bool> IsTmX_Time_ZoneExist(string name)
        {
            return await dc.TmX_Time_Zone.AnyAsync(x => x.Time_Zone_Name == name);
        }

        public async Task<bool> IsTmX_Time_ZoneExistInUpdate(string name, int id)
        {
            return await dc.TmX_Time_Zone.AnyAsync(x => x.Time_Zone_Name == name && x.Time_Zone_ID != id);
        }
    }
}
