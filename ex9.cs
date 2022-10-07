using System;

namespace Projeto_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9");

            //Variáveis
            int diaDaSemana;

            //Entrada de dados
            Console.WriteLine("Digite um dia da semana:");
            diaDaSemana = int.Parse(Console.ReadLine());

            //Saída de dados
            if (diaDaSemana == 0)
            {
                Console.WriteLine("Hoje é Domingo.");
            }
            else
            {
                if (diaDaSemana == 1)
                {
                    Console.WriteLine("Hoje é Segunda.");
                }
                else
                {
                    if (diaDaSemana == 2)
                    {
                        Console.WriteLine("Hoje é Terça.");
                    }
                    else
                    {
                        if (diaDaSemana == 3)
                        {
                            Console.WriteLine("Hoje é Quarta.");
                        }
                        else
                        {
                            if (diaDaSemana == 4)
                            {
                                Console.WriteLine("Hoje é Quinta."); 
                            }
                            else
                            {
                                if (diaDaSemana == 5)
                                {
                                    Console.WriteLine("Hoje é Sexta.");
                                }
                                else
                                {
                                    if (diaDaSemana == 6)
                                    {
                                        Console.WriteLine("Hoje é Sábado.");
                                    }
                                    else
                                    {
                                        if (diaDaSemana < 0 || diaDaSemana > 6)
                                        {
                                            Console.WriteLine("Não existe.");
                                        }
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
