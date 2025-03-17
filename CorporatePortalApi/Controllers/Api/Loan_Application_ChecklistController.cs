using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorporatePortalApi.Controllers.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class Loan_Application_ChecklistController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;
		public Loan_Application_ChecklistController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}
		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.Loan_Application_ChecklistService.Get(id);

			if (entry == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Loan Application Checklist not found";
				return BadRequest(apiError);
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.Loan_Application_ChecklistService.GetLoan_App_ChecklistAsync();
			if (entries == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Loan Application Checklist not found";
				return BadRequest(apiError);
			}
			return Ok(entries);
		}

		[HttpPost("addLoanAppChecklist")]
		public async Task<IActionResult> AddLoanAppChecklist(TmX_Loan_Application_ChecklistDto Loan_App_ChecklistDto)
		{
			if (await uow.Loan_Application_ChecklistService.IsLoan_App_ChecklistExist(Loan_App_ChecklistDto.Loan_Application_Checklist_ID))
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Loan Application Checklist is already exist";
				return BadRequest(apiError);
			}

			var loan_Checklist = mapper.Map<TmX_Loan_Application_Checklist>(Loan_App_ChecklistDto);

			uow.Loan_Application_ChecklistService.Add(loan_Checklist);

			await uow.SaveAsync();
			return Ok(loan_Checklist);
		}

		[HttpPut("updateLoanAppChecklist")]
		public async Task<IActionResult> UpdateLoanAppChecklist(TmX_Loan_Application_ChecklistDto Loan_App_ChecklistDto)
		{
			APIError apiError = new APIError();

			var LoanFromDb = await uow.Loan_Application_ChecklistService.Get(Loan_App_ChecklistDto.Loan_Application_Checklist_ID);

			if (LoanFromDb == null)
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Loan Application Checklist not found";
				return BadRequest(apiError);
			}

			mapper.Map(Loan_App_ChecklistDto, LoanFromDb);

			Loan_App_ChecklistDto.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();
			return Ok(Loan_App_ChecklistDto);
		}

		[HttpPost("deleteLoanApplication")]
		public async Task<IActionResult> DeleteLoanApplication(DeleteKeyPairDto deleteKeyPairDto)
		{
			var ProFromDb = await uow.Loan_Application_ChecklistService.Get(deleteKeyPairDto.Id);

			if (ProFromDb == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Loan Application Checklist not found";
				return BadRequest(apiError);
			}

			ProFromDb.Active_Flag = false;
			ProFromDb.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
