using Clean.Architecture.Application.UseCases.Auth.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Auth.Commands
{
    public class RefreshTokenCommand:IRequest<AuthResultDto>
    {
        public string RefreshToken { get; set; }
    }
}
