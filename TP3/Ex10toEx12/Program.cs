using System;


namespace TP3.Ex10toEx12
{
    public class Ex10toEx12Executar
    {
        public static void Executar()
        {
            Circulo circulo = new Circulo(300.0);
            double areaCirculo = circulo.CalcularArea();
            Console.WriteLine($"Área do Círculo com raio {circulo.Raio}: {areaCirculo:F2}");

            Esfera esfera = new Esfera(5.0);
            double volumeEsfera = esfera.CalcularVolume();
            Console.WriteLine($"Volume da Esfera com raio {esfera.Raio}: {volumeEsfera:F2}");
        }
    }
}
