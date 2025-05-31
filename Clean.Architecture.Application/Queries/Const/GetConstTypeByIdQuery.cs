using Clean.Architecture.Application.Dtos.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Queries.Const
{
    public class GetConstTypeByIdQuery:IRequest<ConstTypeDto>
    {
        public readonly Guid guid;

        public GetConstTypeByIdQuery( Guid guid)
        {
            this.guid = guid;
        }
    }
}
