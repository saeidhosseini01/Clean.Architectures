using Clean.Architecture.Application.Dtos.User;
using MediatR;

namespace Clean.Architecture.Application.Queries
{
    public class GetUserByIdGuery : IRequest<UserDto>
    {
        public readonly string id;

        public GetUserByIdGuery(string id)
        {
            this.id = id;
        }
    }
    
}
