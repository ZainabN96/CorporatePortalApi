using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
	public interface IPerson_Expense_DetailService
	{
		Task<TmX_Person_Expense_Detail> Get(int id);
		Task<TmX_Person_Expense_Detail> GetWithMonthly_Expense_Amount(decimal Mon_Expense_Amount);
		Task<IEnumerable<TmX_Person_Expense_Detail>> GetPerson_Expense_DetailAsync();
		TmX_Person_Expense_Detail Add(TmX_Person_Expense_Detail Expense_Detail);
		Task<bool> IsPerson_Expense_DetailExist(int PersonId);
		Task<bool> IsPerson_Expense_DetailExistInUpdate(int personId, int id);
	}
}
