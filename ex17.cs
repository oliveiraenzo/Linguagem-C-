using System;

namespace Projeto17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 17");

            //Variáveis
            int idade;
            string nome, cpf;
            float salario;


            //Entrada de dados
            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu CPF:");
            cpf = Console.ReadLine();

            Console.Write("Digite seu salário:");
            salario = float.Parse(Console.ReadLine());


            //Saída de dados
            Console.WriteLine($"Sua idade é:.......... {idade}!");


            //Para achar a posição do espaço (primeiro nome)
            int posicaoEspaco = nome.IndexOf(' ');

            if (posicaoEspaco == -1)
            {
                Console.WriteLine("Primeiro nome:......... " + nome);
            }
            else
            {
                Console.WriteLine("Primeiro nome:........... " + nome.Substring(0, posicaoEspaco));
            }


            //Ultimas três letras
            int ultimasLetras = nome.LastIndexOf(' ');

            if (ultimasLetras == -1)
            {
                Console.WriteLine("Ultimas tres letras: ........." + nome.Substring(0, 3));
            }
            else
            {
                Console.WriteLine("Ultimas tres letras:..........." + nome.Substring(ultimasLetras));
            }

            


            //Calculo INSS
            Console.WriteLine($"O INSS é:............{salario * 0.11}");


            //Tirar os pontos e traços
            Console.WriteLine(cpf.Replace('-', ' ').Replace('.',' '));


            Console.ReadKey();
        }
    }
}
