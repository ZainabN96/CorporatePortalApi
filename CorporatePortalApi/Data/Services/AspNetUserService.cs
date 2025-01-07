using CorporatePortalApi.Data;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class AspNetUserService : IAspNetUserService
    {
        private ApplicationDbContext dc;

        public AspNetUserService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public AspNetUser Add(AspNetUser users)
        {
            users.LastLoginDate = DateTime.Now;
            dc.AspNetUsers.Add(users);

            return users;
        }
        /*public void AddUser(AspNetUser user, TmX_Address address)
        {
            // Add user to the database
            user.Status = "Active";
            dc.AspNetUsers.Add(user);

            // Add address to the database
            dc.TmX_Address.Add(address);
        }*/
        /*public void AddUser(AspNetUser user, TmX_Address address, TmX_Tenant tenant)
        {
            // Save the tenant first
            tenant.Active_Flag = true;
            tenant.Last_Updated_Date = DateTime.Now;
            dc.TmX_Tenants.Add(tenant);
            dc.SaveChanges();

            // Validate Tenant_ID
            if (tenant.Tenant_ID <= 0)
                throw new Exception("Failed to generate Tenant_ID!");

            // Assign the generated Tenant_ID to the address
            address.Tenant_ID = tenant.Tenant_ID;
            address.Active_Flag = true;

            // Save the address
            dc.TmX_Address.Add(address);
            dc.SaveChanges();

            // Validate Address_ID
            if (address.Address_ID <= 0)
                throw new Exception("Failed to generate Address_ID!");

            // Assign the generated Address_ID to the user
            user.Address_ID = address.Address_ID;
            user.Status = "Active";

            // Save the user
            dc.AspNetUsers.Add(user);
            dc.SaveChanges();
        }*/

        public void AddUser(AspNetUser user, TmX_Address address, TmX_Tenant tenant, TmX_Locale locale, TmX_Time_Zone time)
        {
            // Save the tenant
            tenant.Active_Flag = true;
            tenant.Last_Updated_Date = DateTime.Now;
            dc.TmX_Tenants.Add(tenant);
            dc.SaveChanges();

            if (tenant.Tenant_ID <= 0)
                throw new Exception("Failed to generate Tenant_ID!");

            address.Tenant_ID = tenant.Tenant_ID;
            address.Active_Flag = true;
            address.Created_Date = DateTime.Now;
            dc.TmX_Address.Add(address);
            dc.SaveChanges();

            if (address.Address_ID <= 0)
                throw new Exception("Failed to generate Address ID!");

            time.Created_Date = DateTime.Now;
            time.Active_Flag = true;
            dc.TmX_Time_Zone.Add(time);
            dc.SaveChanges();

            if (time.Time_Zone_ID <= 0)
                throw new Exception("Failed to generate Time Zone ID!");

            dc.TmX_Locale.Add(locale);
            dc.SaveChanges();

            if (locale.Locale_ID <= 0)
                throw new Exception("Failed to generate Locale ID!");

            user.Address_ID = address.Address_ID;
            user.Locale_ID = locale.Locale_ID;
            user.Time_Zone_ID = time.Time_Zone_ID;
            user.Status = "Active";
            user.RegistrationDate = DateTime.Now;

            dc.AspNetUsers.Add(user);
            dc.SaveChanges();
        }

        public async Task<AspNetUser> Get(int id)
        {
            return await dc.AspNetUsers.FindAsync(id);
        }

        public async Task<AspNetUser> GetWithName(string firstname, string lastname)
        {
            return await dc.AspNetUsers.Where(x => x.FirstName == firstname && x.LastName == lastname)
                                       .FirstOrDefaultAsync();
        }
        public async Task<AspNetUser> GetWithTenantID(int tenantID)
        {
            return await dc.AspNetUsers.Where(x => x.Tenant_ID == tenantID)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AspNetUser>> GetAspNetUserAsync()
        {
            return await dc.AspNetUsers.Where(x => x.Status == "Active")
                                       .OrderBy(x => x.Id)
                                       .ToListAsync();
        }
        public async Task<bool> IsUserExist(string email)
        {
            return await dc.AspNetUsers.AnyAsync(x => x.Email == email);
        }
       
    }
}
