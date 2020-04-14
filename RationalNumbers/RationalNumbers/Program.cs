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

            r1 += r2;
            Console.WriteLine($"The sum of r1 and r2, stored in r1, is: {r1}");

            // Subtraction

            Console.WriteLine($"This is the rational number r1: {r1}");
            Console.WriteLine($"This is the rational number r2: {r2}");

            r1 -= r2;
            Console.WriteLine($"r1 minus r2, stored in r2, is: {r2}");


            // Division

            Console.WriteLine($"This is the rational number r1: {r1}");
            Console.WriteLine($"This is the rational number r2: {r2}");

            r1 /= r2;
            Console.WriteLine($"r1 divided by r2, stored in r1, is: {r1}");

            // Multiplication

            Console.WriteLine($"This is the rational number r1: {r1}");
            Console.WriteLine($"This is the rational number r2: {r2}");

            r2 *= r1;
            Console.WriteLine($"r1 multipied by r2, stored in r2, is: {r2}");


            // Absolute value of a given rational number

            // Exponentiation of a given rational number to an integer power

            // Exponentiation of a given rational number to a real(floating - point) power

            // Exponentiation of a real number to a rational number


            // All rational numbers should be immutable.

            // The denominator may not be zero.

            // The denominator should never be negative.

            // Zero should be represented as 0 / 1.


            // Always be reduced to lowest terms.





        }
    }
}
