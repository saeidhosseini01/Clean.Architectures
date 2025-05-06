using AutoMapper;
using Clean.Architecture.Application.Dtos;
using Clean.Architecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Mappings
{
    public class MappingsProfile:Profile
    {
        public MappingsProfile()
        {
                
        CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
