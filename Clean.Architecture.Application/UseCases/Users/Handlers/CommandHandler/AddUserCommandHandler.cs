using AutoMapper;
using Clean.Architecture.Domain.Entities.User;
using Clean.Architecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Domain.Interfaces.Users;
using Clean.Architecture.Application.Users.Command;
using Clean.Architecture.Application.Users.Dtos;

namespace Clean.Architecture.Application.Users.Handlers.CommandHandler
{


    public class AddUserCommandHandler
        : IRequestHandler<AddUserCommand, UserDto>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public AddUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<UserDto> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Age = request.Age,
                family = request.Family,
                Id = request.Id,
                Name = request.Name,

            };

            await userRepository.AddUserAsync(user, cancellationToken);
            return mapper.Map<UserDto>(user);
        }
    }
}
