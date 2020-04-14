using System;

namespace RationalNumbers
{
    public static class Program
    {
        static void Main()
        {
            IRationalNumber r1 = new RationalNumber(3, 6);
            Console.WriteLine($"This is the rational number r1: {r1}");

            IRationalNumber r2 = new RationalNumber(3, 8);
            Console.WriteLine($"This is the rational number r2: {r2}");

            // Addition
            Console.WriteLine();

            r1 += r2;
            Console.WriteLine($"The sum of r1 and r2, stored in r1, is: {r1}");

            // Subtraction
            Console.WriteLine();
            Console.WriteLine($"This is the rational number r1: {r1}");
            Console.WriteLine($"This is the rational number r2: {r2}");

            r1 -= r2;
            Console.WriteLine($"r1 minus r2, stored in r2, is: {r2}");

            // Division
            Console.WriteLine();
            Console.WriteLine($"This is the rational number r1: {r1}");
            Console.WriteLine($"This is the rational number r2: {r2}");

            r1 /= r2;
            Console.WriteLine($"r1 divided by r2, stored in r1, is: {r1}");

            // Multiplication
            Console.WriteLine();
            Console.WriteLine($"This is the rational number r1: {r1}");
            Console.WriteLine($"This is the rational number r2: {r2}");

            r2 *= r1;
            Console.WriteLine($"r1 multipied by r2, stored in r2, is: {r2}");

            // Absolute value of a given rational number
            Console.WriteLine();
            r1 = new RationalNumber(-3, 4);
            Console.WriteLine($"This is the rational number r1: {r1}");

            r2 = r1.Abs();
            Console.WriteLine($"The absolute value of rational number r1 is: {r2}");

            // Exponentiation rational
            Console.WriteLine();
            Console.WriteLine($"This is the rational number r1: {r1}");

            r2 = r1.ExpRational(4);
            Console.WriteLine($"4 to the power r1 is: {r2}");

            // Exponentiation real
            Console.WriteLine();
            Console.WriteLine($"This is the rational number r1: {r1}");

            double e = r1.ExpReal(0.3);
            Console.WriteLine($"r1 to the power 0.3 is: {e}");

            // Exponentiation of a real number to a rational number
            Console.WriteLine();
            Console.WriteLine($"This is the rational number r1: {r1}");
            double n = 2.5;
            Console.WriteLine($"This is the real number n: {n}");

            n = n.ExpReal(r1);
            Console.WriteLine($"This is the real number n to the power of r1: {n}");


        }
    }
}
