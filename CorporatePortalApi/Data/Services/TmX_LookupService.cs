using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

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
    }
}
