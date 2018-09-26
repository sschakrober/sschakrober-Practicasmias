using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string valor = "";
            int dia = 0;

            Console.WriteLine("Hacer un programa que le pida un numero del 1 al 7 y escribba el nombre del dia que corresponda ese numero en la semana.");
            valor = Console.ReadLine();
            dia = Convert.ToInt32(valor);

            switch (dia)
            {
                case 1:
                    Console.Write("Lunes");
                    break;
                case 2:
                    Console.Write("Martes");
                    break;
                case 3:
                    Console.Write("Miercoles");
                    break;
                case 4:
                    Console.Write("Jueves");
                    break;
                case 5:
                    Console.Write("Viernes");
                    break;
                case 6:
                    Console.Write("Sabado");
                    break;
                case 7:
                    Console.Write("Domingo");
                    break;
                default:
                    Console.Write("La opcion no es Valida");
                    break;
            }
            
        }
    }
}
