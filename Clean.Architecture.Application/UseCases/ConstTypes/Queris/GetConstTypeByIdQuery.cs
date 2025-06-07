using Clean.Architecture.Application.UseCases.ConstTypes.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.ConstTypes.Queris
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
