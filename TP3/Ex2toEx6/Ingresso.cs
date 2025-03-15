using System;

namespace TP3.Ex2toEx6
{
    public class Ingresso
    {
        private string nomeDoShow;
        private double preco;
        private int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine($"Novo preço atualizado: {preco:C}");
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"Nova quantidade disponível: {quantidadeDisponivel}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Vai para la: {nomeDoShow}, Preço: {preco:C}, Quantidade disponível: {quantidadeDisponivel}");
        }
    }
}
