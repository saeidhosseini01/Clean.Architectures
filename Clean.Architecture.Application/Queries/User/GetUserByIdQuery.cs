using Clean.Architecture.Application.Dtos.User;
using MediatR;

namespace Clean.Architecture.Application.Queries.User
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
