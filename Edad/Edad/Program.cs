using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string valor = "";

            Console.WriteLine("Hacer un programa para saber si sos mayor o menor de Edad");

            Console.Write("Ingrese su Edad: ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);

            if ( edad >= 18)
            {
                Console.WriteLine("Eres Mayor de Edad");
            }
            else
            {
                Console.WriteLine("Eres Menor de Edad");
            }
        }
    }
}
