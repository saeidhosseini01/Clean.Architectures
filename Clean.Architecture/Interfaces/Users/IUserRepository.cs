﻿using Clean.Architecture.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken);
        Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
        Task AddUserAsync(User user, CancellationToken cancellationToken);
        Task UpdateUserAsync(User user, CancellationToken cancellationToken);
    }
}
