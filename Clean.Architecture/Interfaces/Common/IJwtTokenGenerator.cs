using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces.Common
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(string userId, string email, string role);
    }
}
