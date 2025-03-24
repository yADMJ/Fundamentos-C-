using System;

namespace AT.Ex10
{
    public class Jogo
    {
        private int numeroCorreto;
        private int tentativas;
        private const int tentativasMaximas = 5;


        public Jogo()
        {
            Random random = new Random();
            numeroCorreto = random.Next(1, 51); 
            tentativas = tentativasMaximas;
        }


        public void IniciarJogo()
        {
            Console.WriteLine("Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar um número entre 1 e 50.");
            Console.WriteLine($"Você tem {tentativasMaximas} tentativas.");


            while (tentativas > 0)
            {
                Console.Write("\nDigite seu palpite: ");
                string entrada = Console.ReadLine();


                if (Validacao.ValidarEntrada(entrada, out int palpite))
                {
                    if (palpite < 1 || palpite > 50)
                    {
                        Console.WriteLine("Erro: O número deve estar entre 1 e 50.");
                        continue;
                    }

                    if (palpite == numeroCorreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número!");
                        break;
                    }
                    else if (palpite > numeroCorreto)
                    {
                        Console.WriteLine("O número correto é menor.");
                    }
                    else
                    {
                        Console.WriteLine("O número correto é maior.");
                    }

                    tentativas--;
                    Console.WriteLine($"Tentativas restantes: {tentativas}");

                    if (tentativas == 0)
                    {
                        Console.WriteLine($"Você perdeu! O número correto era {numeroCorreto}.");
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Por favor, digite um número válido.");
                }
            }
        }
    }
}
