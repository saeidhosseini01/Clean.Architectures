using Clean.Architecture.Domain.ValueObject.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.RequestModel.Login
{
    public class RequestLogin
    {
        public UserName Username { get; set; }
        public Password Password { get; set; }
    }
}
