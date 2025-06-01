using Clean.Architecture.Domain.Entities.User;
using Clean.Architecture.Domain.Exeptions;
using Clean.Architecture.Domain.Exeptions.NotFount;
using Clean.Architecture.Domain.Interfaces.Users;
using Clean.Architecture.Persistence.ApiDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Repositories.Users
{



    public class UserRepository : IUserRepository
    {
        private readonly ApiDbContexts _context;

        public UserRepository(ApiDbContexts context)
        {
            _context = context;
        }
        public async Task AddUserAsync(User user, CancellationToken cancellationToken)
        {
            await _context.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync();
        }

        public Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken)
        => _context.User.ToListAsync(cancellationToken);

        public async Task<User?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
        => _context.User.Where(u=>u.Id==id).FirstOrDefault();

        

        public async Task UpdateUserAsync(User user, CancellationToken cancellationToken)
        {
            _context.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
