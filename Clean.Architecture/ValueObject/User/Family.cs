using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.ValueObject.User
{


    public record Family(string Value)
    {
        public static implicit operator string(Family family)=>family.Value;
    }
}
