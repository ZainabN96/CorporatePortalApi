using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
	public class Person_Income_DetailService: IPerson_Income_DetailService
	{
		private readonly ApplicationDbContext dc;

		public Person_Income_DetailService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}
		public TmX_Person_Income_Detail Add(TmX_Person_Income_Detail Income_Detail)
		{
			dc.TmX_Person_Income_Detail.Add(Income_Detail);
			return Income_Detail;
		}

		public async Task<TmX_Person_Income_Detail> Get(int id)
		{
			return await dc.TmX_Person_Income_Detail.FindAsync(id) ?? throw new KeyNotFoundException($"Person_Income_Detail with ID '{id}' not found.");
		}

		public async Task<TmX_Person_Income_Detail> GetWithMonthly_Income_Amount(decimal Mon_Income_Amount)
		{
			return await dc.TmX_Person_Income_Detail.Where(x => x.Monthly_Income_Amount == Mon_Income_Amount).FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<TmX_Person_Income_Detail>> GetPerson_Income_DetailAsync()
		{
			return await dc.TmX_Person_Income_Detail.Where(x => x.Active_Flag == true)
									   .OrderBy(x => x.Monthly_Income_Amount)
									   .Include(x => x.Currency)
									   .Include(x => x.Tenant)
									   .Include(x => x.Person)
									   .Include(x => x.Order)
									   .ToListAsync();
		}

		public async Task<bool> IsPerson_Income_DetailExist(int PersonId)
		{
			return await dc.TmX_Person_Income_Detail.AnyAsync(x => x.Person_ID == PersonId);
		}

		public async Task<bool> IsPerson_Income_DetailExistInUpdate(int PersonId, int id)
		{
			return await dc.TmX_Person_Income_Detail.AnyAsync(x => x.Person_ID == PersonId && x.Person_Income_Detail_ID != id);
		}
	}
}
