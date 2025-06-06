﻿using AutoMapper;
using Clean.Architecture.Application.Users.Dtos;
using Clean.Architecture.Application.Users.Query;
using Clean.Architecture.Domain.Interfaces.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Users.Handlers.QueryHandler
{


    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUserQuery, List<UserDto>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetAllUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<List<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await userRepository.GetAllUserAsync(cancellationToken);
            var userDto = mapper.Map<List<UserDto>>(users);
            return userDto;
        }
    }
}
