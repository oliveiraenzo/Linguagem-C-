using System;

namespace Projeto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8");

            //Variáveis
            string nome;
            int idade;

            //Entrada de dados
            Console.Write("Digite o nome da pessoa:");
            nome = Console.ReadLine();

            Console.Write("Digite a idade:");
            idade = int.Parse(Console.ReadLine());

            //Saída de dados
            Console.Write($"Olá {nome}! Sua idade é {idade}.");

            if (idade == 0)
            {
                Console.Write("Você é bebê");
            }
            else
            {
                if (idade > 0 && idade <= 12)
                {
                    Console.Write("Você é criança");
                }
                else
                {
                    if (idade > 12 && idade <= 18)
                    {
                        Console.Write("Você é adolescente");
                    }
                    else
                    {
                        if (idade > 18 && idade <= 60)
                        {
                            Console.Write("Você é adulto");
                        }
                        else
                        {
                            if (idade > 60 && idade <= 120)
                            {
                                Console.Write("Você é idoso");
                            }
                            else
                            {
                                Console.Write("Você é mumia");
                            }
                            Console.ReadKey();
                        }
                }
            }
        }
    }
}
}
