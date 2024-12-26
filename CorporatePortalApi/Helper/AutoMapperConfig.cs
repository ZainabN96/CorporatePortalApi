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
                cfg.CreateMap<TmX_Currency, TmX_CurrencyDto>().ReverseMap();
                cfg.CreateMap<TmX_Tenant, TmX_TenantDto>().ReverseMap();
                cfg.CreateMap<TmX_Lookup, TmX_LookupDto>().ReverseMap();
                cfg.CreateMap<TmX_Address_Geography, TmX_Address_GeographyDto>().ReverseMap();
                cfg.CreateMap<AspNetRole, AspNetRoleDto>().ReverseMap();

            });

            return config.CreateMapper();
        }

    }
}
