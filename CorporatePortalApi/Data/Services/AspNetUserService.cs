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
			tenant.Tenant_Blocked_Flag = false;
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

			user.Tenant_ID = tenant.Tenant_ID;
			dc.AspNetUsers.Add(user);
            dc.SaveChanges();
        }

		public void UpdateUser(AspNetUser user, TmX_Address address, TmX_Tenant tenant, TmX_Locale locale, TmX_Time_Zone time)
		{
			var existingTenant = dc.TmX_Tenants.FirstOrDefault(t => t.Tenant_ID == tenant.Tenant_ID);
			var existingAddress = dc.TmX_Address.FirstOrDefault(a => a.Address_ID == address.Address_ID);
			var existingTime = dc.TmX_Time_Zone.FirstOrDefault(t => t.Time_Zone_ID == time.Time_Zone_ID);
			var existingLocale = dc.TmX_Locale.FirstOrDefault(l => l.Locale_ID == locale.Locale_ID);

			if (existingTenant != null)
			{
				existingTenant.Tenant_Name = tenant.Tenant_Name;
				existingTenant.Tenant_Registration_Date = tenant.Tenant_Registration_Date;
				existingTenant.Tenant_Activation_Date = tenant.Tenant_Activation_Date;
				existingTenant.Effective_Start_Date = tenant.Effective_Start_Date;
				existingTenant.Effective_End_Date = tenant.Effective_End_Date;
				existingTenant.Created_Date = tenant.Created_Date;
				existingTenant.Last_Updated_By = tenant.Last_Updated_By;
				existingTenant.Created_By = tenant.Created_By;
				existingTenant.Last_Updated_Date = DateTime.Now;
				existingTenant.Active_Flag = true;
				existingTenant.Tenant_Blocked_Flag = false;
			}

			if (existingAddress != null)
			{
				existingAddress.City = address.City;
				existingAddress.Country = address.Country;
				existingAddress.Address_Line_1 = address.Address_Line_1;
				existingAddress.Address_Line_2 = address.Address_Line_2;
				existingAddress.Address_Line_3 = address.Address_Line_3;
				existingAddress.Address_Line_4 = address.Address_Line_4;
				existingAddress.Postal_Zip_Code = address.Postal_Zip_Code;
				existingAddress.Effective_Start_Date = address.Effective_Start_Date;
				existingAddress.Effective_End_Date = address.Effective_End_Date;
				existingAddress.Created_By = address.Created_By;
				existingAddress.Last_Updated_Date = DateTime.Now;
				existingAddress.Active_Flag = true;
			}

			if (existingTime != null)
			{
				existingTime.Time_Zone_Name = time.Time_Zone_Name;
				existingTime.Time_Zone_Code = time.Time_Zone_Code;
				existingTime.Time_Zone_Description = time.Time_Zone_Description;
				existingTime.Created_By = time.Created_By;
				existingTime.Last_Updated_Date = DateTime.Now;
			}

			if (existingLocale != null)
			{
				existingLocale.Locale_LCID = locale.Locale_LCID;
				existingLocale.Country_Region = locale.Country_Region;
				existingLocale.Language = locale.Language;
			}

			var existingUser = dc.AspNetUsers.FirstOrDefault(u => u.Id == user.Id);
			if (existingUser != null)
			{
				existingUser.Email = user.Email;
				existingUser.FirstName = user.FirstName;
				existingUser.LastName = user.LastName;
				existingUser.UserName = user.UserName;
				existingUser.Status = "Active";
				existingUser.RegistrationDate = DateTime.Now;

				existingUser.Tenant_ID = tenant.Tenant_ID;
				existingUser.Address_ID = address.Address_ID;
				existingUser.Locale_ID = locale.Locale_ID;
				existingUser.Time_Zone_ID = time.Time_Zone_ID;

				existingUser.PasswordHash = user.PasswordHash;
				existingUser.PasswordExpiryDate = user.PasswordExpiryDate;
				existingUser.FirstPasswordChange = user.FirstPasswordChange;
				existingUser.LastLoginDate = user.LastLoginDate;
				existingUser.SecurityStamp = user.SecurityStamp;
			}

			dc.SaveChanges();
		}

		public void DeleteUser(AspNetUser user)
		{
			var address = dc.TmX_Address.FirstOrDefault(a => a.Address_ID == user.Address_ID);
			var locale = dc.TmX_Locale.FirstOrDefault(l => l.Locale_ID == user.Locale_ID);
			var timeZone = dc.TmX_Time_Zone.FirstOrDefault(t => t.Time_Zone_ID == user.Time_Zone_ID);
			var tenant = dc.TmX_Tenants.FirstOrDefault(t => t.Tenant_ID == user.Tenant_ID);

			// Update status flags
			if (address != null)
			{
				address.Active_Flag = false;
				address.Last_Updated_Date = DateTime.Now;
			}

			if (timeZone != null)
			{
				timeZone.Active_Flag = false;
				timeZone.Last_Updated_Date = DateTime.Now;
			}

			if (tenant != null)
			{
				tenant.Active_Flag = false;
				tenant.Tenant_Blocked_Flag = true;
				tenant.Last_Updated_Date = DateTime.Now;
			}

			user.Status = "InActive";
			
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
