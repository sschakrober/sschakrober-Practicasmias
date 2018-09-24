using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_del_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";

            Console.WriteLine("Uso del IF");

            Console.Write("Ingrese un numero: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero >= 0)
            {
                Console.WriteLine("El numero {0} es Positivo", numero);
            }
            if (numero <= 0)
            {
                Console.WriteLine("El numero {0} es Negativo", numero);
            }
        }
    }
}
