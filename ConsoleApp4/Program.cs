using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string nome;
                double n1, n2, mediafinal, t1;
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.Write("\nPrimeira Nota: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("\nSegunda Nota: ");
                n2 = double.Parse(Console.ReadLine());

                Console.Write("\nNota do Trabalho: ");
                t1 = double.Parse(Console.ReadLine());




                mediafinal = (n1 + n2 + t1) / 3;



                Console.Clear();
                if (mediafinal >= 8.5)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  A");
                }
                else if (mediafinal >= 7 && mediafinal <= 8.4)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  B");
                }
                else if (mediafinal >= 6 && mediafinal <= 6.9)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  C");
                }
                else if (mediafinal >= 0.1 && mediafinal <= 5.9)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  D");
                }
                else
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  E");
                }
                Console.ReadKey();
                Console.Clear();





            }
            
        }
    }
}
