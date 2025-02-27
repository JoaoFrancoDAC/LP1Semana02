using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro:");
            string num = Console.ReadLine();
            sbyte n = Convert.ToSByte(num);
            n = --n;
            Console.WriteLine($"{n}");
            n = ++n;
            Console.WriteLine($"{n}");
            
            

        }
    }
}
