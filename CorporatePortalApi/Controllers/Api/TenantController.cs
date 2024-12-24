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
	public class TenantController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public TenantController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
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
				APIError apiError = new APIError();
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Tenant is already exist";
				return BadRequest(apiError);
			}

			var tenant = mapper.Map<TmX_Tenant>(TenantDto);

			uow.TenantService.Add(tenant);

			await uow.SaveAsync();
			return Ok(tenant);
		}

		[HttpPut("updateTenant")]
		public async Task<IActionResult> UpdateTenant(TmX_TenantDto TenantDto)
		{
			APIError apiError = new APIError();

			if (await uow.TenantService.IsTenantExistInUpdate(TenantDto.Tenant_Name, TenantDto.Tenant_ID))
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Tenant already exists.";
				return BadRequest(apiError);
			}

			var TenantFromDb = await uow.TenantService.Get(TenantDto.Tenant_ID);

			if (TenantFromDb == null)
			{
				apiError.ErrorCode = BadRequest().StatusCode;
				apiError.ErrorMessage = "Tenant not found!";
				return BadRequest(apiError);
			}

			mapper.Map(TenantDto, TenantFromDb);

			TenantDto.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();
			return Ok(TenantDto);
		}

		[HttpPost("deleteTenant")]
		public async Task<IActionResult> DeleteTenant(DeleteKeyPairDto deleteKeyPairDto)
		{
			var TenantFromDb = await uow.TenantService.Get(deleteKeyPairDto.Id);

			if (TenantFromDb == null)
			{
				APIError apiError = new APIError();
				apiError.ErrorCode = NoContent().StatusCode;
				apiError.ErrorMessage = "Tenant not found!";
				return BadRequest(apiError);
			}

			TenantFromDb.Active_Flag = false;
			TenantFromDb.Last_Updated_Date = DateTime.Now;

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}
	}
}
