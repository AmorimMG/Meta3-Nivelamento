using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Estrutura_Sequencial
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
                Console.WriteLine("\n4 - Exercicio 5");
                Console.WriteLine("\n4 - Exercicio 6");
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
                        default:
                            Console.WriteLine("Opcao invalida");
                            break;
                    }

                } while (opcao != 0) ;

            return 0;
        }

        static void Exercicio1()
        {
            Console.WriteLine("---------------------------------------");
            int soma;

            Console.WriteLine("Escreva o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de B: ");
            int b = int.Parse(Console.ReadLine());


            soma = a + b;

            Console.WriteLine("\nSoma: " + soma);
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio2()
        {
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escreva o valor de raio: ");
            float raio = float.Parse(Console.ReadLine());

            float pi = 3.14159f;

            float formula = (pi * (raio * raio));

            Console.WriteLine("O resultado é: " + formula);

            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio3()
        {
            Console.WriteLine("Escreva o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine("O resultado é: " + diferenca);

            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio4()
        {
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Escreva o numero do funcionario: ");
            float numero = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor por hora trabalhada do funcionario: ");
            float valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o a quantidade de horas trabalhadas do funcionario: ");
            float horas = float.Parse(Console.ReadLine());

            float salario = horas * valor;

            Console.WriteLine("O Número do funcionario é: " + numero);
            Console.WriteLine("O Salario do funcionario é  U$D: " + salario);

            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio5()
        {
            Console.WriteLine("Escreva o código da peça 1: ");
            float codigo1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o numero de peças 1: ");
            float quantidade1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor da peça 1: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o código da peça 2: ");
            float codigo2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o numero de peças 2: ");
            float quantidade2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor da peça 2: ");
            float valor2 = float.Parse(Console.ReadLine());

            float total1 =  quantidade1 * valor1;
            float total2 = quantidade2 * valor2;
            float total = total1 + total2;

            Console.WriteLine("VALOR A PAGAR: " + total);

            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio6()
        {
            Console.WriteLine("Escreva o valor de A: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de B: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor de C: ");
            float c = float.Parse(Console.ReadLine());

            float pi = 3.14159f;

            float areatriangulo = (a * c) / 2;
            float areacirculo = pi * (c * c);
            float areatrapezio = ((a + b) * c) / 2;
            float areaquadrado = b * b;
            float arearetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areatriangulo + "\nCIRCULO: " + areacirculo + "\nTRAPEZIO: " + areatrapezio + "\nQUADRADO: " + areaquadrado + "\nRETANGULO: " + arearetangulo);

        }
    }
}
