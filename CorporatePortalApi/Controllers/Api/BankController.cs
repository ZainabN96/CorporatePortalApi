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

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.BankService.GetAllBankAsync();

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

    }
}
