using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Helper;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorporatePortalApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customer_DetailController : Controller
    {

        private IUnitOfWork uow;
        private readonly IMapper mapper;
        public Customer_DetailController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }


        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.Customer_DetailService.Get(id);

            if (entry == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            return Ok(entry);
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.Customer_DetailService.GetAllCustomerDetailAsync();
            if (entries == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }
            return Ok(entries);
        }

        [HttpPost("addCustomerDetail")]
        public async Task<IActionResult> AddCustomerDetail(TmX_Customer_DetailDto customerDetailDto)
        {
            if (await uow.Customer_DetailService.IsCustomerDetailExist(customerDetailDto.National_Tax_Number))
            {
                return BadRequest(ErrorCodes.BadRequestError(
                         "(Customer Detail already exists",
                         $"The Customer with Tax Number '{customerDetailDto.National_Tax_Number}' is already registered."
                  ));
            }

            var customerD = mapper.Map<TmX_Customer_Detail>(customerDetailDto);

            uow.Customer_DetailService.Add(customerD);

            await uow.SaveAsync();
            return Ok(customerD);
        }

        [HttpPut("updateCustomerDetail")]
        public async Task<IActionResult> UpdateCustomerDetail(TmX_Customer_DetailDto customerDetailDto)
        {
            if (await uow.Customer_DetailService.IsCustomerDetailExistInUpdate(customerDetailDto.National_Tax_Number, customerDetailDto.Customer_Detail_ID))
            {
                
                return BadRequest(ErrorCodes.BadRequestError(
                        "Customer Detail already exists",
                        $"The Customer Detail with tax number '{customerDetailDto.National_Tax_Number}' is already registered."
                 ));
            }

            var customerDetailFromDb = await uow.Customer_DetailService.Get(customerDetailDto.Customer_Detail_ID);

            if (customerDetailFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            mapper.Map(customerDetailDto, customerDetailFromDb);

            UHelper.UpdateTimestamp(customerDetailDto);

            await uow.SaveAsync();
            return Ok(customerDetailDto);
        }

        [HttpPost("deleteCustomerDetail")]
        public async Task<IActionResult> DeletecustomerDetail(DeleteKeyPairDto deleteKeyPairDto)
        {
            if (deleteKeyPairDto.Id == 0)
            {
                return BadRequest("Invalid integer ID provided.");
            }

            var customerDetailFromDb = await uow.Customer_DetailService.Get(deleteKeyPairDto.Id);
            if (customerDetailFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }
			UHelper.SoftDelete(customerDetailFromDb);
            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }


    }
}
