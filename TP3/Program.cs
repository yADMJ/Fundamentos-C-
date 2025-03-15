using System;
using TP3.Ex1;
using TP3.Ex2toEx6;
using TP3.Ex7toEx9;
using TP3.Ex10toEx12;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha qual exercício deseja executar:");
        Console.WriteLine("1 - Ex1");
        Console.WriteLine("2 - Ex2toEx6");
        Console.WriteLine("3 - Ex7toEx9");
        Console.WriteLine("4 - Ex10toEx12");
        Console.Write("Digite o número correspondente: ");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Ex1Executar.Executar();
                break;
            case "2":
                Ex2toEx6Executar.Executar();
                break;
            case "3":
                Ex7toEx9Executar.Executar();
                break;
            case "4":
                Ex10toEx12Executar.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
