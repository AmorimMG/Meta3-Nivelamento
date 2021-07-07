using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("\n8 - Exercicio 8");
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
                    case 8:
                        Exercicio8();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }

            } while (opcao != 0);

            return 0;
        }
    }
}
