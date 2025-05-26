using Clean.Architecture.Application.Dtos.User;
using Clean.Architecture.Domain.ValueObject.User;
using MediatR;

namespace Clean.Architecture.Application.Command.User
{
    public class UpdateUserCommand(Id id, Name name, Family family, Age age) : IRequest<UserDto>
    {
        public string Name { get; set; } = name;
        public string Family { get; set; } = family;
        public double Age { get; set; } = age;
        public Guid Id { get; set; } = id;



    }
}
