using System;
using System.IO;

namespace AT.Ex11
{
    public class GerenciadorContatos
    {
        private const string CaminhoArquivo = "contatos.txt";


        public void AdicionarContato(string nome, string telefone, string email)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(CaminhoArquivo))
                {
                    sw.WriteLine($"{nome},{telefone},{email}");
                    Console.WriteLine("Contato cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar contato: {ex.Message}");
            }
        }


        public void ListarContatos()
        {
            try
            {
                if (File.Exists(CaminhoArquivo))
                {
                    string[] contatos = File.ReadAllLines(CaminhoArquivo);
                    if (contatos.Length == 0)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Contatos cadastrados:");
                        foreach (var contato in contatos)
                        {
                            var detalhes = contato.Split(',');
                            Console.WriteLine($"Nome: {detalhes[0]} | Telefone: {detalhes[1]} | Email: {detalhes[2]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar contatos: {ex.Message}");
            }
        }
    }
}
