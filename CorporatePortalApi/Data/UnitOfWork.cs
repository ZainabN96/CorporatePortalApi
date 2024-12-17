using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Data.Services;
using CorporatePortalApi.Data;

namespace CorporatePortalApi
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dc;

        public UnitOfWork(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public IAspNetUserService AspNetUserService => new AspNetUserService(dc);
        public ITmX_CorporateService TmX_CorporateService => new TmX_CorporateService(dc);
        public async Task<bool> SaveAsync()
        {
            try
            {
                return await dc.SaveChangesAsync() > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
