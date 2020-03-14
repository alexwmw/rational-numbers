using System;

namespace RationalNumbers
{
    public static class Program
    {
        static void Main()
        {
            RationalNumber r = new RationalNumber(3, 6);
            Console.WriteLine($"This is the rational number: {r}");

            new RationalNumber(3,6).Reduce();

            Console.WriteLine($"This is the rational number: {r} reduced");

        }
    }
}
