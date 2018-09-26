using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";

            Console.WriteLine("Hacer un programa que le pida al usuario un numero y la computadora diga si es par o impar");

            Console.Write("Ingrese un numero y te dire si es par o impar: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero %2 == 0)
            {
                Console.WriteLine("El numero {0} es Par", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} es Impar", numero);
            }
        }
    }
}
