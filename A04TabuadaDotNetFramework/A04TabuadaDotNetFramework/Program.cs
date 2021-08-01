using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04TabuadaDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 
            // TABUADA SEM REPETIÇÕES

            Console.WriteLine("Programa para calculadora de tabuada!\n");
            Console.WriteLine("Digite o número da tabuada que você deseja:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n1 x {numero} = {numero * 1}");
            Console.WriteLine($"2 x {numero} = {numero * 2}");
            Console.WriteLine($"3 x {numero} = {numero * 3}");
            Console.WriteLine($"4 x {numero} = {numero * 4}");
            Console.WriteLine($"5 x {numero} = {numero * 5}");
            Console.WriteLine($"6 x {numero} = {numero * 6}");
            Console.WriteLine($"7 x {numero} = {numero * 7}");
            Console.WriteLine($"8 x {numero} = {numero * 8}");
            Console.WriteLine($"9 x {numero} = {numero * 9}");
            Console.WriteLine($"10 x {numero} = {numero * 10}");

            Console.ReadKey();
            
            // TABUADA COM FOR E DO WHILE

            int sair = 0;
            do
            {
                Console.WriteLine("Programa para calculadora de tabuada!\n");
                Console.WriteLine("Digite o número da tabuada que você deseja:");
                int numero = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} x {numero} = {numero * i}");
                }
                Console.WriteLine("Digite 1 para continuar ou 0 para sair.");
                sair = Convert.ToInt32(Console.ReadLine());
            }
            while (sair == 1);

            Console.ReadKey();

            // TABUADA COM WHILE

            Console.WriteLine("Programa para calculadora de tabuada!\n");
            Console.WriteLine("Digite o número da tabuada que você deseja:");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            while (tabuada < 10)
            {
                Console.WriteLine(tabuada);
                tabuada++;
            }
            Console.ReadKey();
            */
        }
    }
}
