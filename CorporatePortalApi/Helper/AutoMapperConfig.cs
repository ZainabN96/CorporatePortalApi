using AutoMapper;
using CorporatePortalApi.Dtos;
using CorporatePortalApi.Models;

namespace CorporatePortalApi.Helper
{
    public class AutoMapperConfig
    {
        public static IMapper RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TmX_Corporate, TmX_CorporateDto>().ReverseMap();
                cfg.CreateMap<TmX_Product, TmX_ProductDto>().ReverseMap();
                cfg.CreateMap<TmX_Bank, TmX_BankDto>().ReverseMap();
                
            });

            return config.CreateMapper();
        }

    }
}
