using Clean.Architecture.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Queries
{


    public class GetAllUserQuery:IRequest<List<UserDto>>;
    public class GetUserByIdGuery : IRequest<UserDto>
    {
        public readonly string id;

        public GetUserByIdGuery(string id)
        {
            this.id = id;
        }
    }
    
}
