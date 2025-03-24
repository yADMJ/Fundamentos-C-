using System;

namespace AT.Ex6
{
    public class Ex6Executar
    {
        public static void Executar()
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "John",    
                Matricula = "222222",  
                Curso = "Bloodborne",   
                MediaNotas = 8.5        
            };

            
            aluno1.ExibirDados();

            
            string situacao = aluno1.VerificarAprovacao();
            Console.WriteLine("Situação: " + situacao);
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double MediaNotas { get; set; }


        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("Média das Notas: " + MediaNotas);
        }


        public string VerificarAprovacao()
        {
            if (MediaNotas >= 7)
            {
                return "Tu passou";
            }
            else
            {
                return "Burro repete ai";
            }
        }
    }
}
