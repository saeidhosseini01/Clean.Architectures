using Clean.Architecture.Application.UseCases.Auth.Commands;
using Clean.Architecture.Application.UseCases.Auth.Dtos;
using Clean.Architecture.Domain.Interfaces.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Auth.Handlers
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, AuthResultDto>
    {
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly IJwtService _jwtService;

        public RefreshTokenCommandHandler(
            IRefreshTokenRepository refreshTokenRepository,
            IJwtService jwtService)
        {
            _refreshTokenRepository = refreshTokenRepository;
            _jwtService = jwtService;
        }

        public async Task<AuthResultDto> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var refreshToken = await _refreshTokenRepository.GetByTokenAsync(request.RefreshToken);
            if (refreshToken == null || !refreshToken.IsActive)
                throw new UnauthorizedAccessException("Invalid or expired refresh token.");

            // Revoke old token
            refreshToken.Revoked = DateTime.UtcNow;
            await _refreshTokenRepository.UpdateAsync(refreshToken);

            // Generate new tokens
            var newAccessToken = _jwtService.GenerateAccessToken(refreshToken.UserId);
            var newRefreshToken = await _jwtService.GenerateAndStoreRefreshTokenAsync(refreshToken.UserId);

            return new AuthResultDto
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken.Token
            };
        }
    }

}
