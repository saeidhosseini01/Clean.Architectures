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
        public string Username { get; set; }
        public string Password { get; set; }
        public LoginCommand(string username, string password)
        {
            
            this.Username = username;
            this.Password = password;
        }
    }
}
