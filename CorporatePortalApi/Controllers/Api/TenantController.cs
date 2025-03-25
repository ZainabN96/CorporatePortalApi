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
	public class TenantController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public TenantController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.TenantService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}


		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.TenantService.GetAllTenantAsync();

			return Ok(entries);
		}

		[HttpPost("addTenant")]
		public async Task<IActionResult> AddTenant(TmX_TenantDto TenantDto)
		{
			if (await uow.TenantService.IsTenantExist(TenantDto.Tenant_Name))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Tenant already exists",
						$"The Tenant '{TenantDto.Tenant_Name}' is already registered."
				 ));
			}

			var tenant = mapper.Map<TmX_Tenant>(TenantDto);

			uow.TenantService.Add(tenant);

			await uow.SaveAsync();
			return Ok(tenant);
		}

		[HttpPut("updateTenant")]
		public async Task<IActionResult> UpdateTenant(TmX_TenantDto TenantDto)
		{
			if (await uow.TenantService.IsTenantExistInUpdate(TenantDto.Tenant_Name, TenantDto.Tenant_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Tenant already exists",
						$"The Tenant '{TenantDto.Tenant_Name}' is already registered with ID {TenantDto.Tenant_ID}."
				 ));
			}

			var TenantFromDb = await uow.TenantService.Get(TenantDto.Tenant_ID);

			if (TenantFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(TenantDto, TenantFromDb);

			UHelper.UpdateTimestamp(TenantDto);
			TenantFromDb.Tenant_Blocked_Flag = false;

			await uow.SaveAsync();
			return Ok(TenantDto);
		}

		[HttpPost("deleteTenant")]
		public async Task<IActionResult> DeleteTenant(DeleteKeyPairDto deleteKeyPairDto)
		{
			var TenantFromDb = await uow.TenantService.Get(deleteKeyPairDto.Id);

			if (TenantFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			TenantFromDb.Tenant_Blocked_Flag = true;
			UHelper.SoftDelete(TenantFromDb);

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
