using System;


namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Qual altura do cilindro?");
            String alturaString = Console.ReadLine();
            double altura = Convert.ToDouble(alturaString);

            Console.WriteLine("Qual raio do cilindro?");
            String raioString = Console.ReadLine();
            double raio = Convert.ToDouble(raioString);

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            double areaSuperficie = 2 * Math.PI * raio * altura;
            Console.WriteLine($"Volume do cilindro: {volume}");
            Console.WriteLine($"Area de superfície do cilindro: {areaSuperficie}");



        }
    }
}
