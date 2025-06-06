using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces.Login
{
    public interface IAuthService
    {
        string GenerateToken(string userId, string username, IList<string> roles);
    }
}
