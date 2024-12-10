using CorporatePortalApi.Data;

namespace CorporatePortalApi.Data.Services
{
    public class AspNetUserService
    {
        private ApplicationDbContext dc;

        public AspNetUserService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
    }
}
