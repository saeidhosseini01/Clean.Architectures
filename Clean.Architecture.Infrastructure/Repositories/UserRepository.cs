using Clean.Architecture.Domain.Entities.Base;
using Clean.Architecture.Domain.Exeptions;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Persistence.ApiDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Repositories
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
          await _context.AddAsync(user,cancellationToken);
            await _context.SaveChangesAsync();
        }

        public  Task<List<User>> GetAllUserAsync(CancellationToken cancellationToken)
        => _context.User.ToListAsync(cancellationToken);

        public async Task<User?> GetUserByIdAsync(string id, CancellationToken cancellationToken)
        => _context.User.FindAsync(id, cancellationToken).AsTask().Result;

        public async Task UpdateUserAsync(User user, CancellationToken cancellationToken)
        {
            var found = await _context.User.FindAsync([user.Id], cancellationToken);
            if (found == null) throw new NotFountUserExeption();

            found.Age = user.Age;
            found.Name = user.Name;
            found.family=user.family;
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
