using Clean.Architecture.Application.UseCases.Logins.Commands;
using MediatR;

namespace Clean.Architecture.Application.UseCases.Logins.Handlers.CommandHandlers
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        public Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
