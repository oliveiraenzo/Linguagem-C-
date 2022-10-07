using System;

namespace Projeto_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 22");

            //Variaveis
            string cep;

            //Entrada de dados
            Console.WriteLine("Digite seu CEP");
            cep = Console.ReadLine();

            //Saída de dados
            int quantidade = cep.Length;

            if (cep.Length < 9)
            {
                Console.WriteLine("Digite um CEP válido!");
            }
            else
            {
                Console.WriteLine("CEP válido!");
            }
            Console.ReadKey();
        }
    }
}
