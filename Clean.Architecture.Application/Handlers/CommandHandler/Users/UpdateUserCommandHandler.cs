using AutoMapper;
using Clean.Architecture.Application.Command.User;
using Clean.Architecture.Application.Dtos.User;
using Clean.Architecture.Domain.Entities.User;
using Clean.Architecture.Domain.Entities.User;
using MediatR;
using Clean.Architecture.Domain.Interfaces.User;

namespace Clean.Architecture.Application.Handlers.CommandHandler.Users
{
    public class UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        : IRequestHandler<UpdateUserCommand, UserDto>
    {
        public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            await userRepository.UpdateUserAsync(new User
            {
                Age = request.Age,
                family = request.Family,
                Id = request.Id,
                Name = request.Name,
            }, cancellationToken);
            var user = await userRepository.GetUserByIdAsync(request.Id, cancellationToken);
            return mapper.Map<UserDto>(user);


        }
    }
}
