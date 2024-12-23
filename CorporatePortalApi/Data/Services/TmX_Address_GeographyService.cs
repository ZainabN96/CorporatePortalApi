using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_Address_GeographyService : ITmX_Address_GeographyService

    {
        private readonly ApplicationDbContext dc;

        public TmX_Address_GeographyService(ApplicationDbContext dc)
        {

            this.dc = dc;
        }
        public TmX_Address_Geography Add(TmX_Address_Geography TmX_Address_Geography)
        {
           dc.TmX_Address_Geography.Add(TmX_Address_Geography);
            return TmX_Address_Geography;
        }

        public async Task<TmX_Address_Geography> Get(int id)
        {
         return await dc.TmX_Address_Geography.FindAsync(id);

        }
    }
}
