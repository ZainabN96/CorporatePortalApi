﻿using CorporatePortalApi.Data.Services;

namespace CorporatePortalApi.Data.IServices
{
    public interface IUnitOfWork
    {
        IAspNetUserService AspNetUserService { get; }
        ICorporateService CorporateService { get; }
        IBankService BankService { get; }
        ICurrencyService CurrencyService { get; }
        ITmX_LocationService TmX_LocationService { get; }
        ITmX_AddressService TmX_AddressService { get; }
        ITenantService TenantService { get; }
        ITmX_LocaleService TmX_LocaleService { get; }
        ITmX_Time_ZoneService TmX_Time_ZoneService { get; }
        IAspNetUserRoleService AspNetUserRolesService { get; }
        IProductService ProductService { get; }
        IUserService UserService { get; }
        ITmX_User_To_Corporate_MappingService TmX_User_To_Corporate_MappingService { get; }
        IAspNetRoleService AspNetRoleService { get; }
        ITmX_Address_GeographyService TmX_Address_GeographyService { get; }

        ITmX_LookupService TmX_LookupService { get; }

		ILoan_ApplicationService Loan_ApplicationService { get; }
		ILoan_Application_ChecklistService Loan_Application_ChecklistService { get; }

		Task<bool> SaveAsync();
    }
}
