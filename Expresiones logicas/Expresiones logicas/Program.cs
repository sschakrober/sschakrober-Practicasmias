using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones_logicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            bool permiso = false;
            string valor = "";

            Console.WriteLine("Programa que al ingresar la edad nos diga si puede conducir o no");

            Console.Write("Ingrese su edad: ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);

            Console.Write("Tienes el permiso de tus padres? (true/false): ");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);

            if ( edad > 18 || (edad >= 16 & permiso == true))
            {
                Console.WriteLine("puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
    }
}
