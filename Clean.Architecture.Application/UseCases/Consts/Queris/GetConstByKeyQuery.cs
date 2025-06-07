using Clean.Architecture.Application.Dtos.Base;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Consts.Queris
{
    public class GetConstByKeyQuery:IRequest<List<TValue<string>>>
    {
        public readonly string key;

        public GetConstByKeyQuery(string key)
        {
            this.key = key;
        }
    }
}
