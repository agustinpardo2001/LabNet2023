using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi Taxi1 = new Taxi(0, "Coche 1");
            Taxi Taxi2 = new Taxi(0, "Coche 2");
            Taxi Taxi3 = new Taxi(0, "Coche 3");
            Taxi Taxi4 = new Taxi(0, "Coche 4");
            Taxi Taxi5 = new Taxi(0, "Coche 5");

            Omnibus Omnibus1 = new Omnibus(0, 65 );
            Omnibus Omnibus2 = new Omnibus(0, 180);
            Omnibus Omnibus3 = new Omnibus(0, 150);
            Omnibus Omnibus4 = new Omnibus(0, 92);
            Omnibus Omnibus5 = new Omnibus(0, 110);



            bool Salir = false;

            while (!Salir)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("*** *** *** *** ***");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("NO PIBE NO VOY HASTA ALLA >:/ ");
                    Console.WriteLine("Para sentirse chofer de la 620 copie y pegue el link en el buscador--> https://youtu.be/Oqc2a70eKCs?si=WZ4RUjvsdkVVK6nn");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Escoja un Medio de Transporte:\n" +
                                  "Presione 1 para Taxi\n" +
                                  "Presione 2 para Omnibus\n" +
                                  "Presione 3 para Eliminar\n"+
                                  "Presione 4 para la lista de pasajeros\n");
                    int opciones = Convert.ToInt32(Console.ReadLine());

                    switch (opciones)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Taxi");
                            int primerTaxi = Int32.Parse(Console.ReadLine());
                            if (primerTaxi > 4 || primerTaxi <= 0)
                            {
                                Console.WriteLine("*Solo numeros del 1 al 5 cabezón*");
                                primerTaxi = Int32.Parse(Console.ReadLine());
                                Taxi1.AgregarPasajeros(primerTaxi);

                            }
                            else
                            {
                                Taxi1.AgregarPasajeros(primerTaxi);
                            }

                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Taxi");
                            int segundoTaxi = Int32.Parse(Console.ReadLine());
                            if (segundoTaxi > 4 || segundoTaxi <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 5 cabezón");
                                segundoTaxi = Int32.Parse(Console.ReadLine());
                                Taxi2.AgregarPasajeros(segundoTaxi);

                            }
                            else
                            {
                                Taxi2.AgregarPasajeros(segundoTaxi);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Taxi");
                            int tercerTaxi = Int32.Parse(Console.ReadLine());
                            if (tercerTaxi > 4 || tercerTaxi <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 5 cabezón");
                                tercerTaxi = Int32.Parse(Console.ReadLine());
                                Taxi3.AgregarPasajeros(tercerTaxi);

                            }
                            else
                            {
                                Taxi3.AgregarPasajeros(tercerTaxi);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Taxi");
                            int cuartoTaxi = Int32.Parse(Console.ReadLine());
                            if (cuartoTaxi > 4 || cuartoTaxi <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 5 cabezón");
                                cuartoTaxi = Int32.Parse(Console.ReadLine());
                                Taxi4.AgregarPasajeros(cuartoTaxi);

                            }
                            else
                            {
                                Taxi4.AgregarPasajeros(cuartoTaxi);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Taxi");
                            int quintoTaxi = Int32.Parse(Console.ReadLine());
                            if (quintoTaxi > 4 || quintoTaxi <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 5 cabezón");
                                quintoTaxi = Int32.Parse(Console.ReadLine());
                                Taxi5.AgregarPasajeros(quintoTaxi);

                            }
                            else
                            {
                                Taxi5.AgregarPasajeros(quintoTaxi);
                            }
                            Console.WriteLine("");
                            break;

                        case 2: 
                            Console.Clear();
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Omnibus");
                            int primerOmnibus = Int32.Parse(Console.ReadLine());
                            if (primerOmnibus > 24 || primerOmnibus <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 24 cabezón");
                                primerOmnibus = Int32.Parse(Console.ReadLine());
                                Omnibus1.AgregarPasajeros(primerOmnibus);
                                
                            }
                            else
                            {
                                Omnibus1.AgregarPasajeros(primerOmnibus);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Omnibus");
                            int segundoOmnibus = Int32.Parse(Console.ReadLine());
                            if (segundoOmnibus > 24 || segundoOmnibus <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 24 cabezón");
                                segundoOmnibus = Int32.Parse(Console.ReadLine());
                                Omnibus2.AgregarPasajeros(segundoOmnibus);

                            }
                            else
                            {
                                Omnibus2.AgregarPasajeros(segundoOmnibus);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Omnibus");
                            int tercerOmnibus = Int32.Parse(Console.ReadLine());
                            if (tercerOmnibus > 24 || tercerOmnibus <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 24 cabezón");
                                tercerOmnibus = Int32.Parse(Console.ReadLine());
                                Omnibus3.AgregarPasajeros(tercerOmnibus);

                            }
                            else
                            {
                                Omnibus3.AgregarPasajeros(tercerOmnibus);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Omnibus");
                            int cuartoOmnibus = Int32.Parse(Console.ReadLine());
                            if (cuartoOmnibus > 24 || cuartoOmnibus <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 24 cabezón");
                                cuartoOmnibus = Int32.Parse(Console.ReadLine());
                                Omnibus4.AgregarPasajeros(cuartoOmnibus);

                            }
                            else
                            {
                                Omnibus4.AgregarPasajeros(cuartoOmnibus);
                            }
                            Console.WriteLine("Por favor ingrese la cantidad de pasajeros en el Omnibus");
                            int quintoOmnibus = Int32.Parse(Console.ReadLine());
                            if (quintoOmnibus > 24 || quintoOmnibus <= 0)
                            {
                                Console.WriteLine("Solo numeros del 1 al 24 cabezón");
                                quintoOmnibus = Int32.Parse(Console.ReadLine());
                                Omnibus5.AgregarPasajeros(quintoOmnibus);

                            }
                            else
                            {
                                Omnibus5.AgregarPasajeros(quintoOmnibus);
                            }
                            Console.WriteLine("");
                            break;

                        case 3:
                            Console.Clear();
                            Taxi1.EliminarPasajeros();
                            Taxi2.EliminarPasajeros();
                            Taxi3.EliminarPasajeros();
                            Taxi4.EliminarPasajeros();
                            Taxi5.EliminarPasajeros();
                            Omnibus1.EliminarPasajeros();
                            Omnibus2.EliminarPasajeros();
                            Omnibus3.EliminarPasajeros();
                            Omnibus4.EliminarPasajeros();
                            Omnibus5.EliminarPasajeros();
                            Console.WriteLine("Todo vacio");
                            Console.WriteLine("");
                            break;
                        case 4: 
                            Console.Clear();
                            Console.WriteLine("Cantidad de pasajeros por transporte");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(
                                $"Lista de Taxis:\n" +
                                $"El {Taxi1.Coche}: lleva {Taxi1.Pasajeros} pasajeros.\n" +
                                $"El {Taxi2.Coche}: lleva {Taxi2.Pasajeros} pasajeros.\n" +
                                $"El {Taxi3.Coche}: lleva {Taxi3.Pasajeros} pasajeros.\n" +
                                $"El {Taxi4.Coche}: lleva {Taxi4.Pasajeros} pasajeros.\n" +
                                $"El {Taxi5.Coche}: lleva {Taxi5.Pasajeros} pasajeros.\n" +

                                $"Lista de Omnibus:\n" +
                                $"La linea {Omnibus1.Linea}: lleva {Omnibus1.Pasajeros} pasajeros.\n" +
                                $"La linea {Omnibus2.Linea}: lleva {Omnibus2.Pasajeros} pasajeros.\n" +
                                $"La linea {Omnibus3.Linea}: lleva {Omnibus3.Pasajeros} pasajeros.\n" +
                                $"La linea {Omnibus4.Linea}: lleva {Omnibus4.Pasajeros} pasajeros.\n" +
                                $"La linea {Omnibus5.Linea}: lleva {Omnibus5.Pasajeros} pasajeros.\n" 
                                );
                            break;

                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadLine();
        }
}   }
