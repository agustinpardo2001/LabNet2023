using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        
    static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el dividendo:");
                double dividendo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor:");
                double divisor = Convert.ToDouble(Console.ReadLine());

                double resultado = RealizarDivision(dividendo, divisor);
                Console.WriteLine("El resultado de la división es: " + resultado);
                Console.ReadKey();

            }
            catch (FormatException)
            {
                Console.WriteLine("¡Seguro ingresó una letra o no ingresó nada!");
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo una excepción: " + ex.Message);
                Console.ReadKey();
            }
        }

        static double RealizarDivision(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            return dividendo / divisor;
        }
    }

}

