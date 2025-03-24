using System;

namespace AT.Ex2
{
    public class Ex2Executar
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome cabaço: ");
            string nome = Console.ReadLine();
            char[] nomeDeslocado = new char[nome.Length];

            for (int i = 0; i < nome.Length; i++)
            {
                char c = nome[i];
                if (char.IsLetter(c))
                {
                    char deslocado = (char)(c + 2);
                    if ((char.IsUpper(c) && deslocado > 'Z') || (char.IsLower(c) && deslocado > 'z'))
                    {
                        deslocado -= (char)26;
                    }
                    nomeDeslocado[i] = deslocado;
                }
                else
                {
                    nomeDeslocado[i] = c;
                }
            }

            Console.WriteLine("Nome maculado: " + new string(nomeDeslocado));
        }
    }
}

