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
    public class Person_National_IdentifierController : ControllerBase
    {


        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public Person_National_IdentifierController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.Person_National_IdentifierService.Get(id);

            if (entry == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.Person_National_IdentifierService.GetAllPersonNationalIdentifierAsync();
            if (entries == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }
            return Ok(entries);
        }

        [HttpPost("addPersonNationalIdentifier")]
        public async Task<IActionResult> AddPersonNationalIdentifier(TmX_Person_National_IdentifierDto PersonNationalIDto)
        {
            if (await uow.Person_National_IdentifierService.IsNationalIdentifierExist(PersonNationalIDto.Person_National_Identifier_ID))
            {
                return BadRequest(ErrorCodes.BadRequestError(
                         "Person National Identifier already exists",
                         $"The Person National Identifier '{PersonNationalIDto.Person_National_Identifier_ID}' is already registered."
                  ));
            }

            var PersonNationalI = mapper.Map<TmX_Person_National_Identifier>(PersonNationalIDto);

            uow.Person_National_IdentifierService.Add(PersonNationalI);

            await uow.SaveAsync();
            return Ok(PersonNationalI);
        }
        [HttpPut("updatePersonNationalIdentifier")]
        public async Task<IActionResult> UpdatePersonNationalIdentifier(TmX_Person_National_IdentifierDto PersonNationalIDto)
        {
            if (await uow.Person_National_IdentifierService.IsNationalIdentifierExistInUpdate(PersonNationalIDto.Person_National_Identifier_ID, PersonNationalIDto.Person_ID))
            {
                return BadRequest(ErrorCodes.BadRequestError(
                        "Person National Identifier already exists",
                        $"The PersonNationalIdentifier '{PersonNationalIDto.Person_National_Identifier_ID}' is already registered."
                 ));
            }

            var PersonNationalIFromDb = await uow.Person_National_IdentifierService.Get(PersonNationalIDto.Person_National_Identifier_ID);

            if (PersonNationalIFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            mapper.Map(PersonNationalIDto, PersonNationalIFromDb);

            UHelper.UpdateTimestamp(PersonNationalIDto);

            await uow.SaveAsync();
            return Ok(PersonNationalIDto);
        }

        [HttpPost("deletePersonNationalIdentifier")]
        public async Task<IActionResult> DeletePersonNationalI(DeleteKeyPairDto deleteKeyPairDto)
        {
            if (deleteKeyPairDto.Id == 0)
            {
                return BadRequest("Invalid integer ID provided.");
            }

            var PersonNationalIFromDb = await uow.Person_National_IdentifierService.Get(deleteKeyPairDto.Id);
            if (PersonNationalIFromDb == null)
            {
                return NotFound(ErrorCodes.NotFound());
            }

            PersonNationalIFromDb.Active_Flag = false;
            PersonNationalIFromDb.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }




    }
}
