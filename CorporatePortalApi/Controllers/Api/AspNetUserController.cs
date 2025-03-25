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
    public class AspNetUserController : Controller
    {
        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public AspNetUserController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var entry = await uow.AspNetUserService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var entries = await uow.AspNetUserService.GetAspNetUserAsync();

			return Ok(entries);
		}

		[HttpPost("addUser")]
        public async Task<IActionResult> AddUser(AspNetUserDto userDto)
        {
            // Check if the user already exists
            if (await uow.AspNetUserService.IsUserExist(userDto.Email))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						"NetUser already exists",
						$"The email: '{userDto.Email}' is already registered."
				));
			}

            var user = mapper.Map<AspNetUser>(userDto);
            var address = mapper.Map<TmX_Address>(userDto);
            var tenant = mapper.Map<TmX_Tenant>(userDto);
            var local = mapper.Map<TmX_Locale>(userDto);
            var time = mapper.Map<TmX_Time_Zone>(userDto);
            // Add user and address
            uow.AspNetUserService.AddUser(user, address, tenant, local, time);

            await uow.SaveAsync();

            return Ok(user);
        }

		[HttpPut("updateUser")]
		public async Task<IActionResult> UpdateUser(AspNetUserDto userDto)
		{
			var user = mapper.Map<AspNetUser>(userDto);
			var address = mapper.Map<TmX_Address>(userDto);
			var tenant = mapper.Map<TmX_Tenant>(userDto);
			var locale = mapper.Map<TmX_Locale>(userDto);
			var time = mapper.Map<TmX_Time_Zone>(userDto);

			uow.AspNetUserService.UpdateUser(user, address, tenant, locale, time);

			await uow.SaveAsync();

			return Ok(user);
		}

		[HttpPost("deleteAspNetUser")]
		public async Task<IActionResult> DeleteAspNetUser(DeleteKeyPairDto deleteKeyPairDto)
		{
			var userFromDb = await uow.AspNetUserService.Get(deleteKeyPairDto.Id);

			if (userFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			try
			{
				uow.AspNetUserService.DeleteUser(userFromDb);

				await uow.SaveAsync();

				return Ok(new { message = "User and associated data successfully deleted." });
			}
			catch (Exception ex)
			{
				return StatusCode(500, ErrorCodes.ServerError(ex.Message));
			}
		}
	}
}
