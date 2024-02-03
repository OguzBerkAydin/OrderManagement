using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultAboutDto>().ReverseMap();
            CreateMap<Booking, CreateAboutDto>().ReverseMap();
            CreateMap<Booking, UpdateAboutDto>().ReverseMap();
            CreateMap<Booking, GetAboutDto>().ReverseMap();
        }
    }
}
