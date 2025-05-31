using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Entities.Common
{
    public record ConstType:GenericEntity
    {
        public string TypeTitle { get; set; }
        public int TypeId { get; set; }
      
    }
}
