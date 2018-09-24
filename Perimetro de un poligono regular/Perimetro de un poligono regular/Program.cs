using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_de_un_poligono_regular
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro = 0.0f;
            float lado = 0.0f;
            int numerodelados = 0;
            string valor = "";

            Console.WriteLine("Programa que calcula el perimetro de un poligono regular");

            Console.Write("De cuantos lados es el poligono: ");
            valor = Console.ReadLine();
            numerodelados = Convert.ToInt32(valor);

            Console.Write("Cual es el valor de uno de los lados del poligono: ");
            valor = Console.ReadLine();
            lado = Convert.ToSingle(valor);

            perimetro = lado * numerodelados;

            Console.WriteLine("El Perimetro del poligono regular es: {0}cm", perimetro);
        }
    }
}
