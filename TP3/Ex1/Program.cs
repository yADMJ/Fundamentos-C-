using System;

namespace TP3.Ex1
{
    public class Carro
    {
        public string cor;
        public string modelo;
        public int velocidade;

        public void Ligar()
        {
            Console.WriteLine("O carro foi ligado.");
        }

        public void Acelerar(int incremento)
        {
            velocidade += incremento;
            Console.WriteLine($"{modelo} acelerou para {velocidade} km/h.");
        }
    }

    public class Ex1Executar
    {
        public static void Executar()
        {
            Carro meuCarro = new Carro();

            meuCarro.cor = "Prata";
            meuCarro.modelo = "Kwid";
            meuCarro.velocidade = 0;

            meuCarro.Ligar();
            meuCarro.Acelerar(69);
        }
    }
}
