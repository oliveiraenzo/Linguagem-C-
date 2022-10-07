using System;

namespace Projeto_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 14");

            //Variáveis
            string nome;
            double media, n1,n2 ,n3;


            //Entrada de dados
            Console.Write("Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.Write("Digite a n1:");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a n2:");
            n2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a n3:");
            n3 = Double.Parse(Console.ReadLine());

            //Processamento
            media = (n1 + n2 + n3) / 3;

            //Saída de dados
            if (media < 4.0)
            {
                Console.WriteLine($"Olá {nome}, você foi Reprovado!");
            }
            else
            {
                if (media >= 7.0)
                {
                    Console.WriteLine($"Olá {nome}, você foi Aprovado!");
                }
            }
        }
    }
}
