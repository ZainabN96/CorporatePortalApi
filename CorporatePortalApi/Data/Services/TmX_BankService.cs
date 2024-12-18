using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_BankService: ITmX_BankService
    {
        private readonly ApplicationDbContext dc;

        public TmX_BankService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Bank Add(TmX_Bank TmX_Bank)
        {

            dc.TmX_Bank.Add(TmX_Bank);

            return TmX_Bank;
        }

        public async Task<TmX_Bank> Get(int id)
        {
            return await dc.TmX_Bank.FindAsync(id);
        }

    }
}
