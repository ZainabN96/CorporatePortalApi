using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
	public class Person_Expense_DetailService: IPerson_Expense_DetailService
	{
		private readonly ApplicationDbContext dc;

		public Person_Expense_DetailService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}
		public TmX_Person_Expense_Detail Add(TmX_Person_Expense_Detail Expense_Detail)
		{
			dc.TmX_Person_Expense_Detail.Add(Expense_Detail);
			return Expense_Detail;
		}

		public async Task<TmX_Person_Expense_Detail> Get(int id)
		{
			return await dc.TmX_Person_Expense_Detail.FindAsync(id) ?? throw new KeyNotFoundException($"Person_Expense_Detail with ID '{id}' not found.");
		}

		public async Task<TmX_Person_Expense_Detail> GetWithMonthly_Expense_Amount(decimal Mon_Expense_Amount)
		{
			return await dc.TmX_Person_Expense_Detail.Where(x => x.Monthly_Expense_Amount == Mon_Expense_Amount).FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<TmX_Person_Expense_Detail>> GetPerson_Expense_DetailAsync()
		{
			return await dc.TmX_Person_Expense_Detail.Where(x => x.Active_Flag == true)
									   .OrderBy(x => x.Monthly_Expense_Amount)
									   .Include(x => x.Currency)
									   .Include(x => x.Tenant)
									   .Include(x => x.Person)
									   .Include(x => x.Order)
									   .ToListAsync();
		}

		public async Task<bool> IsPerson_Expense_DetailExist(int PersonId)
		{
			return await dc.TmX_Person_Expense_Detail.AnyAsync(x => x.Person_ID == PersonId);
		}

		public async Task<bool> IsPerson_Expense_DetailExistInUpdate(int personId, int id)
		{
			return await dc.TmX_Person_Expense_Detail.AnyAsync(x => x.Person_ID == personId && x.Person_Expense_Detail_ID != id);
		}
	}
}
