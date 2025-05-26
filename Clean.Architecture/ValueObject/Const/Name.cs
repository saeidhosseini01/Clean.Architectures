using Clean.Architecture.Domain.ValueObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.ValueObject.Const
{
    public record Name (string value)
    {
        public static implicit operator string(Name name) => name.value;
    }
    
}
