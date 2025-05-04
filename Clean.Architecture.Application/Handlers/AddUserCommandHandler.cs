using AutoMapper;
using Clean.Architecture.Application.Command;
using Clean.Architecture.Application.Dtos;
using Clean.Architecture.Domain.Entities;
using Clean.Architecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Handlers
{


    public class AddUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        : IRequestHandler<AddUserCommand, UserDto>
    {
        public async Task<UserDto> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
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
            },cancellationToken );
            var user=await userRepository.GetUserByIdAsync(request.Id,cancellationToken);
            return mapper.Map<UserDto>(user);

           
        }
    }
}
