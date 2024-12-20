using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_LocaleService: ITmX_LocaleService
    {
        private readonly ApplicationDbContext dc;

        public TmX_LocaleService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Locale Add(TmX_Locale locale)
        {
            locale.Last_Updated_Date = DateTime.Now;
            dc.TmX_Locale.Add(locale);

            return locale;
        }

        public async Task<TmX_Locale> Get(int id)
        {
            return await dc.TmX_Locale.FindAsync(id);
        }

        public async Task<IEnumerable<TmX_Locale>> GetTmX_LocaleAsync()
        {
            return await dc.TmX_Locale.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Locale_ID)
                                       .ToListAsync();
        }
    }
}
