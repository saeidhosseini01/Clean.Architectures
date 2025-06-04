using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Entities.Common
{
    public record Const: BaseEntity
    {
      
        public string Name { get; set; }
        public string Key { get; set; }
        public int ConstTypeId { get; set; }
      
        public int   Order { get; set; }

    }
    }
