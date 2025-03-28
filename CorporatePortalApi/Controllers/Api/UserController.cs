using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Helper;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CorporatePortalApi.Controllers.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : Controller
	{
		private IUnitOfWork uow;
		private readonly IMapper mapper;
		public UserController(IUnitOfWork uow, IMapper mapper)
		{
			this.uow = uow;
			this.mapper = mapper;
		}

		[HttpGet("get/{id}")]
		public async Task<IActionResult> Get(string id)
		{
			var entry = await uow.UserService.Get(id);

			if (entry == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			return Ok(entry);
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> GetAll()
		{
			var users = await uow.UserService.GetAllUsersAsync();
			if (users == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}
			return Ok(users);
		}

		[HttpPost("addUsers")]
		public async Task<IActionResult> AddUsers(TmX_UserDto userDto)
		{
			if (await uow.UserService.IsUserExist(userDto.First_Name, userDto.Last_Name))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"User already exists",
						$"The user '{userDto.First_Name} {userDto.Last_Name}' is already registered."
				 ));
			}

			var usr = mapper.Map<TmX_User>(userDto);

			uow.UserService.Add(usr);

			await uow.SaveAsync();
			return Ok(usr);
		}

		[HttpPut("updateUsers")]
		public async Task<IActionResult> UpdateUsers(TmX_UserDto userDto)
		{
			if (await uow.UserService.IsUserExistInUpdate(userDto.First_Name, userDto.Last_Name, userDto.User_ID))
			{
				return BadRequest(ErrorCodes.BadRequestError(
						"User already exists",
						$"The user '{userDto.First_Name} {userDto.Last_Name}' is already registered with ID {userDto.User_ID}."
				 ));
			}

			var userFromDb = await uow.UserService.Get(userDto.User_ID);

			if (userFromDb == null)
			{
				return NotFound(ErrorCodes.NotFound());
			}

			mapper.Map(userDto, userFromDb);

			UHelper.UpdateTimestamp(userDto);

			await uow.SaveAsync();
			return Ok(userDto);
		}

		//[HttpPost("deleteUsers")]
		//public async Task<IActionResult> DeleteUsers(DeleteKeyPairDto deleteKeyPairDto)
		//{
		//	var userFromDb = await uow.UserService.Get(Guid.Parse((deleteKeyPairDto.Id).ToString()));

		//	if (userFromDb == null)
		//	{
		//		return NotFound(ErrorCodes.NotFound());
		//	}

		//	UHelper.SoftDelete(userFromDb);

		//	await uow.SaveAsync();

		//	return Ok(deleteKeyPairDto);
		//}
	}
}
