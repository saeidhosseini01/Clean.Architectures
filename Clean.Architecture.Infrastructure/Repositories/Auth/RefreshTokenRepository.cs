using Clean.Architecture.Domain.Entities.Jwt;
using Clean.Architecture.Domain.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Repositories.Auth
{
    internal class RefreshTokenRepository : IRefreshTokenRepository
    {
        public Task AddAsync(RefreshToken refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<RefreshToken> GetByTokenAsync(string token)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RefreshToken refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}
