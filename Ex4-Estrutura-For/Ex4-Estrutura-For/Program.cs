using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Estrutura_For
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
                Console.WriteLine("\n4 - Exercicio 4");
                Console.WriteLine("\n5 - Exercicio 5");
                Console.WriteLine("\n6 - Exercicio 6");
                Console.WriteLine("\n7 - Exercicio 7");
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
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        Exercicio7();
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
            Console.WriteLine("\nEscreva um número: \n");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("\n" + i);

                }
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio2()
        {

        }
        static void Exercicio3()
        {

        }
        static void Exercicio4()
        {

        }
        static void Exercicio5()
        {

        }
        static void Exercicio6()
        {

        }
        static void Exercicio7()
        {

        }
    }
}
