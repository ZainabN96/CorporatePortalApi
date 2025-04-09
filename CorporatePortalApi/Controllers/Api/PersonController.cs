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
	public class PersonController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public PersonController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.PersonService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.PersonService.GetPersonAsync();
			if (entries == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}
			return Ok(entries);
		}

		[HttpPost("addPerson")]
		public async Task<IActionResult> AddPerson(TmX_PersonDto PersonDto)
		{
			if (await uow.PersonService.IsPersonExist(PersonDto.Person_First_Name, PersonDto.Person_Last_Name))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						 "Person already exists",
						 $"The Person '{PersonDto.Person_First_Name}  {PersonDto.Person_Last_Name}' is already registered."
				  ));
			}

			var person = mapper.Map<TmX_Person>(PersonDto);

			uow.PersonService.Add(person);

			await uow.SaveAsync();
			return Ok(person);
		}

		[HttpPut("updatePerson")]
		public async Task<IActionResult> UpdatePerson(TmX_PersonDto PersonDto)
		{
			if (await uow.PersonService.IsPersonExistInUpdate(PersonDto.Person_First_Name, PersonDto.Person_Last_Name, PersonDto.Person_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Person already exists",
						$"The person '{PersonDto.Person_First_Name} {PersonDto.Person_Last_Name}' is already registered."
				 ));
			}

			var personFromDb = await uow.PersonService.Get(PersonDto.Person_ID);

			if (personFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(PersonDto, personFromDb);

			UHelper.UpdateTimestamp(PersonDto);

			await uow.SaveAsync();
			return Ok(PersonDto);
		}

		[HttpPost("deletePerson")]
		public async Task<IActionResult> DeletePerson(DeleteKeyPairDto deleteKeyPairDto)
		{
			if (deleteKeyPairDto.Id == 0)
			{
				return BadRequest("Invalid integer ID provided.");
			}

			var personFromDb = await uow.PersonService.Get(deleteKeyPairDto.Id);
			if (personFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(personFromDb);

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
