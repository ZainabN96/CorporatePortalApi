using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_CurrencyService: ITmX_CurrencyService
    {
        private readonly ApplicationDbContext dc;

        public TmX_CurrencyService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Currency Add(TmX_Currency TmX_Currency)
        {
            dc.TmX_Currency.Add(TmX_Currency);

            return TmX_Currency;
        }

        public async Task<TmX_Currency> Get(int id)
        {
            return await dc.TmX_Currency.FindAsync(id);
        }
    }
}
