using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.UseCases.Auth.Dtos
{
    public class AuthResultDto
    {

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
