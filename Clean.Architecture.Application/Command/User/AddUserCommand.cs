using Clean.Architecture.Domain.ValueObject.User;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Application.Dtos.User;

namespace Clean.Architecture.Application.Command.User
{
    public class AddUserCommand(Id id, Name name, Family family, Age age) : IRequest<UserDto>
    {
        public string Name { get; set; } = name;
        public string Family { get; set; } = family;
        public double Age { get; set; } = age;
        public Guid Id { get; set; } = id;



    }
}
