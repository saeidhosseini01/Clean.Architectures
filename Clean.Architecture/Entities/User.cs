using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Entities
{

    public record User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string family { get; set; }
        public double Age { get; set; }
    }
}
