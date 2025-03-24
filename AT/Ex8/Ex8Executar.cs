using System;


namespace AT.Ex8
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        public Funcionario(string nome, string cargo, decimal salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }


        public virtual void ExibirSalario()
        {
            Console.WriteLine($"{Nome} ({Cargo}): R$ {SalarioBase:F2}");
        }
    }


    public class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, decimal salarioBase)
            : base(nome, cargo, salarioBase)
        {
        }


        public override void ExibirSalario()
        {
            decimal salarioComBonus = SalarioBase * 1.2m;
            Console.WriteLine($"{Nome} ({Cargo}): R$ {salarioComBonus:F2} (com bônus de 20%)");
        }
    }


    public class Ex8Executar
    {
        public static void Executar()
        {
            Funcionario funcionario = new Funcionario("John", "Bloodborne", 10000);
            Gerente gerente = new Gerente("Fire Kepeer", "Dark Souza", 100);

            
            funcionario.ExibirSalario(); 
            gerente.ExibirSalario();
        }
    }
}
