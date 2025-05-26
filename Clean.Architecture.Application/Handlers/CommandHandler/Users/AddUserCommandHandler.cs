using AutoMapper;
using Clean.Architecture.Application.Command.User;
using Clean.Architecture.Domain.Entities.User;
using Clean.Architecture.Application.Dtos.User;
using Clean.Architecture.Domain.Entities;

using Clean.Architecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Handlers.CommandHandler.Users
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
            var user = new 
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
