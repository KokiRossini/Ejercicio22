using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            Double temperaturaComvertida;
            

            Console.WriteLine("opciones a convertir");
            Console.WriteLine("(C) de celcius a farenheit");
            Console.WriteLine("(F) de Farenheit a celcius");

            var opciones = Console.ReadLine();

            if (opciones.ToUpper() == "C" || (opciones.ToUpper() == "F"))
            {
                if (opciones.ToUpper() == "C")
                {
                    Console.WriteLine("ingrese temperatura en celcius");
                    temperatura = Convert.ToInt32(Console.ReadLine());
                    temperaturaComvertida = 1.8 * temperatura + 32;
                    Console.WriteLine($" {temperatura} grados celcius son: {temperaturaComvertida} grados farenheit");
                }

                else
                {
                    Console.WriteLine("ingrese temperatura en farenheit");
                    temperatura = Convert.ToInt32(Console.ReadLine());
                    temperaturaComvertida = (temperatura - 32) / 1.8;
                    Console.WriteLine($"{temperatura} grados farenheit son: {temperaturaComvertida} grados celcius");
                }

            }

            else
            {
                Console.WriteLine("opcion ingresada no valida");
            }
        }
    }
}
