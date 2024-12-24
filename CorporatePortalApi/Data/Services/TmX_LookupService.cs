using CorporatePortalApi.Models;
using CorporatePortalApi.Data.IServices;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_LookupService : ITmX_LookupService
    {
        private readonly ApplicationDbContext dc;

        public TmX_LookupService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }


        public TmX_Lookup Add(TmX_Lookup TmX_Lookup)
        {
            dc.TmX_Lookup.Add(TmX_Lookup);

            return TmX_Lookup;
        }

        public async Task<TmX_Lookup> Get(int id)
        {
            return await dc.TmX_Lookup.FindAsync(id);   

        }

       public async Task<IEnumerable<TmX_Lookup>> GetAllLookupAsync()

        {
                return await dc.TmX_Lookup.Where(x => x.Is_Active == true)
                                           .OrderBy(x => x.Lookup_Name)
                                           .ToListAsync();
        }

        public async Task<bool> IsTmX_LookupExist(string lookupName)
        {
            return await dc.TmX_Lookup.AnyAsync(x => x.Lookup_Name == lookupName);
        }

        public async Task<bool> IsTmX_LookupExistInUpdate(string lookupName, int id)
        {
            return await dc.TmX_Lookup.AnyAsync(x => x.Lookup_Name == lookupName && x.Lookup_ID != id);

        }
    }
}
