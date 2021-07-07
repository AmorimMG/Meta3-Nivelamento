using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Estrutura_While
{
    class Program
    {
        static int Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMenu de Exercicios!");
                Console.WriteLine("\n1 - Exercicio 1");
                Console.WriteLine("\n2 - Exercicio 2");
                Console.WriteLine("\n3 - Exercicio 3");
                Console.WriteLine("\n0 - Sair \n");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }

            } while (opcao != 0);

            return 0;
        }

        static void Exercicio1()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva a senha: ");
            int senha = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("SENHA INVALIDA");
                Console.WriteLine("Escreva a senha: ");
                senha = int.Parse(Console.ReadLine());
            } while (senha != 2002);
            Console.WriteLine("ACESSO PERMETIDO");
            Console.WriteLine("---------------------------------------");
        }

        static void Exercicio2()
        {

            Console.WriteLine("---------------------------------------");
            float x, y;
            do
            {
                Console.WriteLine("Digite o valor de X: ");
                  x = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y: ");
                  y = float.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    Console.WriteLine("ORIGEM");
                }
            } while (x != 0 && y != 0) ;
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio3()
        {
            int produtos;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            do
            {
                Console.WriteLine("Digite (1-4)");
                produtos = int.Parse(Console.ReadLine());

                if (produtos == 1)
                {
                    alcool++;

                    Console.WriteLine("Alcool :" + alcool );
                }
                else if (produtos == 2)
                {
                    gasolina++;
                    Console.WriteLine("Gasolina: " + gasolina);
                }
                else if (produtos == 3)
                {
                    diesel++;
                    Console.WriteLine("Diesel: " + diesel);
                }
                else if (produtos == 4)
                {
                    Console.WriteLine("FIM");
                }
            } while (produtos != 4);
            Console.WriteLine("MUITO OBRIGADO");
        }
    }
}
