using Clean.Architecture.Application.UseCases.Auth.Commands;
using Clean.Architecture.Application.UseCases.Auth.Dtos;
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
        public RefreshTokenCommandHandler(IReferenceService)
        {
                
        }
        public Task<AuthResultDto> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
