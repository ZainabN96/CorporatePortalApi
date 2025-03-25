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
    public class OrganizationController : Controller
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
            var entry = await uow.CorporateService.Get(id);

            if (entry == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.CorporateService.GetOrganizationAsync();

            return Ok(entries);
        }

        [HttpPost("addOrganization")]
        public async Task<IActionResult> AddOrganization(TmX_CorporateDto OrganizationDto)
        {
            if (await uow.CorporateService.IsCorporateExist(OrganizationDto.Corporate_Name))
            {
				return BadRequest(ErrorCodes.BadRequestError(
					   "Organization already exists",
					   $"The organization '{OrganizationDto.Corporate_Name}' is already registered."
				));
			}

            var org = mapper.Map<TmX_Corporate>(OrganizationDto);
            
            uow.CorporateService.Add(org);
            
            await uow.SaveAsync();
            return Ok(org);
        }


		[HttpPut("updateOrganization")]
        public async Task<IActionResult> UpdateOrganization(TmX_CorporateDto OrganizationDto)
        {
            if (await uow.CorporateService.IsCorporateExistInUpdate(OrganizationDto.Corporate_Name, OrganizationDto.Corporate_Id))
            {
				return BadRequest(ErrorCodes.BadRequestError(
	                   "Organization already exists",
	                   $"The organization '{OrganizationDto.Corporate_Name}' is already registered with ID {OrganizationDto.Corporate_Id}."
                ));
			}

            var OrganizationFromDb = await uow.CorporateService.Get(OrganizationDto.Corporate_Id);

            if (OrganizationFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            mapper.Map(OrganizationDto, OrganizationFromDb);
			UHelper.UpdateTimestamp(OrganizationDto);
            
            await uow.SaveAsync();
            return Ok(OrganizationDto);
        }

        [HttpPost("deleteOrgianization")]
        public async Task<IActionResult> DeleteOrgianization(DeleteKeyPairDto deleteKeyPairDto)
        {
            var OrgFromDb = await uow.CorporateService.Get(deleteKeyPairDto.Id);

            if (OrgFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

			UHelper.SoftDelete(OrgFromDb);

			await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }

    }  
}
