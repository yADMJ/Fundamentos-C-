using System;
using System.Collections.Generic;
using System.IO;

namespace AT.Ex12
{
    public class GerenciadorContatos
    {
        private const string CaminhoArquivo = "contatos.txt";


        public List<Contato> CarregarContatos()
        {
            List<Contato> contatos = new List<Contato>();

            if (File.Exists(CaminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(CaminhoArquivo);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    if (dados.Length == 3)
                    {
                        contatos.Add(new Contato(dados[0], dados[1], dados[2]));
                    }
                }
            }

            return contatos;
        }


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
    }
}
