using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.ValueObject.User
{


    public  record Age(double Value)
    {
        public static implicit operator Double(Age age)=>age.Value;
    }
}
