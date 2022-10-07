using System;

namespace Projeto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4");

            //Variáveis
            float R, B, C, D;

            //Entrada de dados
            Console.WriteLine("Digite o valor de B");
            B = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D");
            D = float.Parse(Console.ReadLine());

            //Processamento
            R = B * B - (C * D);

            //Saída de dados
            Console.WriteLine($"O valor de R é..........: {R}");

            Console.ReadKey();
        }
    }
}
