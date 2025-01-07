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
                cfg.CreateMap <AspNetUserDto,TmX_Tenant>().ReverseMap();
                cfg.CreateMap<TmX_Lookup, TmX_LookupDto>().ReverseMap();
                cfg.CreateMap<TmX_Address_Geography, TmX_Address_GeographyDto>().ReverseMap();
                cfg.CreateMap<AspNetRole, AspNetRoleDto>().ReverseMap();
                cfg.CreateMap<AspNetUserDto, AspNetUser>()
                    .ForMember(dest => dest.Tenant_ID, opt => opt.MapFrom(src => src.TenantId));
                cfg.CreateMap<AspNetUserDto, TmX_Address>()
                    .ForMember(dest => dest.Address_Line_1, opt => opt.MapFrom(src => src.AddressLine1))
                    .ForMember(dest => dest.Address_Line_2, opt => opt.MapFrom(src => src.AddressLine2))
                    .ForMember(dest => dest.Address_Line_3, opt => opt.MapFrom(src => src.AddressLine3))
                    .ForMember(dest => dest.Address_Line_4, opt => opt.MapFrom(src => src.AddressLine4))
                    .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                    .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
                    .ForMember(dest => dest.Postal_Zip_Code, opt => opt.MapFrom(src => src.PostalZipCode))
                    .ForMember(dest => dest.Tenant_ID, opt => opt.MapFrom(src => src.TenantId));
                cfg.CreateMap<AspNetUserDto, TmX_Time_Zone>().ReverseMap();
                cfg.CreateMap<AspNetUserDto, TmX_Locale>().ReverseMap();
            });

            return config.CreateMapper();
        }

    }
}
