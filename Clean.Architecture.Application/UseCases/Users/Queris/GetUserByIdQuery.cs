using Clean.Architecture.Application.Users.Dtos;
using MediatR;













namespace Clean.Architecture.Application.Users.
{
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public readonly Guid id;

        public GetUserByIdQuery(Guid id)
        {
            this.id = id;
        }
    }

}
