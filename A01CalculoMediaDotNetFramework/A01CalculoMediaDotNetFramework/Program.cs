using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01CalculoMediaDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Danilo. Bem-vindo ao programa para cálculo de média!\n");
            Console.WriteLine("Por gentileza, informe o nome do primeiro aluno(a):");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Qual foi a primeira nota do aluno(a)?");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a segunda nota do aluno(a)?");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a terceira nota do aluno(a)?");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPor gentileza, informe o nome do segundo aluno(a):");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Qual foi a primeira nota do aluno(a)?");
            double nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a segunda nota do aluno(a)?");
            double nota5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a terceira nota do aluno(a)?");
            double nota6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPor gentileza, informe o nome do terceiro aluno(a):");
            string nome3 = Console.ReadLine();
            Console.WriteLine("Qual foi a primeira nota do aluno(a)?");
            double nota7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a segunda nota do aluno(a)?");
            double nota8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a terceira nota do aluno(a)?");
            double nota9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPor gentileza, informe o nome do quarto aluno(a):");
            string nome4 = Console.ReadLine();
            Console.WriteLine("Qual foi a primeira nota do aluno(a)?");
            double nota10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a segunda nota do aluno(a)?");
            double nota11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi a terceira nota do aluno(a)?");
            double nota12 = Convert.ToDouble(Console.ReadLine());
            double m1 = (nota1 + nota2 + nota3) / 3;
            double m2 = (nota4 + nota5 + nota6) / 3;
            double m3 = (nota7 + nota8 + nota9) / 3;
            double m4 = (nota10 + nota11 + nota12) / 3;
            Console.WriteLine("\nA média de " + nome1 + " é " + m1 + "!");
            Console.WriteLine("\nA média de " + nome2 + " é " + m2 + "!");
            Console.WriteLine("\nA média de " + nome3 + " é " + m3 + "!");
            Console.WriteLine("\nA média de " + nome4 + " é " + m4 + "!");
            Console.ReadKey();
        }
    }
}
