using System;
using AT.Ex1;
using AT.Ex2;
using AT.Ex3;
using AT.Ex4;
using AT.Ex5;
using AT.Ex6;
using AT.Ex7;
using AT.Ex8;
using AT.Ex9;
using AT.Ex10;
using AT.Ex11;
using AT.Ex12;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha qual programa deseja executa: do 1 ao 12(exercicio 1 ao 12 respectitivamente");
        Console.Write("Digite o número correspondente: ");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Ex1Executar.Executar();
                break;
            case "2":
                Ex2Executar.Executar();
                break;
            case "3":
                Ex3Executar.Executar();
                break;
            case "4":
                Ex4Executar.Executar();
                break;
            case "5":
                Ex5Executar.Executar();
                break;
            case "6":
                Ex6Executar.Executar();
                break;
            case "7":
                Ex7Executar.Executar();
                break;
            case "8":
                Ex8Executar.Executar();
                break;
            case "9":
                Ex9Executar.Executar();
                break;
            case "10":
                Ex10Executar.Executar();
                break;
            case "11":
                Ex11Executar.Executar();
                break;
            case "12":
                Ex12Executar.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
