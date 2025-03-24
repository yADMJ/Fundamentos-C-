using System;
using System.IO;

namespace AT.Ex9
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }


        public void ExibirProduto()
        {
            Console.WriteLine($"Produto: {Nome} | Quantidade: {Quantidade} | Preço: R$ {Preco:F2}");
        }


        public static void SalvarProdutoEmArquivo(Produto produto)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("estoque.txt", true))
                {
                    writer.WriteLine($"{produto.Nome},{produto.Quantidade},{produto.Preco:F2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao salvar produto: {e.Message}");
            }
        }


        public static void ListarProdutos()
        {
            if (File.Exists("estoque.txt"))
            {
                var linhas = File.ReadAllLines("estoque.txt");
                if (linhas.Length == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                else
                {
                    foreach (var linha in linhas)
                    {
                        var dadosProduto = linha.Split(',');
                        var nome = dadosProduto[0];
                        var quantidade = int.Parse(dadosProduto[1]);
                        var preco = decimal.Parse(dadosProduto[2]);

                        var produto = new Produto(nome, quantidade, preco);
                        produto.ExibirProduto();
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
        }
    }

    public class Ex9Executar
    {
        public static void Executar()
        {
            Produto[] estoque = new Produto[5];
            int contador = 0;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Inserir Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");


                string escolha = Console.ReadLine();


                switch (escolha)
                {
                    case "1":
                        if (contador < 5)
                        {
                            Console.Write("Digite o nome do produto: ");
                            string nome = Console.ReadLine();

                            Console.Write("Digite a quantidade em estoque: ");
                            int quantidade = int.Parse(Console.ReadLine());

                            Console.Write("Digite o preço unitário: ");
                            decimal preco = decimal.Parse(Console.ReadLine());

                            Produto produto = new Produto(nome, quantidade, preco);
                            estoque[contador] = produto;

                            Produto.SalvarProdutoEmArquivo(produto);
                            contador++;

                            Console.WriteLine("Produto inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Limite de produtos atingido!");
                        }
                        break;

                    case "2":
                        Produto.ListarProdutos(); 
                        break;

                    case "3":
                        Console.WriteLine("Saindo...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }


                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
