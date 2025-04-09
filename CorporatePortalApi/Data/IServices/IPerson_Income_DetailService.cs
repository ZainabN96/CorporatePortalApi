using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
	public interface IPerson_Income_DetailService
	{
		Task<TmX_Person_Income_Detail> Get(int id);
		Task<TmX_Person_Income_Detail> GetWithMonthly_Income_Amount(decimal Mon_Income_Amount);
		Task<IEnumerable<TmX_Person_Income_Detail>> GetPerson_Income_DetailAsync();
		TmX_Person_Income_Detail Add(TmX_Person_Income_Detail Income_Detail);
		Task<bool> IsPerson_Income_DetailExist(int PersonId);
		Task<bool> IsPerson_Income_DetailExistInUpdate(int personId, int id);
	}
}
