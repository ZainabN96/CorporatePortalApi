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
                //cfg.CreateMap<Department, DepartmentDto>().ReverseMap();
                
            });

            return config.CreateMapper();
        }

    }
}
