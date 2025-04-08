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
    public class BankController : Controller
    {
        
        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public BankController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.BankService.Get(id);

            if (entry == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.BankService.GetAllBankAsync();
            if (entries == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}
            return Ok(entries);
        }

        [HttpPost("addBank")]
        public async Task<IActionResult> AddBank(TmX_BankDto BankDto)
        {
            if (await uow.BankService.IsBankExist(BankDto.Bank_Name))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						 "Bank already exists",
						 $"The bank '{BankDto.Bank_Name}' is already registered."
				  ));
			}

            var bank = mapper.Map<TmX_Bank>(BankDto);

            uow.BankService.Add(bank);

            await uow.SaveAsync();
            return Ok(bank);
        }

        [HttpPut("updateBank")]
        public async Task<IActionResult> UpdateBank(TmX_BankDto BankDto)
        {
            if (await uow.BankService.IsBankExistInUpdate(BankDto.Bank_Name, BankDto.Bank_ID))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						"Bank already exists",
						$"The bank '{BankDto.Bank_Name}' is already registered."
				 ));
			}

            var BankFromDb = await uow.BankService.Get(BankDto.Bank_ID);

            if (BankFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            mapper.Map(BankDto, BankFromDb);

			UHelper.UpdateTimestamp(BankDto);

			await uow.SaveAsync();
            return Ok(BankDto);
        }

        [HttpPost("deleteBank")]
        public async Task<IActionResult> DeleteBank(DeleteKeyPairDto deleteKeyPairDto)
        {
			if (deleteKeyPairDto.Id==0)
			{
				return BadRequest("Invalid integer ID provided.");
			}

			var bankFromDb = await uow.BankService.Get(deleteKeyPairDto.Id);
			if (bankFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

			bankFromDb.Is_Active = false;
			bankFromDb.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }

    }
}
