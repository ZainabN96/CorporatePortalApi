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
        [HttpPost("addProduct")]
        public async Task<IActionResult> AddProduct(TmX_ProductDto Product)
        {
            if (await uow.TmX_ProductService.IsTmX_ProductExist(Product.Product_Name))
            {
                APIError apiError = new APIError();
                apiError.ErrorCode = BadRequest().StatusCode;
                apiError.ErrorMessage = "Product is already exist";
                return BadRequest(apiError);
            }

            var pro = mapper.Map<TmX_Product>(Product);

            uow.TmX_ProductService.Add(pro);

            await uow.SaveAsync();
            return Ok(pro);
        }

    }
}
