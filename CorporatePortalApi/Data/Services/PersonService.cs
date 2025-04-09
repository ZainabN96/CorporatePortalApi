using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;
using CorporatePortalApi.Data.IServices;

namespace CorporatePortalApi.Data.Services
{
	public class PersonService: IPersonService
	{
		private readonly ApplicationDbContext dc;

		public PersonService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}
		public TmX_Person Add(TmX_Person Person)
		{
			dc.TmX_Person.Add(Person);
			return Person;
		}

		public async Task<TmX_Person> Get(int id)
		{
			return await dc.TmX_Person.FindAsync(id) ?? throw new KeyNotFoundException($"Person with ID '{id}' not found.");
		}

		public async Task<TmX_Person> GetWithName(string firstname, string lastname)
		{
			return await dc.TmX_Person.Where(x => x.Person_First_Name == firstname && x.Person_Last_Name == lastname)
									   .FirstOrDefaultAsync() ?? throw new KeyNotFoundException($"Person with Name '{firstname}' not found.");
		}

		public async Task<IEnumerable<TmX_Person>> GetPersonAsync()
		{
			return await dc.TmX_Person.Where(x => x.Active_Flag == true)
									   .OrderBy(x => x.Person_First_Name)
									   .Include(x => x.Currency)
									   .Include(x => x.Tenant)
									   .ToListAsync();
		}

		public async Task<bool> IsPersonExist(string firstname, string lastname)
		{
			return await dc.TmX_Person.AnyAsync(x => x.Person_First_Name == firstname && x.Person_Last_Name== lastname);
		}

		public async Task<bool> IsPersonExistInUpdate(string firstname, string lastname, int id)
		{
			return await dc.TmX_Person.AnyAsync(x => x.Person_First_Name == firstname && x.Person_Last_Name == lastname && x.Person_ID != id);
		}
	}
}
