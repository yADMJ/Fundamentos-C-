using System;

namespace TP3.Ex2toEx6
{
    public class Ex2toEx6Executar
    {
        public static void Executar()
        {
         Ingresso ingresso = new Ingresso("Fromsoftware", 650.49, 6);

            ingresso.ExibirInformacoes();

            ingresso.AlterarPreco(100.00);
            ingresso.AlterarQuantidade(9);

            ingresso.ExibirInformacoes();

            ingresso.SetPreco(10.00);
            ingresso.SetQuantidadeDisponivel(1);

            Console.WriteLine($"Vai para la: {ingresso.GetNomeDoShow()}");
            Console.WriteLine($"Preço atualizado: {ingresso.GetPreco():C}");
            Console.WriteLine($"Quantidade disponível: {ingresso.GetQuantidadeDisponivel()}");

            Ingresso ingresso2 = new Ingresso("Drak souls 2", 1000.00, 1);
            ingresso2.ExibirInformacoes();
        }
    }
}
