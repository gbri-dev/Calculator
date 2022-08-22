using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine("BEM VINDO!");
            Console.WriteLine("Qual Operação matematica você deseja? #obs: n para sair.");
            char operacao = Convert.ToChar(Console.ReadLine().ToLower());
            switch (operacao)
            {
                case '+':
                    Soma();
                    break;
                case '-':
                    Subtracao();
                    break;
                case '*':
                    Multiplicacao();
                    break;
                case '/':
                    Divisao();
                    break;
                case 'n':
                    System.Environment.Exit(0);
                    break;
                default:
                    {
                        Menu();
                        break;
                    }
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Entre com um número: #obs: Confirme com enter");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um número: #obs: Confirme com enter");
            float v2 = float.Parse(Console.ReadLine());

            //Primeira maneira
            //float resultado = v2 + v1;
            // Console.WriteLine("Escolha uma operação matematica: " + resultado);
            //Segunda maneira
            //Console.WriteLine($"O Meu Resultado é: {resultado}");
            //Terceira maneira
            //Console.WriteLine("O Meu Resultado é: " + (v1 + v2));
            //Por último
            Console.WriteLine($"O Meu Resultado é: {v1 + v2}");
            System.Console.WriteLine("---------");
            System.Console.WriteLine("Deseja fazer outra operação? S/N");
            char repeticao = Convert.ToChar(Console.ReadLine().ToLower());
            if (repeticao == 's')
                Menu();
            else
            {
                System.Console.WriteLine("Tchau!!");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"O Resultado da subtração é : {v1 - v2}");
            System.Console.WriteLine("---------");
            System.Console.WriteLine("Deseja fazer outra operação? Y/F");
            char repeticao = Convert.ToChar(Console.ReadLine().ToLower());
            if (repeticao == 's')
                Menu();
            else
                Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine($"O resultado da divisão é: {v1 / v2}");
            System.Console.WriteLine("---------");
            System.Console.WriteLine("Deseja fazer outra operação? Y/F");
            char repeticao = Convert.ToChar(Console.ReadLine());
            if (repeticao == 's' || repeticao == 'S')
                Menu();
            else
                Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            System.Console.WriteLine("Digite o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine($"O resultado da multiplicação é: {v1 * v2}");
            System.Console.WriteLine("---------");
            System.Console.WriteLine("Deseja fazer outra operação? Y/F");
            char repeticao = Convert.ToChar(Console.ReadLine().ToLower());
            if (repeticao == 's')
                Menu();
            else
                Console.ReadKey();
        }
    }


    // struct RetornaOperacao
    // {
    //     public RetornaOperacao(int v1, int v2, char operador, EOperacao operacao)
    //     {
    //         V1 = v1;
    //         V2 = v2;
    //         Operador = operador;
    //         Operacao = operacao;
    //     }

    //     public int V1;
    //     public int V2;

    //     public char Operador;

    //     EOperacao Operacao;
    //     // public char Calcular( EOperacao)
    //     // {

    //     //     switch (Operador)
    //     //     {
    //     //         case '+':
    //     //            Console.Write(V1 + V2);
    //     //             break;
    //     //     }
    //     // }
    // }

    // enum EOperacao
    // {
    //     Somar = '+',
    //     Subtrair = '-',
    //     Multiplicar = '*',
    //     Dividir = '/'
    // }
}
