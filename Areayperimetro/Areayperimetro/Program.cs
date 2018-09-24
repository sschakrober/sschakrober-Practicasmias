using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areayperimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            float area = 0.0f;
            float perimetro = 0.0f;
            float ancho = 0.0f;
            float alto = 0.0f;
            string valor = "";

            Console.WriteLine("Programa para calcular area y perimetro de rectangulo");

            Console.Write("Ingrese el ancho: ");
            valor = Console.ReadLine();
            ancho = Convert.ToSingle(valor);

            Console.Write("Ingrese el alto: ");
            valor = Console.ReadLine();
            alto = Convert.ToSingle(valor);

            perimetro = 2 * (ancho + alto);
            area = alto * ancho;

            Console.WriteLine("El resultado del Area es: {0} y del Perimetro es: {1}", area, perimetro);

            Console.ReadKey();
        }
    }
}
