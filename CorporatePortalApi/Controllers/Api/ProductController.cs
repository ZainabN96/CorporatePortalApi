using AutoMapper;
using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Errors;
using CorporatePortalApi.Helper;
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
				return NotFound(ErrorCodes.NotFound());
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
				return BadRequest(ErrorCodes.BadRequestError(
						"Product already exists",
						$"The Product '{Product.Product_Name}' is already registered."
				 ));
			}

            var pro = mapper.Map<TmX_Product>(Product);

            uow.ProductService.Add(pro);

            await uow.SaveAsync();
            return Ok(pro);
        }

        [HttpPut("updateProduct")]
        public async Task<IActionResult> UpdateProduct(TmX_ProductDto ProductDto)
        {
            if (await uow.ProductService.IsProductExistInUpdate(ProductDto.Product_Name, ProductDto.Product_ID))
            {
				return BadRequest(ErrorCodes.BadRequestError(
						"Product already exists",
						$"The Product '{ProductDto.Product_Name}' is already registered."
				 ));
			}

            var ProductFromDb = await uow.ProductService.Get(ProductDto.Product_ID);

            if (ProductFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

            mapper.Map(ProductDto, ProductFromDb);

			UHelper.UpdateTimestamp(ProductDto);
			await uow.SaveAsync();
            return Ok(ProductDto);
        }

        [HttpPost("deleteProduct")]
        public async Task<IActionResult> DeleteProduct(DeleteKeyPairDto deleteKeyPairDto)
        {
            var ProFromDb = await uow.ProductService.Get(deleteKeyPairDto.Id);

            if (ProFromDb == null)
            {
				return NotFound(ErrorCodes.NotFound());
			}

			UHelper.SoftDelete(ProFromDb);

			await uow.SaveAsync();

            return Ok(deleteKeyPairDto);
        }

    }
}
