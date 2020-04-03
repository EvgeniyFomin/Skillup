using AutoMapper;
using RealWorldAPI.Controllers.Resources;
using RealWorldAPI.Models;

namespace RealWorldAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarResource>();
            CreateMap<ContactInfo, ContactResource>();
        }
    }
}
