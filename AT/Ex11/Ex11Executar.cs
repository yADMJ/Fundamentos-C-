using AT.Ex11;

namespace AT.Ex11
{
    public class Ex11Executar
    {
        public static void Executar()
        {
            GerenciadorContatos gerenciador = new GerenciadorContatos();
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
                        gerenciador.ListarContatos();
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
