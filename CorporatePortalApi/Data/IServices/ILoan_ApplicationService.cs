using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
	public interface ILoan_ApplicationService
	{
		TmX_Loan_Application Add(TmX_Loan_Application Loan_Application);
		Task<TmX_Loan_Application> Get(int id);
		Task<TmX_Loan_Application> GetWithstatus(string status);
		Task<TmX_Loan_Application> GetWithLoan_Application_Number(string loan_appNo);
		Task<IEnumerable<TmX_Loan_Application>> GetLoan_ApplicationAsync();
		Task<bool> IsLoan_ApplicationExist(string loan_appNo);
		Task<bool> IsLoan_ApplicationExistInUpdate(string loan_appNo, int id);
	}
}
