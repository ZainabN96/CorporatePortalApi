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
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Loan Application not found";
				return BadRequest(apiError);
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.Loan_ApplicationService.GetLoan_ApplicationAsync();
			if (entries == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Loan Application not found";
				return BadRequest(apiError);
			}
			return Ok(entries);
		}

		[HttpPost("addLoanApplication")]
		public async Task<IActionResult> AddLoanApplication(TmX_Loan_ApplicationDto Loan_ApplicationDto)
		{
			if (await uow.Loan_ApplicationService.IsLoan_ApplicationExist(Loan_ApplicationDto.Loan_Application_Number))
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Loan Application is already exist";
				return BadRequest(apiError);
			}

			var loan_app = mapper.Map<TmX_Loan_Application>(Loan_ApplicationDto);

			uow.Loan_ApplicationService.Add(loan_app);

			await uow.SaveAsync();
			return Ok(loan_app);
		}

		[HttpPut("updateLoanApplication")]
		public async Task<IActionResult> UpdateLoanApplication(TmX_Loan_ApplicationDto Loan_ApplicationDto)
		{
			APIError apiError = new APIError();

			if (await uow.Loan_ApplicationService.IsLoan_ApplicationExistInUpdate(Loan_ApplicationDto.Loan_Application_Number, Loan_ApplicationDto.Loan_Application_ID))
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Loan_Application is already exist";
				return BadRequest(apiError);
			}

			var LoanFromDb = await uow.Loan_ApplicationService.Get(Loan_ApplicationDto.Loan_Application_ID);

			if (LoanFromDb == null)
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Loan_Application not found";
				return BadRequest(apiError);
			}

			mapper.Map(Loan_ApplicationDto, LoanFromDb);

			Loan_ApplicationDto.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();
			return Ok(Loan_ApplicationDto);
		}

		[HttpPost("deleteLoanApplication")]
		public async Task<IActionResult> DeleteLoanApplication(DeleteKeyPairDto deleteKeyPairDto)
		{
			var ProFromDb = await uow.Loan_ApplicationService.Get(deleteKeyPairDto.Id);

			if (ProFromDb == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Loan_Application not found";
				return BadRequest(apiError);
			}

			ProFromDb.Status = "IsDeleted";
			ProFromDb.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
