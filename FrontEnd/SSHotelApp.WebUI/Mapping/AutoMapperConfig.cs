using AutoMapper;
using SSHotelApp.EntityLayer.Concrete;
using SSHotelApp.WebUI.Dtos.ServiceDto;

namespace SSHotelApp.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>();
            CreateMap<CreateServiceDto, Service>();
            CreateMap<UpdateServiceDto, Service>();
        }
    }
}
