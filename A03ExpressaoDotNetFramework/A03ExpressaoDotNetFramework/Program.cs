using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03ExpressaoDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A partir de: x + y + d + 5 x 77 + 8 - 10 x (8/3), defina os valores de x, y e d para encontrar o resultado da expressão:\n");
            Console.WriteLine("Digite o valor de x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o valor de y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o valor de d:");
            double d = Convert.ToDouble(Console.ReadLine());
            double r = x + y + d + 385 + 8 - (80 / 3);
            Console.WriteLine("\nConsiderando x = " + x + ", y = " + y + " e d = " + d + ", o resultado da expressão é igual a " + r + " !");
            Console.ReadKey();
        }
    }
}
