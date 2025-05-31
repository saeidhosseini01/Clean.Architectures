using Clean.Architecture.Application.Dtos.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Queries.Const
{
    public class GetConstByKeyQuery:IRequest<ConstDto>
    {
        public readonly string key;

        public GetConstByKeyQuery(string key)
        {
            this.key = key;
        }
    }
}
