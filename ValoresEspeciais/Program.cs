using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"{byte.MinValue}");
            Console.WriteLine($"{byte.MaxValue}");
            Console.WriteLine($"{sbyte.MinValue}");
            Console.WriteLine($"{sbyte.MaxValue}");
            Console.WriteLine($"{short.MinValue}");
            Console.WriteLine($"{short.MaxValue}");
            Console.WriteLine($"{int.MinValue}");
            Console.WriteLine($"{int.MaxValue}");
            Console.WriteLine($"{long.MinValue}");
            Console.WriteLine($"{long.MaxValue}");
            Console.WriteLine($"{float.MinValue}");
            Console.WriteLine($"{float.MaxValue}");
            Console.WriteLine($"{double.MinValue}");
            Console.WriteLine($"{double.MaxValue}");
            Console.WriteLine($"{decimal.MinValue}");
            Console.WriteLine($"{decimal.MaxValue}");
            Console.WriteLine($"{char.MinValue}");
            Console.WriteLine($"{char.MaxValue}");
            Console.WriteLine($"{ulong.MinValue}");
            Console.WriteLine($"{ulong.MaxValue}");
            Console.WriteLine($"{float.PositiveInfinity}");
            Console.WriteLine($"{float.NegativeInfinity}");
            Console.WriteLine($"{float.NaN}");
            Console.WriteLine($"{double.PositiveInfinity}");
            Console.WriteLine($"{double.NegativeInfinity}");
            Console.WriteLine($"{double.NaN}");

            // Overflow 
            uint uintMax = uint.MaxValue;
            Console.WriteLine($"{uintMax}");
            uintMax++;
            Console.WriteLine($"{uintMax}");

            float floatMax = float.MaxValue;
            Console.WriteLine($"{floatMax}");
            floatMax++;
            Console.WriteLine($"{floatMax}");

            float floatMaxDois = float.MaxValue;
            Console.WriteLine($"{floatMaxDois}");
            floatMaxDois*=2;
            Console.WriteLine($"{floatMaxDois}");



        }
    }
}
