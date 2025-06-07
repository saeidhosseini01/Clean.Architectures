using Clean.Architecture.Domain.ValueObject.Login;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Command.Login
{
    public class LoginCommand : IRequest<string>
    {
        public UserName Username { get; set; }
        public Password Password { get; set; }
        public LoginCommand(UserName username, Password password)
        {
            
            this.Username = username;
            this.Password = password;
        }
    }
}
