using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_anidados
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;

            Console.WriteLine("Programa para elegir una opcion: Suma, Resta, Division, Multiplicacion");

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplicacion");

            Console.WriteLine("Elige una opcion: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            Console.Write("Ingrese el primer numero: ");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            Console.Write("Ingrese el segundo numero: ");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            if (opcion == 1)
            {
                resultado = a + b;
            }
            if (opcion == 2)
            {
                resultado = a - b;
            }
            if (opcion == 3)
            {
                if (b != 0)
                    resultado = a / b;
                else
                {
                    Console.WriteLine("El divisor no es valido");
                }
            }
            if ( opcion == 4)
            {
                resultado = a * b;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
