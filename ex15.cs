using System;

namespace Projeto_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 15");

            //Variáveis
            float t, dab, va, vb, local;


            //Entrada de dados
            Console.Write("Digite a distania entre o móvel a e o móvel b:");
            dab = float.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade do movel a:");
            va = float.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade do movel b:");
            vb = float.Parse(Console.ReadLine());

            //Processamento
            t = dab / (va - vb);
            local = va * t;

            //Saída de dados
            if (va <= vb)
            {
                Console.Write("Os móveis nunca se encontrarão!");
            }
            else
            {
                Console.Write($"Os móveis se encontrarão em {local}KM, e em {t}s.");
            }
            Console.ReadKey();
        }
    }
}
