using System;

namespace TP3.Ex7toEx9
{
    public class Ex7toEx9Executar
    {
        public static void Executar()
        {
            Matricula matricula1 = new Matricula("Chaves", "Bloodborne", 2222, "22/02/2022");

            matricula1.ExibirInformacoes();

            matricula1.Trancar();
            matricula1.ExibirInformacoes();

            matricula1.Reativar();
            matricula1.ExibirInformacoes();

            Matricula matricula2 = new Matricula("Invicivel", "Vencivel", 100, "26/06/2026");
            matricula2.ExibirInformacoes();
        }
    }
}
