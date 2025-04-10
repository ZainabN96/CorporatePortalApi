using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class Customer_DetailService : ICustomer_DetailService

    {

        private readonly ApplicationDbContext dc;

        public Customer_DetailService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }   
        public TmX_Customer_Detail Add(TmX_Customer_Detail TmX_Customer_Detail)
        {
           dc.TmX_Customer_Detail.Add(TmX_Customer_Detail); 

            return TmX_Customer_Detail;
        }

        public async Task<TmX_Customer_Detail> Get(int id)
        {
            return await dc.TmX_Customer_Detail.FindAsync(id);
        }

        public async Task<IEnumerable<TmX_Customer_Detail>> GetAllCustomerDetailAsync()
        {
            return await dc.TmX_Customer_Detail.Where(x => x.Active_Flag == true)
                                      .OrderBy(x => x.Customer_Detail_ID)
                                      .ToListAsync();
        }

        public async  Task<bool> IsCustomerDetailExist(int customerDetailId)
        {
            return await dc.TmX_Customer_Detail.AnyAsync(x => x.Customer_Detail_ID == customerDetailId);
        }

        public async Task<bool> IsCustomerDetailExistInUpdate(int customerDetailId, int id)
        {
            return await dc.TmX_Customer_Detail.AnyAsync(x => x.Customer_Detail_ID == customerDetailId && x.Customer_Detail_ID != id);
        }
    }
}
