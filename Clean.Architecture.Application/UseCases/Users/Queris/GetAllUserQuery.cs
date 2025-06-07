using Clean.Architecture.Application.Users.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Users.Query
{


    public class GetAllUserQuery : IRequest<List<UserDto>>;

}
