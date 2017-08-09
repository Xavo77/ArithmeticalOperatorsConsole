using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArithmeticalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algunos usos de Operadores aritméticos en el cálculo de areas

            //Area de un triángulo
            Console.WriteLine("**********CALCULAR EL AREA DE UN TRIANGULO**********");
            Console.Write("Cuál es la Base:");
            double tbase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cuál es la Altura:");
            double taltura = Convert.ToDouble(Console.ReadLine());
            double area = (tbase * taltura) / 2;
            Console.WriteLine("El área del triángulo es: " + area);
            Console.ReadLine();

            //Area de un Cuadrado
            Console.WriteLine("**********CALCULAR EL AREA DE UN CUADRADO**********");
            Console.Write("Escribe uno de sus lados: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            double areaCuadrado = lado * lado;
            Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
            Console.ReadLine();

            //Area de un rectángulo
            Console.WriteLine("**********CALCULAR EL AREA DE UN RECTANGULO**********");
            Console.Write("Cuál es la base : ");
            double baseR = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cuál es la altura: ");
            double alturaR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del rectángulo es: " + (baseR * alturaR));
            Console.ReadLine();
            Console.WriteLine();

            //Area de un circulo
            Console.WriteLine("**********CALCULAR EL AREA DE UN CIRCULO**********");
            Console.Write("Radio: ");
            double radio = Convert.ToDouble( Console.ReadLine());
            double pi = Math.PI;
            double areaCirculo = (pi * radio);
            Console.WriteLine("El área del circulo es: " + (areaCirculo * areaCirculo));
            Console.ReadLine();

        }
    }
}
