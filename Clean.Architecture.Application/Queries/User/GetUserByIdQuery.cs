using Clean.Architecture.Application.Dtos.User;
using MediatR;

namespace Clean.Architecture.Application.Queries.User
{
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public readonly string id;

        public GetUserByIdQuery(string id)
        {
            this.id = id;
        }
    }

}
