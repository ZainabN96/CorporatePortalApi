using CorporatePortalApi.Data;
using CorporatePortalApi.Data.IServices;

namespace CorporatePortalApi.Data.Services
{
    public class AspNetUserService : IAspNetUserService
    {
        private ApplicationDbContext dc;

        public AspNetUserService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
    }
}
