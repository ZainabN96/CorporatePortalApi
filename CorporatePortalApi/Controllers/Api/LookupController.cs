using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CorporatePortalApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {

        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public LookupController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;   
        }


        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.TmX_LookupService.Get(id);

            if (entry == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Lookup not found";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.TmX_LookupService.GetAllLookupAsync();
            if (entries == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Lookups not found";
                return BadRequest(apiError);
            }
            return Ok(entries);
        }

        [HttpPost("addLookup")]
        public async Task<IActionResult> AddLookup(TmX_LookupDto LookupDto)
        {
            if (await uow.TmX_LookupService.IsLookupExist(LookupDto.Lookup_Name))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Lookup is already exist";
                return BadRequest(apiError);
            }

            var lookup = mapper.Map<TmX_Lookup>(LookupDto);

            uow.TmX_LookupService.Add(lookup);

            await uow.SaveAsync();
            return Ok(lookup);
        }

        [HttpPut("updateLookup")]
        public async Task<IActionResult> UpdateLookup(TmX_LookupDto LookupDto)
        {
            APIError apiError = new APIError();

         
           if (await uow.TmX_LookupService.IsLookupExistInUpdate(LookupDto.Lookup_Name, LookupDto.Lookup_ID))
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Lookup is already exist";
                return BadRequest(apiError);
            }

            var LookupFromDb = await uow.TmX_LookupService.Get(LookupDto.Lookup_ID);

            if (LookupFromDb == null)
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Lookup not found";
                return BadRequest(apiError);
            }

            mapper.Map(LookupDto, LookupFromDb);

            LookupDto.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();
            return Ok(LookupDto);
        }



        [HttpPost("deleteLookup")]
        public async Task<IActionResult> DeleteLookup(DeleteKeyPairDto deleteKeyPairDto)
        {
            var LookupFromDb = await uow.TmX_LookupService.Get(deleteKeyPairDto.Id);

            if (LookupFromDb == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Lookup not found";
                return BadRequest(apiError);
            }

            LookupFromDb.Active_Flag = false;
            LookupFromDb.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }
    }
}
