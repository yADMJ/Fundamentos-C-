using System;

namespace AT.Ex7
{
    public class Ex7Executar
    {
        public static void Executar()
        {
            ContaBancaria conta = new ContaBancaria("João Silva");

            conta.Depositar(100000);
            conta.ExibirSaldo();

            conta.Sacar(88900);  

            conta.Sacar(100);
            conta.ExibirSaldo();
        }
    }


    public class ContaBancaria
    {
        public string Titular { get; set; }
        private decimal Saldo { get; set; }

 
        public ContaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }


        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
        }


        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
        }


        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }
}

