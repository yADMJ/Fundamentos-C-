using System;

namespace AT.Ex4
{
    public class Ex4Executar
    {
        public static void Executar()
        {
            Console.Write("Digite sua data de nascimento (dd/mm/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
            {
                Console.WriteLine("Formato inválido! Certifique-se de usar o formato dd/mm/yyyy.");
                return;
            }


            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);


            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }


            int diasFaltantes = (proximoAniversario - hoje).Days;


            Console.WriteLine($"Faltam {diasFaltantes} dias para seu próximo aniversário!");


            if (diasFaltantes < 7)
            {
                Console.WriteLine("Ta ficando velho daqui a pouco ein");
            }
        }
    }
}
