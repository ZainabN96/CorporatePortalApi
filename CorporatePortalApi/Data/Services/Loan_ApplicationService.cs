using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
	public class Loan_ApplicationService: ILoan_ApplicationService
	{
		private readonly ApplicationDbContext dc;

		public Loan_ApplicationService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}

		public TmX_Loan_Application Add(TmX_Loan_Application Loan_Application)
		{
			Loan_Application.Last_Updated_Date = DateTime.Now;
			dc.TmX_Loan_Application.Add(Loan_Application);

			return Loan_Application;
		}
		public async Task<TmX_Loan_Application> Get(int id)
		{
			return await dc.TmX_Loan_Application.FindAsync(id);
		}

		public async Task<TmX_Loan_Application> GetWithstatus(string status)
		{
			return await dc.TmX_Loan_Application.FirstOrDefaultAsync(x => x.Status == status);
		}

		public async Task<TmX_Loan_Application> GetWithLoan_Application_Number(string loan_appNo)
		{
			return await dc.TmX_Loan_Application.FirstOrDefaultAsync(x => x.Loan_Application_Number == loan_appNo);
		}

		public async Task<TmX_Loan_Application> GetWithCustomer_Name(string name)
		{
			return await dc.TmX_Loan_Application
				.Include(x => x.Customer_Master)
				.FirstOrDefaultAsync(x => x.Customer_Master.Customer_Name == name);
		}

		public async Task<TmX_Loan_Application> GetWithCNIC(string nic)
		{
			return await dc.TmX_Loan_Application
				.Include(x => x.Customer_Master)
				.FirstOrDefaultAsync(x => x.Customer_Master.National_Identifier_Value == nic);
		}

		public async Task<IEnumerable<TmX_Loan_Application>> GetLoan_ApplicationAsync()
		{
			return await dc.TmX_Loan_Application.Where(x => x.Status ==  "IsActive")
									   .OrderBy(x => x.Loan_Application_ID)
									   .ToListAsync();
		}
		public async Task<bool> IsLoan_ApplicationExist(string loan_appNo)
		{
			return await dc.TmX_Loan_Application.AnyAsync(x => x.Loan_Application_Number == loan_appNo);
		}
		public async Task<bool> IsLoan_ApplicationExistInUpdate(string loan_appNo, int id)
		{
			return await dc.TmX_Loan_Application.AnyAsync(x => x.Loan_Application_Number == loan_appNo && x.Loan_Application_ID != id);
		}
	}
}
