using Clean.Architecture.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken);
        Task<User> GetUserByIdAsync(string id, CancellationToken cancellationToken);
        Task AddUserAsync(User user, CancellationToken cancellationToken);
        Task UpdateUserAsync(User user , CancellationToken cancellationToken);
    }
}
