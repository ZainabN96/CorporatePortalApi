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
        [HttpPost("addUser")]
        public async Task<IActionResult> AddUser(AspNetUserDto userDto)
        {
            // Check if the user already exists
            if (await uow.AspNetUserService.IsUserExist(userDto.Email))
            {
                APIError apiError = new APIError
                {
                    ErrorCode = BadRequest().StatusCode,
                    ErrorMessage = "User with this email already exists"
                };
                return BadRequest(apiError);
            }

            // Map DTO to model
            var user = mapper.Map<AspNetUser>(userDto);
            var address = mapper.Map<TmX_Address>(userDto);
            var tenant = mapper.Map<TmX_Tenant>(userDto);
            var local = mapper.Map<TmX_Locale>(userDto);
            var time = mapper.Map<TmX_Time_Zone>(userDto);
            // Add user and address
            uow.AspNetUserService.AddUser(user, address, tenant, local, time);

            // Save changes
            await uow.SaveAsync();

            return Ok(user);
        }


    }
}
