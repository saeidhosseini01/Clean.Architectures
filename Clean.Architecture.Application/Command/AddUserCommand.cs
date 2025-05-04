using Clean.Architecture.Application.Dtos;
using Clean.Architecture.Domain.ValueObject.User;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Command
{
    public class AddUserCommand(Id id, Name name, Family family, Age age) :IRequest<UserDto>
    {
        public string Name { get; set; } = name;
        public string Family { get; set; } = family;
        public double Age { get; set; } = age;
        public string Id { get; set; } = id;



    }
}
