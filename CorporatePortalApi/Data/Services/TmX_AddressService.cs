using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_AddressService : ITmX_AddressService
    {
        private readonly ApplicationDbContext dc;

        public TmX_AddressService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Address Add(TmX_Address address)
        {
            address.Last_Updated_Date = DateTime.Now;
            dc.TmX_Address.Add(address);

            return address;
        }

        public async Task<TmX_Address> Get(int id)
        {
            return await dc.TmX_Address.FindAsync(id);
        }

        public async Task<TmX_Address> GetWithName(string country)
        {
            return await dc.TmX_Address.Where(x => x.Country == country)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_Address>> GetTmX_AddressAsync()
        {
            return await dc.TmX_Address.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Country)
                                       .ToListAsync();
        }

        public async Task<bool> IsTmX_AddressExist(string country)
        {
            return await dc.TmX_Address.AnyAsync(x => x.Country == country);
        }

        public async Task<bool> IsTmX_AddressExistInUpdate(string country, int id)
        {
            return await dc.TmX_Address.AnyAsync(x => x.Country == country && x.Address_ID != id);
        }
    }
}
