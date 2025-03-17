using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
	public interface ILoan_Application_ChecklistService
	{
		TmX_Loan_Application_Checklist Add(TmX_Loan_Application_Checklist Loan_Application_Checklist);
		Task<TmX_Loan_Application_Checklist> Get(int id);
		Task<IEnumerable<TmX_Loan_Application_Checklist>> GetLoan_App_ChecklistAsync();
		Task<bool> IsLoan_App_ChecklistExist(int loan_appNo);

	}
}
