using Clean.Architecture.Domain.Entities.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces.Auth
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken> GetByTokenAsync(string token);
        Task AddAsync(RefreshToken refreshToken);
        Task UpdateAsync(RefreshToken refreshToken);
    }
}
