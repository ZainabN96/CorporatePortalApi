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
				return NotFound(ErrorCodes.NotFound());
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
				return BadRequest(ErrorCodes.BadRequestError(
						"Currency already exists",
						$"The currency '{CurrencyDto.Currency_Symbol}' is already registered."
				));
			}

			var currency = mapper.Map<TmX_Currency>(CurrencyDto);

			uow.CurrencyService.Add(currency);

			await uow.SaveAsync();
			return Ok(currency);
		}
		[HttpPut("updateCurrency")]
		public async Task<IActionResult> UpdateCurrency(TmX_CurrencyDto CurrencyDto)
		{
			if (await uow.CurrencyService.IsCurrencyExistInUpdate(CurrencyDto.Currency_Symbol, CurrencyDto.Currency_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Currency already exists",
						$"The currency '{CurrencyDto.Currency_Symbol}' is already registered with ID {CurrencyDto.Currency_ID}."
				));
			}

			var CurrencyFromDb = await uow.CurrencyService.Get(CurrencyDto.Currency_ID);

			if (CurrencyFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(CurrencyDto, CurrencyFromDb);
			UHelper.UpdateTimestamp(CurrencyDto);

			await uow.SaveAsync();
			return Ok(CurrencyDto);
		}
		[HttpPost("deleteCurrency")]
		public async Task<IActionResult> DeleteCurrency(DeleteKeyPairDto deleteKeyPairDto)
		{
			var CurrencyFromDb = await uow.CurrencyService.Get(deleteKeyPairDto.Id);

			if (CurrencyFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(CurrencyFromDb);

			await uow.SaveAsync();
			return Ok(deleteKeyPairDto);
		}

	}
}
