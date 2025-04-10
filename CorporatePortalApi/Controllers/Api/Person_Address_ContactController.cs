using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Helper;
using CorporatePortalApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorporatePortalApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class Person_Address_ContactController : ControllerBase
    {
        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public Person_Address_ContactController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.Person_Address_ContactService.Get(id);

            if (entry == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            return Ok(entry);
        }


        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.Person_Address_ContactService.GetAllPersonAddressContactAsync();
            if (entries == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }
            return Ok(entries);
        }

        [HttpPost("addPersonAddressContact")]
        public async Task<IActionResult> AddPersonAddressContact(TmX_Person_Address_ContactDto person_Address_ContactDto)
        {
            if (await uow.Person_Address_ContactService.IsPersonAddressContactExist(person_Address_ContactDto.Contact_Number))
            {
                return BadRequest(ErrorCodes.BadRequestError(
                         "Person Address Contact already exists",
                         $"The Contact '{person_Address_ContactDto.Contact_Number}' is already registered."
                  ));
            }

            var AddContact = mapper.Map<TmX_Person_Address_Contact>(person_Address_ContactDto);

            uow.Person_Address_ContactService.Add(AddContact);

            await uow.SaveAsync();
            return Ok(AddContact);
        }

        [HttpPut("updatePersonAddressContact")]
        public async Task<IActionResult> UpdatePersonAddressContact(TmX_Person_Address_ContactDto PersonAddressContactDto)
        {
            if (await uow.Person_Address_ContactService.IsPersonAddressContactExistInUpdate(PersonAddressContactDto.Contact_Number, PersonAddressContactDto.Person_Address_Contact_ID))
            {
                return BadRequest(ErrorCodes.BadRequestError(
                        "PersonAddressContact already exists",
                        $"The PersonAddressContact '{PersonAddressContactDto.Contact_Number}' is already registered."
                 ));
            }

            var PersonAddressContactFromDb = await uow.Person_Address_ContactService.Get(PersonAddressContactDto.Person_Address_Contact_ID);

            if (PersonAddressContactFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            mapper.Map(PersonAddressContactDto, PersonAddressContactFromDb);

            UHelper.UpdateTimestamp(PersonAddressContactDto);

            await uow.SaveAsync();
            return Ok(PersonAddressContactDto);
        }

        [HttpPost("deletePersonAddressContact")]
        public async Task<IActionResult> DeletePersonAddressContact(DeleteKeyPairDto deleteKeyPairDto)
        {
            if (deleteKeyPairDto.Id == 0)
            {
                return BadRequest("Invalid integer ID provided.");
            }

            var PersonAddressContactFromDb = await uow.Person_Address_ContactService.Get(deleteKeyPairDto.Id);
            if (PersonAddressContactFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            PersonAddressContactFromDb.Active_Flag = false;
            PersonAddressContactFromDb.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }

    }
}
