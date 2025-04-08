using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Helper;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CorporatePortalApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : Controller
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
				return NotFound(ErrorCodes.NotFound());
			}

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.TmX_LookupService.GetAllLookupAsync();
            if (entries == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}
            return Ok(entries);
        }

        [HttpPost("addLookup")]
        public async Task<IActionResult> AddLookup(TmX_LookupDto LookupDto)
        {
            if (await uow.TmX_LookupService.IsLookupExist(LookupDto.Lookup_Name))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						 "Lookup already exists",
						 $"The Lookup '{LookupDto.Lookup_Name}' is already registered."
				  ));
			}

            var lookup = mapper.Map<TmX_Lookup>(LookupDto);

            uow.TmX_LookupService.Add(lookup);

            await uow.SaveAsync();
            return Ok(lookup);
        }

        [HttpPut("updateLookup")]
        public async Task<IActionResult> UpdateLookup(TmX_LookupDto LookupDto)
        {
           if (await uow.TmX_LookupService.IsLookupExistInUpdate(LookupDto.Lookup_Name, LookupDto.Lookup_ID))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						"Lookup already exists",
						$"The Lookup '{LookupDto.Lookup_Name}' is already registered."
				 ));
			}

            var LookupFromDb = await uow.TmX_LookupService.Get(LookupDto.Lookup_ID);

            if (LookupFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            mapper.Map(LookupDto, LookupFromDb);

			UHelper.UpdateTimestamp(LookupDto);

			await uow.SaveAsync();
            return Ok(LookupDto);
        }



        [HttpPost("deleteLookup")]
        public async Task<IActionResult> DeleteLookup(DeleteKeyPairDto deleteKeyPairDto)
        {
            var LookupFromDb = await uow.TmX_LookupService.Get(deleteKeyPairDto.Id);

            if (LookupFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(LookupFromDb);

			await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }
    }
}
