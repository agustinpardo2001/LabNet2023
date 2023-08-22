using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();

            try
            {
                logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción capturada:");
                Console.WriteLine("Tipo de excepción: " + ex.GetType());
                Console.WriteLine("Mensaje: " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
