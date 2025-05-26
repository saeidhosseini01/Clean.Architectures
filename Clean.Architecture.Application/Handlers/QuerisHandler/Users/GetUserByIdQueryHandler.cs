using AutoMapper;
using Clean.Architecture.Application.Dtos.User;
using Clean.Architecture.Application.Queries;
using Clean.Architecture.Domain.Exeptions;
using Clean.Architecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Handlers.QuerisHandler.User
{
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdGuery, UserDto>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserByIdGuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.id, cancellationToken);
            if (user == null) throw new NotFoundException(nameof(user), request.id);
            var userDto = mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
