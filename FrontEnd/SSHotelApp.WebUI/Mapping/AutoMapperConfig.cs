using AutoMapper;
using SSHotelApp.EntityLayer.Concrete;
using SSHotelApp.WebUI.Dtos.LoginDto;
using SSHotelApp.WebUI.Dtos.RegisterDto;
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

            CreateMap<CreateNewUserDto, AppUser>();

            CreateMap<LoginUserDto, AppUser>();
        }
    }
}
