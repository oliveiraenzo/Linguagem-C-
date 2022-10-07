using System;

namespace Projeto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5");

            //Variáveis
            float X, B, H, J, R;

            //Entrada de dados
            Console.Write("Digite o valor de B:");
            B = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de H:");
            H = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de J:");
            J = float.Parse(Console.ReadLine());

            //Processamento
            X = (B * B * B) * H;
            R = X / J;

            //Saída de dados
            Console.Write($"O Valor de X é: {X}, e o valor de R é: {R}. ");
        }
    }
}
