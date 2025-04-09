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
	public class Person_Income_DetailController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public Person_Income_DetailController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.Person_Income_DetailService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.Person_Income_DetailService.GetPerson_Income_DetailAsync();
			if (entries == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}
			return Ok(entries);
		}

		[HttpPost("addPerson_IncomeDetail")]
		public async Task<IActionResult> AddPerson_IncomeDetail(TmX_Person_Income_DetailDto income_DetailDto)
		{
			if (await uow.Person_Income_DetailService.IsPerson_Income_DetailExist(income_DetailDto.Person_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						 "Person_Income_Detail already exists",
						 $"The Person Income Detail with person id '{income_DetailDto.Person_ID}' is already registered."
				  ));
			}

			var incomeDetail = mapper.Map<TmX_Person_Income_Detail>(income_DetailDto);

			uow.Person_Income_DetailService.Add(incomeDetail);

			await uow.SaveAsync();
			return Ok(incomeDetail);
		}

		[HttpPut("updatePerson_IncomeDetail")]
		public async Task<IActionResult> UpdatePerson_IncomeDetail(TmX_Person_Income_DetailDto income_DetailDto)
		{
			if (await uow.Person_Income_DetailService.IsPerson_Income_DetailExistInUpdate(income_DetailDto.Person_ID, income_DetailDto.Person_Income_Detail_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Person Income Detail already exists",
						$"The person income detail is already registered with person id '{income_DetailDto.Person_ID}' ."
				 ));
			}

			var personIncomeFromDb = await uow.Person_Income_DetailService.Get(income_DetailDto.Person_Income_Detail_ID);

			if (personIncomeFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(income_DetailDto, personIncomeFromDb);

			UHelper.UpdateTimestamp(income_DetailDto);

			await uow.SaveAsync();
			return Ok(income_DetailDto);
		}

		[HttpPost("deletePerson_IncomeDetail")]
		public async Task<IActionResult> DeletePerson_IncomeDetail(DeleteKeyPairDto deleteKeyPairDto)
		{
			if (deleteKeyPairDto.Id == 0)
			{
				return BadRequest("Invalid integer ID provided.");
			}

			var personIncomeFromDb = await uow.Person_Income_DetailService.Get(deleteKeyPairDto.Id);
			if (personIncomeFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(personIncomeFromDb);

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
