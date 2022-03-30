using AutoMapper;
using User.Data.getUser;
using User.Data.UserData;

namespace SplitR.MapProfile
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<sUserdata, addUser>().ReverseMap();
            CreateMap<sUserdata, viewUser>().ReverseMap();
        }

    }
}
