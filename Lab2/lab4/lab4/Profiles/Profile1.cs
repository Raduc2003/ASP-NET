using AutoMapper;
using lab4.Entities;

namespace lab4.Profiles
{
    public class Profile1:Profile
    {
        public Profile1() 
        {
            CreateMap<Stire, StireDto>();
            CreateMap<PostStireDto,Stire>();
        
        
        }
    }
}
