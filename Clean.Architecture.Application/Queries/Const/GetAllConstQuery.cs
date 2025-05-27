using Clean.Architecture.Application.Dtos.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Queries.Const
{
    public class GetAllConstQuery:IRequest<List<ConstDtos>>;
    
    
}
