using Clean.Architecture.Domain.Entities.Jwt;

namespace Clean.Architecture.Domain.Interfaces.Auth
{
    public interface IJwtService
    {
        string GenerateAccessToken(Guid userId);
        Task<RefreshToken> GenerateAndStoreRefreshTokenAsync(Guid userId);
    }
}
