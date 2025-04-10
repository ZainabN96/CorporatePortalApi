using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class Person_National_IdentifierService : IPerson_National_IdentifierService

    {
        private readonly ApplicationDbContext dc;

        public Person_National_IdentifierService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Person_National_Identifier Add(TmX_Person_National_Identifier TmX_PersonNI)
        {
            dc.TmX_Person_National_Identifier.Add(TmX_PersonNI);

            return TmX_PersonNI;
        }

        public async Task<TmX_Person_National_Identifier> Get(int id)
        {
            return await dc.TmX_Person_National_Identifier.FindAsync(id);
        }

        public async Task<IEnumerable<TmX_Person_National_Identifier>> GetAllPersonNationalIdentifierAsync()
        {
            return await dc.TmX_Person_National_Identifier.Where(x => x.Active_Flag == true)
                                      .OrderBy(x => x.Tenant_ID)
                                      .ToListAsync();
        }

        public async Task<bool> IsNationalIdentifierExist(int personId)
        {
            return await dc.TmX_Person_National_Identifier
                           .AnyAsync(x => x.Person_ID == personId);
        }

        public async Task<bool> IsNationalIdentifierExistInUpdate(int personId, int id)
        {
            return await dc.TmX_Person_National_Identifier
                           .AnyAsync(x => x.Person_ID == personId && x.Person_National_Identifier_ID != id);
        }
    }
}
