using System;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 1");

            //Variáveis
            string nome, endereço, telefone;

            //Entrada de dados
            Console.WriteLine("Digite o Nome do Aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço:");
            endereço = Console.ReadLine();

            Console.WriteLine("Digite o telefone:");
            telefone = Console.ReadLine();

            //Saída de dados
            Console.WriteLine($"Olá {nome}, seu endereço é {endereço} e seu telefone é {telefone}.");

            Console.ReadKey();
        }
    }
}
