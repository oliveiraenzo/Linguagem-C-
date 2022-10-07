using System;

namespace Projeto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6");

            //Variáveis
            string nome;
            double n1, n2, media;

            //Entrada de dados
            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = double.Parse(Console.ReadLine());

            //Processamento
            media = (n1 * 0.4) + (n2 * 0.6);

            //Saída de dados
            Console.WriteLine($"Olá {nome}, sua média é {media}.");

            Console.ReadKey();

        }
    }
}
