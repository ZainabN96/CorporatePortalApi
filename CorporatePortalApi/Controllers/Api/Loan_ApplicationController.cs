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
	public class Loan_ApplicationController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;
		public Loan_ApplicationController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}


		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.Loan_ApplicationService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.Loan_ApplicationService.GetLoan_ApplicationAsync();
			if (entries == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}
			return Ok(entries);
		}

		[HttpPost("addLoanApplication")]
		public async Task<IActionResult> AddLoanApplication(TmX_Loan_ApplicationDto Loan_ApplicationDto)
		{
			if (await uow.Loan_ApplicationService.IsLoan_ApplicationExist(Loan_ApplicationDto.Loan_Application_Number))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Loan Application already exists",
						$"The Loan Application '{Loan_ApplicationDto.Loan_Application_Number}' is already registered."
				 ));
			}

			var loan_app = mapper.Map<TmX_Loan_Application>(Loan_ApplicationDto);

			uow.Loan_ApplicationService.Add(loan_app);

			await uow.SaveAsync();
			return Ok(loan_app);
		}

		[HttpPut("updateLoanApplication")]
		public async Task<IActionResult> UpdateLoanApplication(TmX_Loan_ApplicationDto Loan_ApplicationDto)
		{
			if (await uow.Loan_ApplicationService.IsLoan_ApplicationExistInUpdate(Loan_ApplicationDto.Loan_Application_Number, Loan_ApplicationDto.Loan_Application_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Loan Application already exists",
						$"The Loan Application '{Loan_ApplicationDto.Loan_Application_Number}' is already registered."
				 ));
			}

			var LoanFromDb = await uow.Loan_ApplicationService.Get(Loan_ApplicationDto.Loan_Application_ID);

			if (LoanFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(Loan_ApplicationDto, LoanFromDb);

			UHelper.UpdateTimestamp(Loan_ApplicationDto);

			await uow.SaveAsync();
			return Ok(Loan_ApplicationDto);
		}

		[HttpPost("deleteLoanApplication")]
		public async Task<IActionResult> DeleteLoanApplication(DeleteKeyPairDto deleteKeyPairDto)
		{
			var LoanFromDb = await uow.Loan_ApplicationService.Get(deleteKeyPairDto.Id);

			if (LoanFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			LoanFromDb.Status = "InActive";
			LoanFromDb.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
