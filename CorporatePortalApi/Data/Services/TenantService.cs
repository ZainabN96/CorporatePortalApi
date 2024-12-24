using CorporatePortalApi.Models;
using CorporatePortalApi.Data.IServices;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class TenantService: ITenantService
    {
        private readonly ApplicationDbContext dc;

        public TenantService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Tenant Add(TmX_Tenant tenant)
        {
            tenant.Last_Updated_Date = DateTime.Now;
            tenant.Tenant_Blocked_Flag = false;
            dc.TmX_Tenants.Add(tenant);

            return tenant;
        }

        public async Task<TmX_Tenant> Get(int id)
        {
            return await dc.TmX_Tenants.FindAsync(id);
        }

        public async Task<TmX_Tenant> GetWithName(string name)
        {
            return await dc.TmX_Tenants.Where(x => x.Tenant_Name == name)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_Tenant>> GetAllTenantAsync()
        {
            return await dc.TmX_Tenants.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Tenant_Name)
                                       .ToListAsync();
        }

        public async Task<bool> IsTenantExist(string name)
        {
            return await dc.TmX_Tenants.AnyAsync(x => x.Tenant_Name == name);
        }

        public async Task<bool> IsTenantExistInUpdate(string name, int id)
        {
            return await dc.TmX_Tenants.AnyAsync(x => x.Tenant_Name == name && x.Tenant_ID != id);
        }
    }
}
