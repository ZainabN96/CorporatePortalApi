using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class CorporateService: ICorporateService
    {
        private readonly ApplicationDbContext dc;

        public CorporateService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Corporate Add(TmX_Corporate Organization)
        {
            Organization.Last_Updated_Date = DateTime.Now;
            dc.TmX_Corporate.Add(Organization);

            return Organization;
        }

        public async Task<TmX_Corporate> Get(int id)
        {
            return await dc.TmX_Corporate.FindAsync(id);
        }

        public async Task<TmX_Corporate> GetWithName(string name)
        {
            return await dc.TmX_Corporate.Where(x => x.Corporate_Name == name)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_Corporate>> GetOrganizationAsync()
        {
            return await dc.TmX_Corporate.Where(x => x.Active_Flag == true )
                                       .OrderBy(x => x.Corporate_Name)
                                       .ToListAsync();
        }

        public async Task<bool> IsCorporateExist(string name)
        {
            return await dc.TmX_Corporate.AnyAsync(x => x.Corporate_Name == name);
        }

        public async Task<bool> IsCorporateExistInUpdate(string name, int id)
        {
            return await dc.TmX_Corporate.AnyAsync(x => x.Corporate_Name == name && x.Corporate_Id != id);
        }


    }
}
