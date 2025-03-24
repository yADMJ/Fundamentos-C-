using System;

namespace AT.Ex5
{
    public class Ex5Executar
    {
        public static void Executar()
        {
            DateTime dataFormatura = new DateTime(2028, 12, 01);


            Console.Write("Digite a data atual (dd/MM/yyyy): ");
            string entradaData = Console.ReadLine();


            DateTime dataAtual;
            if (!DateTime.TryParseExact(entradaData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataAtual))
            {
                Console.WriteLine("Formato inválido! Certifique-se de usar o formato dd/mm/yyyy.");
                return;
            }

         
            if (dataAtual > DateTime.Now)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }


            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Ué tu ja não ta formado");
                return;
            }

       
            TimeSpan diferenca = dataFormatura - dataAtual;
            int anos = diferenca.Days / 365;
            int meses = (diferenca.Days % 365) / 30;
            int dias = (diferenca.Days % 365) % 30;

  
            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");

     
            if (anos == 0 && meses < 6)
            {
                Console.WriteLine("Tá terminando aguenta ai.");
            }
        }
    }
}