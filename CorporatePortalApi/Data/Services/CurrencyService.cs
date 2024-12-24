using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class CurrencyService: ICurrencyService
    {
        private readonly ApplicationDbContext dc;

        public CurrencyService(ApplicationDbContext dc)
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
		public async Task<TmX_Currency> GetWithCurrency_Symbol(string currency)
		{
			return await dc.TmX_Currency.Where(x => x.Currency_Symbol == currency)
									   .FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<TmX_Currency>> GetAllCurrencyAsync()
		{
			return await dc.TmX_Currency.Where(x => x.Active_Flag == true)
									   .OrderBy(x => x.Currency_Symbol)
									   .ToListAsync();
		}

		public async Task<bool> IsCurrencyExist(string currency)
		{
			return await dc.TmX_Currency.AnyAsync(x => x.Currency_Symbol == currency);
		}

		public async Task<bool> IsCurrencyExistInUpdate(string currencyS, int id)
		{
			return await dc.TmX_Currency.AnyAsync(x => x.Currency_Symbol == currencyS && x.Currency_ID != id);
		}
	}
}
