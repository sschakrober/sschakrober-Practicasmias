using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloque_de_codigo_con_IF_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            float dividendo = 0.0f;
            float divisor = 0.0f;
            float resultado = 0.0f;
            string valor = "";

            Console.Write("Ingrese el Dividendo: ");
            valor = Console.ReadLine();
            dividendo = Convert.ToSingle(valor);

            Console.Write("Ingrese el Divisor: ");
            valor = Console.ReadLine();
            divisor = Convert.ToSingle(valor);

            if (divisor != 0.0f)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado de la division es: {0}", resultado);
            }
        }
    }
}
