using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> a = new List<string>();
            a.Add("Segue a lista dos alunos:");
            a.Add("-------------------------------");
            a.Add("Nome: ");
            a.Add("Matrícula: ");
            a.Add("Notas: ");
            a.Add("Média: ");
            a.Add("Status: ");
            a.Add("-------------------------------");

            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
            
            -------
            Dado que eu tenho uma escola de programação
            Faça um programa que capture o nome, a matricula e as notas (4 notas) dos alunos
            Os alunos serão aprovados com notas igual ou maior que 7
            A quantidade de alunos é dinamica, ou seja, o usuário do programa pode digitar quantos alunos ele quiser.
            Obs: temos que digita os nomes, as matriculas as notas e o sistema calcular o resto
            No final do programa, mostre um relatório assim:

            Segue a lista dos alunos:
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------
            */
            Console.WriteLine("Programa para verificação de alunos aprovados.\n");
            Console.WriteLine("Digite a quantidade de alunos que foram avaliados:");
            int alunos = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= alunos; i++)
            {
                Console.WriteLine("\nDigite o nome do aluno(a):");
                string name = Console.ReadLine();
                Console.WriteLine("\nDigite a matrícula do aluno(a):");
                int matricula = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDigite a primeira nota do aluno(a):");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota do aluno(a):");
                double n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota do aluno(a):");
                double n3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota do aluno(a):");
                double n4 = Convert.ToDouble(Console.ReadLine());

                double media = (n1 + n2 + n3 + n4) / 4;

                if (media >= 7)
                {
                    List<string> a = new List<string>();
                    a.Add("\nSegue os dados do aluno(a):");
                    a.Add("-------------------------------");
                    a.Add("Nome: " + name);
                    a.Add("Matrícula: " + matricula);
                    a.Add($"Notas: {n1}; {n2}; {n3}; {n4}");
                    a.Add("Média: " + media);
                    a.Add("Status: Aprovado");
                    a.Add("-------------------------------");

                    foreach (string nome in a)
                    {
                        Console.WriteLine(nome);
                    }
                }
                else
                {
                    List<string> a = new List<string>();
                    a.Add("\nSegue os dados do aluno(a):");
                    a.Add("-------------------------------");
                    a.Add("Nome: " + name);
                    a.Add("Matrícula: " + matricula);
                    a.Add($"Notas: {n1}; {n2}; {n3}; {n4}");
                    a.Add("Média: " + media);
                    a.Add("Status: Reprovado");
                    a.Add("-------------------------------");

                    foreach (string nome in a)
                    {
                        Console.WriteLine(nome);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
