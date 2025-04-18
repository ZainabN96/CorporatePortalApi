﻿using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
	public class Loan_ApplicationService: ILoan_ApplicationService
	{
		private readonly ApplicationDbContext dc;

		public Loan_ApplicationService(ApplicationDbContext dc)
		{
			this.dc = dc;
		}

		public TmX_Loan_Application Add(TmX_Loan_Application Loan_Application)
		{
			Loan_Application.Last_Updated_Date = DateTime.Now;
			dc.TmX_Loan_Application.Add(Loan_Application);

			return Loan_Application;
		}
		public async Task<TmX_Loan_Application> Get(int id)
		{
			return await dc.TmX_Loan_Application.FindAsync(id) ?? throw new KeyNotFoundException($"Loan application with ID {id} not found.");
		}

		public async Task<TmX_Loan_Application> GetWithstatus(string status)
		{
			return await dc.TmX_Loan_Application.FirstOrDefaultAsync(x => x.Status == status) ?? throw new KeyNotFoundException($"No loan application found with status '{status}'.");
		}

		public async Task<TmX_Loan_Application> GetWithLoan_Application_Number(string loan_appNo)
		{
			return await dc.TmX_Loan_Application.FirstOrDefaultAsync(x => x.Loan_Application_Number == loan_appNo) ?? throw new KeyNotFoundException($"Loan application with number {loan_appNo} not found.");
		}

		public async Task<TmX_Loan_Application> GetWithCustomer_Name(string name)
		{
			return await dc.TmX_Loan_Application
				.Include(x => x.Customer_Master)
				.FirstOrDefaultAsync(x => x.Customer_Master.Customer_Name == name);
		}

		public async Task<TmX_Loan_Application> GetWithCNIC(string nic)
		{
			return await dc.TmX_Loan_Application
				.Include(x => x.Customer_Master)
				.FirstOrDefaultAsync(x => x.Customer_Master.National_Identifier_Value == nic) ?? throw new KeyNotFoundException($"No loan application found for CNIC '{nic}'.");
		}

		public async Task<IEnumerable<TmX_Loan_Application>> GetLoan_ApplicationAsync()
		{
			return await dc.TmX_Loan_Application.Where(x => x.Status ==  "Active")
									   .OrderBy(x => x.Loan_Application_ID)
									   .Include(x => x.Currency)
									   .Include(x => x.Order)
											.ThenInclude(od => od.Institute)
									   .Include(x => x.Company_Branch)
									   .Include(x => x.Geofence)
									   .Include(x => x.Product)
											.ThenInclude(p => p.Bank)
									   .Include(x => x.Customer_Master)
											.ThenInclude(cm => cm.Transaction)
									   .Include(x => x.User)
									   .Include(x => x.Tenant)
									   .ToListAsync();
		}
		public async Task<bool> IsLoan_ApplicationExist(string loan_appNo)
		{
			return await dc.TmX_Loan_Application.AnyAsync(x => x.Loan_Application_Number == loan_appNo);
		}
		public async Task<bool> IsLoan_ApplicationExistInUpdate(string loan_appNo, int id)
		{
			return await dc.TmX_Loan_Application.AnyAsync(x => x.Loan_Application_Number == loan_appNo && x.Loan_Application_ID != id);
		}
	}
}
