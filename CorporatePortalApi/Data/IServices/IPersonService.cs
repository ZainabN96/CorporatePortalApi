using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
	public interface IPersonService
	{
		Task<TmX_Person> Get(int id);
		Task<TmX_Person> GetWithName(string firstname, string lastname);
		Task<IEnumerable<TmX_Person>> GetPersonAsync();
		TmX_Person Add(TmX_Person TmX_Person);
		Task<bool> IsPersonExist(string firstname, string lastname);
		Task<bool> IsPersonExistInUpdate(string firstname, string lastname, int id);
	}
}
