using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Exeptions.NotFount
{


    public class NotFountUserExeption() : Exception("This User Not Fount");
    public class NotFountEntityExeption() : Exception("This Entity Not Fount");

}
