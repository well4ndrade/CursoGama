using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05AvaliacaoAlunosDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para verificar aprovação do aluno!\n");
            Console.WriteLine("Digite o nome do aluno(a):");
            string nome = Console.ReadLine();
            Console.WriteLine("\nDigite a primeira nota do aluno(a):");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a segunda nota do aluno(a):");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            int mediaAluno = (nota1 + nota2) / 2;
            if (mediaAluno == 0)
            {
                Console.WriteLine($"\n{nome}, você não aprendeu nada!");
            }
            else if (mediaAluno >= 1 && mediaAluno <= 4)
            {
                Console.WriteLine($"\n{nome}, você foi reprovado!");
            }
            else if (mediaAluno >= 5 && mediaAluno <= 7)
            {
                Console.WriteLine($"\n{nome}, você passou raspando!");
            }
            else if (mediaAluno == 8 || mediaAluno == 9)
            {
                Console.WriteLine($"\n{nome}, você mandou bem!");
            }
            else
            {
                Console.WriteLine($"\n{nome}, você é muito inteligente!");
            }

            Console.ReadKey();
        }
    }
}
