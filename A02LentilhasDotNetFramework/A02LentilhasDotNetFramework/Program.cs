using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02LentilhasDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Valkiria. Bem-vinda ao seu programa de cálculo de preços!\n");
            Console.WriteLine("Digite a quantidade de lentilha em quilos:");
            double k = Convert.ToDouble(Console.ReadLine());
            double preço = 1.5 * k;
            Console.WriteLine("\nO preço de " + k + " Kg de lentilha vai ser R$ " + preço + "!");
            Console.ReadKey();
        }
    }
}
