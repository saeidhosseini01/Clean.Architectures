using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.ValueObject.Login
{
    public record UserName(string value)
    {
        public static implicit operator string(UserName username) => username.value;
    }
}
