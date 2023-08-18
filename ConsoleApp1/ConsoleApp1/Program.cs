using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            Animal animal = new Gato(4);
            Animal animal2 = new Persona(2); 

            animales.Add(animal);
            animales.Add(animal2);

            foreach (var item in animales)
            {
                Console.WriteLine(item.Caminar());
            }
            Console.ReadKey();

        }
    }
}
