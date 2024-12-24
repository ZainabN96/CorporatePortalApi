using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

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
		public async Task<TmX_Bank> GetWithBankName(string bname)
		{
			return await dc.TmX_Bank.Where(x => x.Bank_Name == bname)
									   .FirstOrDefaultAsync();
		}
		
		public async Task<IEnumerable<TmX_Bank>> GetTmX_BankAsync()
		{
			return await dc.TmX_Bank.Where(x => x.Is_Active == true)
									   .OrderBy(x => x.Bank_Name)
									   .ToListAsync();
		}

		public async Task<bool> IsTmX_BankExist(string bankName)
		{
			return await dc.TmX_Bank.AnyAsync(x => x.Bank_Name == bankName);
		}

		public async Task<bool> IsTmX_BankExistInUpdate(string bankName, int id)
		{
			return await dc.TmX_Bank.AnyAsync(x => x.Bank_Name == bankName && x.Bank_ID != id);
		}
	}
}
