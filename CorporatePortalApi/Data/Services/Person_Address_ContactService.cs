using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class Person_Address_ContactService : IPerson_Address_ContactService
    {
        private readonly ApplicationDbContext dc;

        public Person_Address_ContactService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }   
        public TmX_Person_Address_Contact Add(TmX_Person_Address_Contact TmX_Person_Address_Contact)
        {
            dc.TmX_Person_Address_Contact.Add(TmX_Person_Address_Contact);
        
            return TmX_Person_Address_Contact;
        }

        public async   Task<TmX_Person_Address_Contact> Get(int id)
        {
            return await dc.TmX_Person_Address_Contact.FindAsync(id);
        }

        public async Task<IEnumerable<TmX_Person_Address_Contact>> GetAllPersonAddressContactAsync()
        {
            return await dc.TmX_Person_Address_Contact
                          .Where(x => x.Active_Flag == true)
                          .OrderBy(x => x.Person_Address_Contact_ID)
                          .ToListAsync();
        }

        public async Task<bool> IsPersonAddressContactExist(string contactNumber)
        {
            return await dc.TmX_Person_Address_Contact
                           .AnyAsync(x => x.Contact_Number == contactNumber);
        }

        public async Task<bool> IsPersonAddressContactExistInUpdate(string contactNumber, int id)
        {
            return await dc.TmX_Person_Address_Contact
                            .AnyAsync(x => x.Contact_Number == contactNumber && x.Person_Address_Contact_ID != id);
        }
    }
}
