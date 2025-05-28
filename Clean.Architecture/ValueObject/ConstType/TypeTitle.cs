using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.ValueObject.ConstType
{
    public record TypeTitle(string value)
    {
        public static implicit operator string(TypeTitle title) => title.value; 
    }

}
