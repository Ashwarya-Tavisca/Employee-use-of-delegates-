using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class UserDefinedException : Exception                             //custom exception
    {
        public UserDefinedException(string message)
           : base(message)
        {
        }
    }
}
