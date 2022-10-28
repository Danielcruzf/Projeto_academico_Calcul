using System;
namespace calculator
{
    class program
    {

        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            int V1 = 0, V2 = 0, resul = 0, valor = 0;
            Console.WriteLine("Que operação o deseja realizar");// escolhendo que operação
            Console.WriteLine("Digite 1 para SOMA: ");
            Console.WriteLine("Digite 2 para SUBITRAÇÃO: ");
            Console.WriteLine("Digite 3 para MULTIPLICAÇÃO: ");
            Console.WriteLine("Digite 4 para DIVISÃO: ");
            Console.WriteLine("Digite 0 vezes para sair: ");
            valor = int.Parse(Console.ReadLine());//recebemdo o parametro do menu
            switch (valor)
            {
                case 1: resul = V1 + V2; break;
                case 2: resul = V1 - V2; break;
                case 3: resul = V1 * V2; break;
                case 4: resul = V1 / V2; break; // conversão de int p double
                case 0: System.Environment.Exit(0); break;
                default:
                    Menu(); break;
                    Console.WriteLine("Digite o Primeiro Valor: "); // coletando o pimeiro valor
                    V1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Valor: ");// coletando o segundo valor
                    V2 = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("O Resultado é " + resul);
            Menu();

        }
    }
}

