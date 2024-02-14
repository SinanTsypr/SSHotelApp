using AutoMapper;
using SSHotelApp.EntityLayer.Concrete;
using SSHotelApp.WebUI.Dtos.AboutDto;
using SSHotelApp.WebUI.Dtos.BookingDto;
using SSHotelApp.WebUI.Dtos.ContactDto;
using SSHotelApp.WebUI.Dtos.GuestDto;
using SSHotelApp.WebUI.Dtos.LoginDto;
using SSHotelApp.WebUI.Dtos.RegisterDto;
using SSHotelApp.WebUI.Dtos.RoomDto;
using SSHotelApp.WebUI.Dtos.ServiceDto;
using SSHotelApp.WebUI.Dtos.SubscribeDto;

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

            CreateMap<ResultAboutUsDto, AboutUs>();
            CreateMap<UpdateAboutUsDto, AboutUs>();

            CreateMap<CreateSubscribeDto, Subscribe>();

            CreateMap<CreateBookingDto, Booking>();
            CreateMap<ApproveBookingDto, Booking>();

            CreateMap<CreateContactDto, Contact>();

            CreateMap<CreateRoomDto, Room>();
            CreateMap<UpdateRoomDto, Room>();
            CreateMap<ResultRoomDto, Room>();

            CreateMap<CreateGuestDto, Guest>();
            CreateMap<UpdateGuestDto, Guest>();
        }
    }
}
