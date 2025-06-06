﻿using AutoMapper;
using Clean.Architecture.Application.Users.Dtos;
using Clean.Architecture.Application.Users.Queris;

using Clean.Architecture.Domain.Exeptions.NotFount;
using Clean.Architecture.Domain.Interfaces.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Users.Handlers.QueryHandler
{
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.id, cancellationToken);
            if (user == null) throw new NotFoundException(nameof(user), request.id);
            var userDto = mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
