using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, trab, media;

            Console.Write("Olá, digite o seu nome: ");
            nome = (Console.ReadLine());
            Console.Clear();
            Console.Write(nome + "\nDigite a nota do trabalho: ");
            trab = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da primeira prova: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            nota2 = Convert.ToDouble(Console.ReadLine());


            if (trab < 0 || trab > 10 || nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Por favor, digite uma nota válida.");
                Console.ReadKey();
            }
            else
            {
                media = (trab + nota1 + nota2) / 3;
                if (media >= 8.5)
                {
                    Console.WriteLine("Conceito: 'A'");
                }
                else if (media >= 7 && media < 8.4)
                {
                    Console.WriteLine("Conceito: 'B'");
                }
                else if (media >= 6 && media < 6.9)
                {
                    Console.WriteLine("Conceito:'C'");
                }
                else if (media >= 0.1 && media < 5.9)
                {
                    Console.WriteLine("Conceito: 'D'");
                }
                else if (media == 0)
                {
                    Console.WriteLine("Conceito: 'E'");
                }

                Console.ReadKey();
            }
        }
    }
}