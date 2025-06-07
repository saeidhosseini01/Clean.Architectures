using Clean.Architecture.Domain.ValueObject.User;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Domain.ValueObject.Genaric;
using Clean.Architecture.Application.Users.Dtos;

namespace Clean.Architecture.Application.Users.Command
{
    public class AddUserCommand : IRequest<UserDto>
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Family { get; }
        public double Age { get; }

        public AddUserCommand(Guid id, string name, string family, double age)
        {
            Id = id;
            Name = name;
            Family = family;
            Age = age;
        }
    }

}
