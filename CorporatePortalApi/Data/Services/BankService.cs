using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class BankService: IBankService
    {
        private readonly ApplicationDbContext dc;

        public BankService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Bank Add(TmX_Bank TmX_Bank)
        {

            dc.TmX_Bank.Add(TmX_Bank);

            return TmX_Bank;
        }
        public async Task<IEnumerable<TmX_Bank>> GetAllBankAsync()
        {
            return await dc.TmX_Bank.Where(x => x.Is_Active == true)
                                       .OrderBy(x => x.Bank_Name)
                                       .ToListAsync();
        }

        public async Task<TmX_Bank> Get(int id)
        {
            return await dc.TmX_Bank.FindAsync(id);
        }

		public async Task<bool> IsBankExist(string bankName)
		{
			return await dc.TmX_Bank.AnyAsync(x => x.Bank_Name == bankName);
		}

		public async Task<bool> IsBankExistInUpdate(string bankName, int id)
		{
			return await dc.TmX_Bank.AnyAsync(x => x.Bank_Name == bankName && x.Bank_ID != id);
		}
	}
}
