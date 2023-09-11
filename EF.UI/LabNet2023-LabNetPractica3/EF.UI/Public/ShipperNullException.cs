using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Exceptions
{
    public class ShipperNullException : Exception
    {
        public ShipperNullException() : base("No se ingreso nada") 
        {
            
        }
    }
}
