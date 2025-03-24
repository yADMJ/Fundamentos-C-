using AT.Ex12;
using System;
using System.Collections.Generic;

namespace AT.Ex12
{
    public class Ex12Executar
    {
        public static void Executar()
        {
            GerenciadorContatos gerenciador = new GerenciadorContatos();
            List<Contato> contatos = gerenciador.CarregarContatos();


            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        gerenciador.AdicionarContato(nome, telefone, email);
                        break;
                    case "2":
                        Console.WriteLine("Escolha o formato de exibição:");
                        Console.WriteLine("1 - Markdown");
                        Console.WriteLine("2 - Tabela");
                        Console.WriteLine("3 - Texto Puro");
                        Console.Write("Digite o número correspondente: ");
                        string formatoEscolhido = Console.ReadLine();
                        ContatoFormatter formatter = null;

                        switch (formatoEscolhido)
                        {
                            case "1":
                                formatter = new MarkdownFormatter();
                                break;
                            case "2":
                                formatter = new TabelaFormatter();
                                break;
                            case "3":
                                formatter = new RawTextFormatter();
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                continue;
                        }

                        formatter.ExibirContatos(contatos);
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }


                if (!sair)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
