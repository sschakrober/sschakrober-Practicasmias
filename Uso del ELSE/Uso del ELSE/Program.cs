using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_del_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";

            Console.WriteLine("Uso del ELSE");

            Console.Write("Ingrese un numero: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero >= 0)
            {
                Console.WriteLine("El numero es: {0} es positivo", numero);
            }
            else
            {
                Console.WriteLine("El numero es: {0} es negativo", numero);
            }
        }
    }
}
