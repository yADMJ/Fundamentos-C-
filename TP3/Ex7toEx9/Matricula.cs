using System;

namespace TP3.Ex7toEx9
  { 
    public class Matricula
    {
        private string nomeDoAluno;
        private string curso;
        private int numeroMatricula;
        private string situacao;
        private string dataInicial;

        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string dataInicial)
        {
            this.nomeDoAluno = nomeDoAluno;
            this.curso = curso;
            this.numeroMatricula = numeroMatricula;
            this.situacao = "Ativa"; 
            this.dataInicial = dataInicial;
        }

        public void Trancar()
        {
            situacao = "Trancada";
            Console.WriteLine($"Matrícula {numeroMatricula} foi trancada.");
        }

        public void Reativar()
        {
            situacao = "Ativa";
            Console.WriteLine($"Matrícula {numeroMatricula} foi reativada.");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("===== Informações da Matrícula =====");
            Console.WriteLine($"Aluno: {nomeDoAluno}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Número da Matrícula: {numeroMatricula}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine($"Data de Início: {dataInicial}");
            Console.WriteLine("====================================\n");
        }
    }
}
