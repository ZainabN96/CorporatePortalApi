using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IPerson_Address_ContactService
    {
        Task<TmX_Person_Address_Contact> Get(int id);
        Task<IEnumerable<TmX_Person_Address_Contact>> GetAllPersonAddressContactAsync();
        TmX_Person_Address_Contact Add(TmX_Person_Address_Contact TmX_Person_Address_Contact);
        Task<bool> IsPersonAddressContactExist(string contactNumber);
        Task<bool> IsPersonAddressContactExistInUpdate(string contactNumber, int id);   
    }
}
