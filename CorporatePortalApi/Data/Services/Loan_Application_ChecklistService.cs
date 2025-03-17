using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
	public class Loan_Application_ChecklistService: ILoan_Application_ChecklistService
	{
		private readonly ApplicationDbContext dc;

		public Loan_Application_ChecklistService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}
		public TmX_Loan_Application_Checklist Add(TmX_Loan_Application_Checklist Loan_Application_Checklist)
		{
			Loan_Application_Checklist.Last_Updated_Date = DateTime.Now;
			dc.TmX_Loan_Application_Checklist.Add(Loan_Application_Checklist);

			return Loan_Application_Checklist;
		}
		public async Task<TmX_Loan_Application_Checklist> Get(int id)
		{
			return await dc.TmX_Loan_Application_Checklist.FindAsync(id);
		}

		public async Task<IEnumerable<TmX_Loan_Application_Checklist>> GetLoan_App_ChecklistAsync()
		{
			return await dc.TmX_Loan_Application_Checklist.Where(x => x.Active_Flag == true)
									   .OrderBy(x => x.Loan_Application_Checklist_ID)
									   .ToListAsync();
		}
		public async Task<bool> IsLoan_App_ChecklistExist(int loan_checkId)
		{
			return await dc.TmX_Loan_Application_Checklist.AnyAsync(x => x.Loan_Application_Checklist_ID == loan_checkId);
		}
		
	}
}
