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
    public class OrganizationController : ControllerBase
    {
        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public OrganizationController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.TmX_CorporateService.Get(id);

            if (entry == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "TmX_Corporate not found";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.TmX_CorporateService.GetTmX_CorporateAsync();

            return Ok(entries);
        }

        [HttpPost("addOrganization")]
        public async Task<IActionResult> AddOrganization(TmX_CorporateDto TmX_CorporateDto)
        {
            if (await uow.TmX_CorporateService.IsTmX_CorporateExist(TmX_CorporateDto.Name))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "TmX_Corporate name already exist";
                return BadRequest(apiError);
            }

            var depart = mapper.Map<TmX_Corporate>(TmX_CorporateDto);
            uow.TmX_CorporateService.Add(depart);
            await uow.SaveAsync();
            return Ok(depart);
        }

        [HttpPut("updateOrganization")]
        public async Task<IActionResult> UpdateOrganization(TmX_CorporateDto TmX_CorporateDto)
        {
            APIError apiError = new APIError();

            if (await uow.TmX_CorporateService.IsTmX_CorporateExistInUpdate(TmX_CorporateDto.Name, TmX_CorporateDto.Id))
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "TmX_Corporate name already exist";
                return BadRequest(apiError);
            }

            var TmX_CorporateFromDb = await uow.TmX_CorporateService.Get(TmX_CorporateDto.Id);

            if (TmX_CorporateFromDb == null)
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "TmX_Corporate not found";
                return BadRequest(apiError);
            }

            mapper.Map(TmX_CorporateDto, TmX_CorporateFromDb);

            TmX_CorporateFromDb.IsActive = true;
            TmX_CorporateFromDb.IsDelete = false;
            TmX_CorporateFromDb.LastUpdatedOn = DateTime.Now;
            await uow.SaveAsync();
            return Ok(TmX_CorporateDto);
        }

        
    }  
}
