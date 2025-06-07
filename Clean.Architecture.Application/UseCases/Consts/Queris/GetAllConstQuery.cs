
using Clean.Architecture.Application.UseCases.Consts.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Consts.Queris
{
    public class GetAllConstQuery:IRequest<List<ConstDto>>;
    
    
}
