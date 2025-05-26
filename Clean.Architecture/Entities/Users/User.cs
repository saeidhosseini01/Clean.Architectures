using Clean.Architecture.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Entities.User
{

    public record User : BaseEntity
    {

        public string Name { get; set; }
        public string family { get; set; }
        public double Age { get; set; }
    }
}
