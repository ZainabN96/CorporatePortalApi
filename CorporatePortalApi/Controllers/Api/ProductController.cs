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
    public class ProductController : Controller
    {
        private IUnitOfWork uow;
        private readonly IMapper mapper;

        public ProductController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entry = await uow.ProductService.Get(id);

            if (entry == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Product not found";
                return BadRequest(apiError);
            }

            return Ok(entry);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var entries = await uow.ProductService.GetProductAsync();

            return Ok(entries);
        }

        [HttpPost("addProduct")]
        public async Task<IActionResult> AddProduct(TmX_ProductDto Product)
        {
            if (await uow.ProductService.IsProductExist(Product.Product_Name))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Product is already exist";
                return BadRequest(apiError);
            }

            var pro = mapper.Map<TmX_Product>(Product);

            uow.ProductService.Add(pro);

            await uow.SaveAsync();
            return Ok(pro);
        }

        [HttpPut("updateProduct")]
        public async Task<IActionResult> UpdateProduct(TmX_ProductDto ProductDto)
        {
            APIError apiError = new APIError();

            if (await uow.ProductService.IsProductExistInUpdate(ProductDto.Product_Name, ProductDto.Product_ID))
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Product is already exist";
                return BadRequest(apiError);
            }

            var ProductFromDb = await uow.CorporateService.Get(ProductDto.Product_ID);

            if (ProductFromDb == null)
            {
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Corporate not found";
                return BadRequest(apiError);
            }

            mapper.Map(ProductDto, ProductFromDb);

            ProductDto.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();
            return Ok(ProductDto);
        }

        [HttpPost("deleteProduct")]
        public async Task<IActionResult> DeleteProduct(DeleteKeyPairDto deleteKeyPairDto)
        {
            var OrgFromDb = await uow.CorporateService.Get(deleteKeyPairDto.Id);

            if (OrgFromDb == null)
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = NoContent().StatusCode;
                apiError.ErrorMessage = "Orgianization not found";
                return BadRequest(apiError);
            }

            OrgFromDb.Active_Flag = false;
            OrgFromDb.Last_Updated_Date = DateTime.Now;

            await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }

    }
}
