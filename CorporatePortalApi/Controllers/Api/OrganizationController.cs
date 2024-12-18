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
        public async Task<IActionResult> AddOrganization(TmX_CorporateDto OrganizationDto)
        {
            if (await uow.TmX_CorporateService.IsTmX_CorporateExist(OrganizationDto.Corporate_Name))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Organization is already exist";
                return BadRequest(apiError);
            }

            var org = mapper.Map<TmX_Corporate>(OrganizationDto);
            
            uow.TmX_CorporateService.Add(org);
            
            await uow.SaveAsync();
            return Ok(org);
        }

        [HttpPut("updateOrganization")]
        public async Task<IActionResult> UpdateOrganization(TmX_CorporateDto OrganizationDto)
        {
            APIError apiError = new APIError();

            if (await uow.TmX_CorporateService.IsTmX_CorporateExistInUpdate(OrganizationDto.Corporate_Name, OrganizationDto.Corporate_Id))
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Organization is already exist";
                return BadRequest(apiError);
            }

            var OrganizationFromDb = await uow.TmX_CorporateService.Get(OrganizationDto.Corporate_Id);

            if (OrganizationFromDb == null)
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "TmX_Corporate not found";
                return BadRequest(apiError);
            }

            mapper.Map(OrganizationDto, OrganizationFromDb);
            
            OrganizationDto.Last_Updated_Date = DateTime.Now;
            
            await uow.SaveAsync();
            return Ok(OrganizationDto);
        }

        
    }  
}
