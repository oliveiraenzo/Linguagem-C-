using System;

namespace Projeto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2");

            //Variáveis
            string nome, sobrenome, rua, numero, bairro, cidade, estado, cep;

            //Entrada de dados
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Digite sua rua:");
            rua = Console.ReadLine();

            Console.WriteLine("Digite o número:");
            numero = Console.ReadLine();

            Console.WriteLine("Digite seu bairro:");
            bairro = Console.ReadLine();

            Console.WriteLine("Digite sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite seu estado:");
            estado = Console.ReadLine();

            Console.WriteLine("Digite seu CEP:");
            cep = Console.ReadLine();

            //Saída de dados
            Console.WriteLine($"SR. {nome + sobrenome}, residadente à {rua}, {numero}, {bairro}, {cidade} - {estado}, {cep}." +
                $"Favor comparecer à escola neste sábado.");

            Console.ReadKey();

        }
    }
}
