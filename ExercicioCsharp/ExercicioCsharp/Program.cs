using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ExercicioCsharp
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
                Console.WriteLine("\n8 - Exercicio 7");
                Console.WriteLine("\n8 - Exercicio 8");
                Console.WriteLine("\n9 - Exercicio 9");
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
                    case 9:
                        Exercicio9();
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
            int soma, subtracao, multiplicacao, divisaointeira, potencia = 1;
            float resto, divisao;

            int a = 5;
            int b = 2;

            soma = a + b;
            subtracao = a - b;
            multiplicacao = a * b;
            divisao = 5f / 2f;
            divisaointeira = a / b;
            resto = (a % b) / 2;  //não entendi por que precisa dar 0.5 e não 1 
            for (int i = 1; i <= b; i++)
            {
                potencia *= a;
            };

            Console.WriteLine("\nSoma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);
            Console.WriteLine("Divisão Inteira: " + divisaointeira);
            Console.WriteLine("Resto: " + resto);
            Console.WriteLine("Potencia: " + potencia);
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio2()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva um Número: ");
            int IntConvertido = 0;
            float floatConvertido = 0;
            string numero = Console.ReadLine();

            if (int.TryParse(numero, out IntConvertido))
            {
                Console.WriteLine("\nInteiro");
            }
            if (float.TryParse(numero, out floatConvertido))
            {
                Console.WriteLine("\nFlutuante");
            }
            else
            {
                Console.WriteLine("Não é um número valido");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio3()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva um texto: \n");
            string texto = Console.ReadLine();
            int tamanho = texto.Length;
            string maiusculo = texto.ToUpper();
            string minusculo = texto.ToLower();

            Console.WriteLine("\n" + tamanho + " - " + minusculo + " - " + maiusculo);
            Console.WriteLine("---------------------------------------");

        }
        static void Exercicio4()
        {

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva o texto 1: \n");
            string texto = Console.ReadLine();
            Console.WriteLine("Escreva o texto 2: \n");
            string texto2 = Console.ReadLine();

            int count = (texto.Length - texto.Replace(texto2, "").Length);

            Console.WriteLine(count + " Ocorrencias!\n");
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio5()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva o texto: \n\n");
            string texto = Console.ReadLine();
            Char valor = '-';
            Boolean resultado = texto.Contains(valor);
            if (resultado == true)
            {
                string toBeSearched = "-";
                string code = texto.Substring(texto.IndexOf(toBeSearched) + toBeSearched.Length);
                Console.WriteLine(code);
            }
            else
            {
                DateTime hoje = DateTime.Today;
                Console.WriteLine(hoje.ToString() + " - " + texto);
            }
            Console.WriteLine("---------------------------------------");
        }

        static void Exercicio6()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva uma Data: ");
            string data = Console.ReadLine();
            DateTime dataconvertida;

            if (DateTime.TryParse(data, out dataconvertida))
            {
                Console.WriteLine("\n Data válida");
            }
            else
            {
                Console.WriteLine("Data Inválida");
            }
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio7()
        {
            Console.WriteLine("---------------------------------------");
            DateTime thisDate1 = new DateTime(2010, 01, 01, 15, 24, 16);
            Console.WriteLine("Dia " + thisDate1.ToString("dd") + " do mês " + thisDate1.ToString("MM") + " do ano " + thisDate1.ToString("yyyy") + ", as " + thisDate1.ToString("H") + thisDate1.ToString("mm") + thisDate1.ToString("ss"));
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio8()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escreva uma Data: ");
            DateTime datainicial = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Escreva uma Data: ");
            DateTime datafinal = DateTime.Parse(Console.ReadLine());

            TimeSpan ts = datafinal - datainicial;

            int diferencadias = ts.Days;
       
            int diferencahoras = ts.Hours;

            int diferencaminutos = ts.Minutes;

            int diferencasegundos = ts.Seconds;

            Console.WriteLine("\nDiferença em dias:" + diferencadias + "\nDiferença em horas:" + diferencahoras + "\nDiferença em minutos:" + diferencaminutos + "\nDiferença em segundos:" + diferencasegundos);
            Console.WriteLine("---------------------------------------");
        }
        static void Exercicio9()
        {
            Console.WriteLine("---------------------------------------");
            //DateTimeOffset thisDate2 = new DateTimeOffset(2003, 1, 2, 4, 5, 6, TimeSpan.Zero);
            //try { Console.WriteLine("The current date and time: {0:MM/dd/yyyy H:mm:ss }", thisDate2); }

            string[] dateValues = { "1, 2,2003,4,5,6", "1, 20,2003,4,5,6",
                              "2,3,2005,7,8,9", "17,05,2001,1,2,3" };
            string pattern = "dd,MM,yyyy,H,mm,ss";

            DateTime parsedDate;

            foreach (var dateValue in dateValues)
            {
                if (DateTime.TryParseExact(dateValue, pattern, null,
                                          DateTimeStyles.None, out parsedDate))
                    Console.WriteLine("Converted '{0}' to {1:d}.",
                                      dateValue, parsedDate);
                else
                    Console.WriteLine("Unable to convert '{0}' to a date and time.",
                                      dateValue);

                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
