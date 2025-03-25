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
	public class AspNetRoleController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;

		public AspNetRoleController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(string id)
		{
			var entry = await uow.AspNetRoleService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}


		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.AspNetRoleService.GetAllRoleAsync();

			return Ok(entries);
		}

		[HttpPost("addRole")]
		public async Task<IActionResult> AddRole(AspNetRoleDto RoleDto)
		{
			if (await uow.AspNetRoleService.IsRoleExist(RoleDto.Name))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Role already exists",
						$"The role '{RoleDto.Name}' is already registered."
				));
			}

			var role = mapper.Map<AspNetRole>(RoleDto);

			uow.AspNetRoleService.Add(role);

			await uow.SaveAsync();
			return Ok(role);
		}

		[HttpPut("updateRole")]
		public async Task<IActionResult> UpdateRole(AspNetRoleDto RoleDto)
		{
			if (await uow.AspNetRoleService.IsRoleExistInUpdate(RoleDto.Name, RoleDto.Id))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"Role already exists",
						$"The role '{RoleDto.Name}' is already registered with ID {RoleDto.Id}."
				));
			}

			var RoleFromDb = await uow.AspNetRoleService.Get(RoleDto.Id);

			if (RoleFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(RoleDto, RoleFromDb);

			await uow.SaveAsync();
			return Ok(RoleDto);
		}

		/*[HttpPost("deleteRole")]
		public async Task<IActionResult> DeleteRole(DeleteKeyPairDto deleteKeyPairDto)
		{
			var RoleFromDb = await uow.AspNetRoleService.Get(deleteKeyPairDto.Id);

			if (RoleFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			await uow.SaveAsync();

			return Ok(deleteKeyPairDto);
		}*/
	}
}
