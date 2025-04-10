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
	public class Person_Expense_DetailController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public Person_Expense_DetailController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.Person_Expense_DetailService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.Person_Expense_DetailService.GetPerson_Expense_DetailAsync();
			if (entries == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}
			return Ok(entries);
		}

		[HttpPost("addPerson_ExpenseDetail")]
		public async Task<IActionResult> AddPerson_ExpenseDetail(TmX_Person_Expense_DetailDto expense_DetailDto)
		{
			if (await uow.Person_Expense_DetailService.IsPerson_Expense_DetailExist(expense_DetailDto.Person_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						 "Person_Expense_Detail already exists",
						 $"The Person Expense Detail with person id '{expense_DetailDto.Person_ID}' is already registered."
				  ));
			}

			var expenseDetail = mapper.Map<TmX_Person_Expense_Detail>(expense_DetailDto);

			uow.Person_Expense_DetailService.Add(expenseDetail);

			await uow.SaveAsync();
			return Ok(expenseDetail);
		}

		[HttpPut("updatePerson_ExpenseDetail")]
		public async Task<IActionResult> UpdatePerson_ExpenseDetail(TmX_Person_Expense_DetailDto expense_DetailDto)
		{
			if (await uow.Person_Expense_DetailService.IsPerson_Expense_DetailExistInUpdate(expense_DetailDto.Person_ID, expense_DetailDto.Person_Expense_Detail_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Person Expense Detail already exists",
						$"The person expense detail is already registered with person id '{expense_DetailDto.Person_ID}' ."
				 ));
			}

			var personExpenseFromDb = await uow.Person_Expense_DetailService.Get(expense_DetailDto.Person_Expense_Detail_ID);

			if (personExpenseFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(expense_DetailDto, personExpenseFromDb);

			UHelper.UpdateTimestamp(expense_DetailDto);

			await uow.SaveAsync();
			return Ok(expense_DetailDto);
		}

		[HttpPost("deletePerson_ExpenseDetail")]
		public async Task<IActionResult> DeletePerson_ExpenseDetail(DeleteKeyPairDto deleteKeyPairDto)
		{
			if (deleteKeyPairDto.Id == 0)
			{
				return BadRequest("Invalid integer ID provided.");
			}

			var personExpenseFromDb = await uow.Person_Expense_DetailService.Get(deleteKeyPairDto.Id);
			if (personExpenseFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(personExpenseFromDb);

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
