using System;

namespace AT.Ex3
{
    public class Ex3Executar
    {
        public static void Executar()
        {
            Console.Write("Digite algum numero ae: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("NUMERO CABAÇO.");
                return;
            }


            Console.Write("Digite de novo: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("NUMERO CABAÇO.");
                return;
            }


            Console.WriteLine("Escolha a operação matemática:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite o número correspondente: ");


            string escolha = Console.ReadLine();
            double resultado = 0;
            bool operacaoValida = true;


            switch (escolha)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado da soma: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Por zero não.");
                        operacaoValida = false;
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado da divisão: {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("1 AO 4 ESCOLHE CERTO KARAI");
                    operacaoValida = false;
                    break;
            }


            if (operacaoValida)
            {
                Console.WriteLine("Operação realizada com sucesso!");
            }
        }
    }
}
