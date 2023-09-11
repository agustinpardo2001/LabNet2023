using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Exceptions
{
    public class PhoneEmptyException : Exception
    {
        public PhoneEmptyException() : base("Numero Vacio")
        {

        }
    }
}
