using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorporatePortalApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspNetUserRoleController : ControllerBase
    {

        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public AspNetUserRoleController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.AspNetUserRolesService.Get(id);

            if (entry == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "AspNetUserRole not found!";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }

        [HttpGet("get/{userid}")]
        public async Task<IActionResult> GetWithUserId(int userId)
        {
            var entry = await uow.AspNetUserRolesService.GetWithUserId(userId);

            if (entry == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "AspNetUserRole not found for this UserId!";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }


        [HttpGet("get/{roleId}")]
        public async Task<IActionResult> GetWithRoleId(string roleId)
        {
            var entry = await uow.AspNetUserRolesService.GetWithRoleId(roleId);

            if (entry == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "AspNetUserRole not found for this RoleId!";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.AspNetUserRolesService.GetAspNetUserRoleAsync();

            return Ok(entries);
        }

        [HttpPost("addUserRole")]
        public async Task<IActionResult> Add(AspNetUserRoleDto userRoleDto)
        {
            if (await uow.AspNetUserRolesService.IsAspNetUserRoleExist(userRoleDto.RoleId))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "UserRole is already exist";
                return BadRequest(apiError);
            }

           var userRole = mapper.Map<AspNetUserRole>(userRoleDto);
             
            uow.AspNetUserRolesService.Add(userRole);

            await uow.SaveAsync();
            return Ok(userRole);
        }




    }
}
