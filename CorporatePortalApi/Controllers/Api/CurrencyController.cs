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
	public class CurrencyController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public CurrencyController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.CurrencyService.Get(id);

			if (entry == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Currency not found";
				return BadRequest(apiError);
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.CurrencyService.GetAllCurrencyAsync();

			return Ok(entries);
		}

		[HttpPost("addCurrency")]
		public async Task<IActionResult> AddCurrency(TmX_CurrencyDto CurrencyDto)
		{
			if (await uow.CurrencyService.IsCurrencyExist(CurrencyDto.Currency_Symbol))
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Currency is already exist";
				return BadRequest(apiError);
			}

			var currency = mapper.Map<TmX_Currency>(CurrencyDto);

			uow.CurrencyService.Add(currency);

			await uow.SaveAsync();
			return Ok(currency);
		}
		[HttpPut("updateCurrency")]
		public async Task<IActionResult> UpdateCurrency(TmX_CurrencyDto CurrencyDto)
		{
			APIError apiError = new APIError();

			if (await uow.CurrencyService.IsCurrencyExistInUpdate(CurrencyDto.Currency_Symbol, CurrencyDto.Currency_ID))
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Currency already exists.";
				return BadRequest(apiError);
			}

			var CurrencyFromDb = await uow.CurrencyService.Get(CurrencyDto.Currency_ID);

			if (CurrencyFromDb == null)
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Currency not found!";
				return BadRequest(apiError);
			}

			mapper.Map(CurrencyDto, CurrencyFromDb);

			CurrencyDto.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();
			return Ok(CurrencyDto);
		}
		[HttpPost("deleteCurrency")]
		public async Task<IActionResult> DeleteCurrency(DeleteKeyPairDto deleteKeyPairDto)
		{
			var CurrencyFromDb = await uow.CurrencyService.Get(deleteKeyPairDto.Id);

			if (CurrencyFromDb == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Currency not found!";
				return BadRequest(apiError);
			}

			CurrencyFromDb.Active_Flag = false;
			CurrencyFromDb.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}

	}
}
