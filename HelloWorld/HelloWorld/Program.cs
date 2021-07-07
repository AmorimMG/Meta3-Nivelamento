using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros2();
            //Numeros();
            //teste();
            //PedraPapelTesoura();
            //arrays();
            //Calcula();
            Console.ReadLine();
        }

        static void Numeros()
        {
            int soma, subtracao, multiplicacao, divisaointeira, potencia = 1;
            float resto, divisao;

            int a = 5;
            int b = 2;

            soma = a + b;
            subtracao = a - b;
            multiplicacao = a * b;
            divisao = 5f / 2f;
            divisaointeira = a / b;
            resto = (a % b)/2;  //não entendi por que precisa dar 0.5 e não 1 
            for (int i = 1; i <= b; i++)
            {
                potencia *= a;
            };

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);
            Console.WriteLine("Divisão Inteira: " + divisaointeira);
            Console.WriteLine("Resto: " + resto);
            Console.WriteLine("Potencia: " + potencia);

        }

        static void Numeros2()
        {
            Console.WriteLine("Escreva um Número: ");
            string str_var = (Console.ReadLine());
            try
            {
                int num_var = Int32.Parse(str_var);
                System.Console.WriteLine(num_var);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Não é um numero valido");
            }

        }
        static void Calcula()
        {
            int a, b;
            Console.WriteLine("Escreva o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A > B");
                Console.Write(" O valor de A é " + a);
                Console.Write(" O valor de B é " + b);
            }
            else if (b > a)
            {
                Console.WriteLine("B > A");
                Console.Write(" O valor de A é " + a);
                Console.Write(" O valor de B é " + b);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        static void arrays()
        {
            int funcionario;
            Console.Write("\n Escreva o número do Estagiario (0-7) : \n0 - Amorim\n1 - Pedro\n2 - Heitor\n3 - Marcus\n4 - Daniel\n5 - Bison\n6 - Leo\n7 - Caio\n");
            funcionario = int.Parse(Console.ReadLine());


            string[] estagiarios = new string[8] {
            "Amorim",
            "Pedro",
            "Heitor",
            "Marcus",
            "Daniel",
            "Bison",
            "Leo",
            "Caio"
            };
            Console.WriteLine(estagiarios[funcionario]);
        }
        enum estagiario { Amorim = 1, Pedro, Heitor, Marcus, Daniel, Bison, Leo, Caio }
        static void teste()
        {
            Console.WriteLine("\n Escreva o número do Estagiario (1-8) : \n1 - Amorim\n2 - Pedro\n3 - Heitor\n4 - Marcus\n5 - Daniel\n6 - Bison\n7 - Leo\n8 - Caio\n");
            int index = int.Parse(Console.ReadLine());
            estagiario estagiarioescolhido = (estagiario)index;
            Console.WriteLine(estagiarioescolhido);

        }
        static void PedraPapelTesoura()
        {
            Console.WriteLine("Lance Pedra, Papel ou Tesoura:");
            string lancamentousuario = Console.ReadLine();
            switch (lancamentousuario)
            {
                case "Pedra":
                    Console.WriteLine("Você lançou Pedra!");
                    break;
                case "Papel":
                    Console.WriteLine("Você lançou Papel!");
                    break;
                case "Tesoura":
                    Console.WriteLine("Você lançou Tesoura!");
                    break;
                default:
                    Console.WriteLine("Você não digitou corretamente!");
                    break;
            }

            Random rnd = new Random();
            string[] lancamentobot = { "Pedra", "Papel", "Tesoura" };
            int jogadabot = rnd.Next(0, lancamentobot.Length);

            // Utilizando switch
            switch (lancamentobot[jogadabot])
            {
                case "Pedra":
                    Console.WriteLine("O bot jogou Pedra!");
                    break;
                case "Papel":
                    Console.WriteLine("O bot jogou Papel!");
                    break;
                case "Tesoura":
                    Console.WriteLine("O bot jogou Tesoura!");
                    break;
                default:
                    Console.WriteLine("Ocorreu um erro com o bot!");
                    break;
            }

            if (lancamentobot[jogadabot] == lancamentousuario)
            {
                Console.WriteLine("Vocês empataram!");
            }
            else if (lancamentobot[jogadabot] == "Papel" && lancamentousuario == "Pedra")
            {
                Console.WriteLine("O bot venceu!");
            }
            else if (lancamentobot[jogadabot] == "Papel" && lancamentousuario == "Tesoura")
            {
                Console.WriteLine("O Usuario venceu!");
            }
            else if (lancamentobot[jogadabot] == "Tesoura" && lancamentousuario == "Pedra")
            {
                Console.WriteLine("O Usuario venceu!");
            }
            else if (lancamentobot[jogadabot] == "Tesoura" && lancamentousuario == "Papel")
            {
                Console.WriteLine("O bot venceu!");
            }
            else if (lancamentobot[jogadabot] == "Pedra" && lancamentousuario == "Papel")
            {
                Console.WriteLine("O Usuario venceu!");
            }
            else if (lancamentobot[jogadabot] == "Pedra" && lancamentousuario == "Tesoura")
            {
                Console.WriteLine("O bot venceu!");
            }
            else{
                Console.WriteLine("Falha no sistema!");
            }
        }
    }
}
