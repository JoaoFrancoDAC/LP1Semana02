using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo:");
            string num = Console.ReadLine();
            byte n = Convert.ToByte(num);
            Console.WriteLine($"{n / 3}");
            Console.WriteLine($"{n << 3}");
            Console.WriteLine($"{n ^ 6}");
            Console.WriteLine($"{n > 10}");
        }
    }
}
