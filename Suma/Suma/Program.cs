using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int resultado = 0;
            string valor = "";

            Console.WriteLine("Programa para realizar una suma");

            Console.Write("Ingrese un numero: ");
            valor = Console.ReadLine();
            a = Convert.ToInt32(valor);

            Console.Write("Ingrese un segundo numero: ");
            valor = Console.ReadLine();
            b = Convert.ToInt32(valor);

            resultado = a + b;

            Console.WriteLine("La suma es: {0}", resultado);

        }
    }
}
