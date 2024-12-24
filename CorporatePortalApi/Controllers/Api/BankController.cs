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
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Bank not found";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.BankService.GetAllBankAsync();
            if (entries == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Bank not found";
                return BadRequest(apiError);
            }
            return Ok(entries);
        }

        [HttpPost("addBank")]
        public async Task<IActionResult> AddBank(TmX_BankDto BankDto)
        {
            if (await uow.BankService.IsBankExist(BankDto.Bank_Name))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Bank is already exist";
                return BadRequest(apiError);
            }

            var bank = mapper.Map<TmX_Bank>(BankDto);

            uow.BankService.Add(bank);

            await uow.SaveAsync();
            return Ok(bank);
        }

        [HttpPut("updateBank")]
        public async Task<IActionResult> UpdateBank(TmX_BankDto BankDto)
        {
            APIError apiError = new APIError();

            if (await uow.BankService.IsBankExistInUpdate(BankDto.Bank_Name, BankDto.Bank_ID))
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Bank is already exist";
                return BadRequest(apiError);
            }

            var BankFromDb = await uow.BankService.Get(BankDto.Bank_ID);

            if (BankFromDb == null)
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Bank not found";
                return BadRequest(apiError);
            }

            mapper.Map(BankDto, BankFromDb);

            BankDto.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();
            return Ok(BankDto);
        }

        [HttpPost("deleteBank")]
        public async Task<IActionResult> DeleteBank(DeleteKeyPairDto deleteKeyPairDto)
        {
            var ProFromDb = await uow.BankService.Get(deleteKeyPairDto.Id);

            if (ProFromDb == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Bank not found";
                return BadRequest(apiError);
            }

            ProFromDb.Is_Active = false;
            ProFromDb.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }

    }
}
