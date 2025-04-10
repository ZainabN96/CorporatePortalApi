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
        public ICorporateService CorporateService => new CorporateService(dc);
        public IBankService BankService => new BankService(dc);
        public ICurrencyService CurrencyService => new CurrencyService(dc);
        public ITmX_LocationService TmX_LocationService => new TmX_LocationService(dc);
        public ITmX_AddressService TmX_AddressService => new TmX_AddressService(dc);
        public ITenantService TenantService => new TenantService(dc);
        public ITmX_LocaleService TmX_LocaleService => new TmX_LocaleService(dc);
        public ITmX_Time_ZoneService TmX_Time_ZoneService => new TmX_Time_ZoneService(dc);
        public IAspNetUserRoleService AspNetUserRolesService => new AspNetUserRoleService(dc);
        public IProductService ProductService => new ProductService(dc);
        public IUserService UserService => new UserService(dc);
        public ITmX_User_To_Corporate_MappingService TmX_User_To_Corporate_MappingService => new TmX_User_To_Corporate_MappingService(dc);

		public ILoan_ApplicationService Loan_ApplicationService => new Loan_ApplicationService(dc);
		public ILoan_Application_ChecklistService Loan_Application_ChecklistService => new Loan_Application_ChecklistService(dc);
		public IAspNetRoleService AspNetRoleService => new AspNetRoleService(dc);   

        public ITmX_Address_GeographyService TmX_Address_GeographyService => new TmX_Address_GeographyService(dc);    

        public ITmX_LookupService TmX_LookupService => new TmX_LookupService(dc);
        public IPersonService PersonService => new PersonService(dc);
        public IPerson_Income_DetailService Person_Income_DetailService => new Person_Income_DetailService(dc);
        public IPerson_Expense_DetailService Person_Expense_DetailService => new Person_Expense_DetailService(dc);
        public ICustomer_DetailService Customer_DetailService => new Customer_DetailService(dc);

        public IPerson_National_IdentifierService Person_National_IdentifierService => new Person_National_IdentifierService(dc);

        public IPerson_Address_ContactService Person_Address_ContactService => new Person_Address_ContactService(dc);   

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
