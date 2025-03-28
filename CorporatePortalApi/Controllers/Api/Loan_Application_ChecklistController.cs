using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Helper;
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
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.Loan_Application_ChecklistService.GetLoan_App_ChecklistAsync();
			if (entries == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}
			return Ok(entries);
		}

		[HttpPost("addLoanAppChecklist")]
		public async Task<IActionResult> AddLoanAppChecklist(TmX_Loan_Application_ChecklistDto Loan_App_ChecklistDto)
		{
			if (await uow.Loan_Application_ChecklistService.IsLoan_App_ChecklistExist(Loan_App_ChecklistDto.Loan_Application_Checklist_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Loan Application Checklist already exists",
						$"The Loan Application Checklist is already registered with ID {Loan_App_ChecklistDto.Loan_Application_Checklist_ID}."
				));
			}

			var loan_Checklist = mapper.Map<TmX_Loan_Application_Checklist>(Loan_App_ChecklistDto);

			uow.Loan_Application_ChecklistService.Add(loan_Checklist);

			await uow.SaveAsync();
			return Ok(loan_Checklist);
		}

		[HttpPut("updateLoanAppChecklist")]
		public async Task<IActionResult> UpdateLoanAppChecklist(TmX_Loan_Application_ChecklistDto Loan_App_ChecklistDto)
		{
			var LoanFromDb = await uow.Loan_Application_ChecklistService.Get(Loan_App_ChecklistDto.Loan_Application_Checklist_ID);

			if (LoanFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(Loan_App_ChecklistDto, LoanFromDb);

			UHelper.UpdateTimestamp(Loan_App_ChecklistDto);

			await uow.SaveAsync();
			return Ok(Loan_App_ChecklistDto);
		}

		[HttpPost("deleteLoanApplication")]
		public async Task<IActionResult> DeleteLoanApplication(DeleteKeyPairDto deleteKeyPairDto)
		{
			var LoanCFromDb = await uow.Loan_Application_ChecklistService.Get(deleteKeyPairDto.Id);

			if (LoanCFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(LoanCFromDb);

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
