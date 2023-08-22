using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Ingresa un valor: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                RealizarDivision(valor);
                Console.WriteLine("Operación exitosa.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Excepción capturada: {ex.Message}");               
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción capturada: {ex.Message}");
                Console.WriteLine("Ocurrió un error durante la operación.");
                Console.ReadKey();
            }
        }

        static void RealizarDivision(double valor)
        {
            if (valor == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            double resultado = 10 / valor;
            Console.WriteLine($"Resultado de la división: {resultado}");
        }
    }
} 
