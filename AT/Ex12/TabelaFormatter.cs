using AT.Ex12;
using System;
using System.Collections.Generic;

namespace AT.Ex12
{
    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome             | Telefone        | Email           |");
            Console.WriteLine("----------------------------------------");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato.Nome,-16} | {contato.Telefone,-15} | {contato.Email,-15} |");
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
