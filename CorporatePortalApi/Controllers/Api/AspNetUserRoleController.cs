﻿using AutoMapper;
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
    public class AspNetUserRoleController : Controller
    {

        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public AspNetUserRoleController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("getbyUserId/{userId}")]
        public async Task<IActionResult> GetWithUserId(int userId)
        {
            var entry = await uow.AspNetUserRolesService.GetWithUserId(userId);

            if (entry == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            return Ok(entry);
        }


        [HttpGet("getbyRoleId/{roleId}")]
        public async Task<IActionResult> GetWithRoleId(string roleId)
        {
            var entry = await uow.AspNetUserRolesService.GetWithRoleId(roleId);

            if (entry == null)
            {
				return NotFound(ErrorCodes.NotFound());
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
            if (await uow.AspNetUserRolesService.IsAspNetUserRoleExist(userRoleDto.RoleId, userRoleDto.UserId))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						"User Role already exists",
						$"The User {userRoleDto.UserId} is already registered with Role {userRoleDto.RoleId}."
				));
			}

           var userRole = mapper.Map<AspNetUserRole>(userRoleDto);
             
            uow.AspNetUserRolesService.Add(userRole);

            await uow.SaveAsync();
            return Ok(userRole);
        }
    }
}
