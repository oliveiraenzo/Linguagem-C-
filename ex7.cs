using System;

namespace Projeto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7");

            //Variáveis
            double x, b, m;

            //Entrada de dados
            Console.Write("Digite o valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de M:");
            m = double.Parse(Console.ReadLine());

            //Processamento
            x = b / m;

            //Saída de dados
            if (m == 0)
            {
                Console.WriteLine("A divisão não pode ser feita!");
            }
            else
            {
                Console.WriteLine($"O valor de x é: {x}.");
            }
        }
    }
}
