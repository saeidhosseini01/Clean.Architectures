using Clean.Architecture.Domain.Entities.Jwt;
using Clean.Architecture.Domain.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Repositories.Auth
{
    public class JwtService : IJwtService
    {
        public string GenerateAccessToken(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<RefreshToken> GenerateAndStoreRefreshTokenAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
