using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Estrutura_Condicional
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

        static void Exercicio1()
        {
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escreva um número: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine("\nNAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("\nNegativo");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio2()
        {
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escreva um número: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("\nPAR");
            }
            else
            {
                Console.WriteLine("\nIMPAR");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio3()
        {
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escreva o número 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o número 2: ");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("\nSAO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("\nNAO SAO MULTIPLOS");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio4()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva a hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio5()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Digite o código do item: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            float total;
            float cachorro = 4;
            float xsalada = 4.50f;
            float xbacon = 5;
            float torrada = 2;
            float refrigerante = 1.5f;

            if (codigo == 1)
            {
                total = quantidade * cachorro;
                Console.WriteLine("R$" + total);
            }
            else if (codigo == 2)
            {
                total = quantidade * xsalada;
                Console.WriteLine("R$" + total);
            }
            else if (codigo == 3)
            {
                total = quantidade * xbacon;
                Console.WriteLine("R$" + total);
            }
            else if (codigo == 4)
            {
                total = quantidade * torrada;
                Console.WriteLine("R$" + total);
            }
            else if (codigo == 5)
            {
                total = quantidade * refrigerante;
                Console.WriteLine("R$" + total);
            }
            else
            {
                Console.WriteLine("ITEM FORA DO MENU");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio6()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero < 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero >= 25 && numero < 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (numero >= 50 && numero < 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (numero >= 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("fora do intervalo");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio7()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Digite o valor de X: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            float y = float.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Quadrante 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Quadrante 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Quadrante 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quadrante 4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("ORIGEM");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio8()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Digite a sua renda: ");
            float renda = float.Parse(Console.ReadLine());

            float imposto,imposto1,imposto2,imposto3;
            imposto1 = 0.08f;
            imposto2 = 0.18f;
            imposto3 = 0.28f;

            if (renda <= 2000)
            {
                Console.WriteLine("ISENTO");
            }
            else if (renda <= 3000)
            {   
                imposto = (renda - 2000) * imposto1;
                Console.WriteLine("Você deve pagar 8% de imposto totalizando R$ " + imposto);
            }
            else if (renda <= 4500)
            {
                imposto = (renda - 3000) * imposto2 + 1000 * imposto1;
                Console.WriteLine("Você deve pagar 18% de imposto totalizando R$ " + imposto);
            }
            else
            {
                imposto = (renda - 4500) * imposto3 + 1500 * imposto2 + 1000 * imposto1;
                Console.WriteLine("Você deve pagar 28% de imposto totalizando R$ " + imposto);
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
