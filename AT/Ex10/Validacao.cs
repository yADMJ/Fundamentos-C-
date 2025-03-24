using System;

namespace AT.Ex10
{
    public static class Validacao
    {
        public static bool ValidarEntrada(string entrada, out int numero)
        {
            if (int.TryParse(entrada, out numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
