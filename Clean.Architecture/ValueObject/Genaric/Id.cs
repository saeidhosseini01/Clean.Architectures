using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.ValueObject.Genaric
{
    public  record Id(Guid value) 
    {
        public static implicit operator Guid(Id id) => id.value;

    }
}
