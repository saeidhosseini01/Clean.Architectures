using AutoMapper;
using Clean.Architecture.Application.Dtos.Common;
using Clean.Architecture.Application.Users.Dtos;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Entities.User;


namespace Clean.Architecture.Application.Mappings
{
    public class MappingsProfile:Profile
    {
        public MappingsProfile()
        {
                
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Const, ConstDto>().ReverseMap();
        }
    }
}
