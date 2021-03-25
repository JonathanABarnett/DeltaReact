using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // <Map from, Map to>
            CreateMap<Attendee, Attendee>();
        }
    }
}