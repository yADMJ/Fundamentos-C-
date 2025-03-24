using AT.Ex12;
using System;
using System.Collections.Generic;

namespace AT.Ex12
{
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("## Lista de Contatos\n");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"- Nome: {contato.Nome}");
                Console.WriteLine($"  Telefone: {contato.Telefone}");
                Console.WriteLine($"  Email: {contato.Email}\n");
            }
        }
    }
}
