using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_AddressService
    {
        Task<TmX_Address> Get(int id);
        Task<TmX_Address> GetWithName(string name);
        //Task<IEnumerable<TmX_Address>> GetTmX_AddresseAsync();
        TmX_Address Add(TmX_Address TmX_Address);
        Task<bool> IsTmX_AddressExist(string country);
        Task<bool> IsTmX_AddressExistInUpdate(string country, int id);
    }
}
