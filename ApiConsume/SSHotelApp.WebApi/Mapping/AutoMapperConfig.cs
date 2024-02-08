using AutoMapper;
using SSHotelApp.DTOLayer.Dtos.RoomDto;
using SSHotelApp.EntityLayer.Concrete;

namespace SSHotelApp.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<RoomUpdateDto, Room>();
        }
    }
}
