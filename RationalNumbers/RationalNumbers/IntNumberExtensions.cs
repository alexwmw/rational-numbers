using System;
namespace RationalNumbers
{
    public static class IntNumberExtensions
    {
        // exponentiate real number to the rational number power
        public static double ExpReal(this int intNumber, RationalNumber r)
            => r.ExpReal(intNumber);

        internal static int Pow(this int intNumber, int power)
            => (int)Math.Pow(intNumber, power);

        internal static int Abs(this int intNumber)
            => Math.Abs(intNumber);

        internal static int DivideByGcd(this int intNumber, int num, int den)
            => intNumber / GcdOf(num, den);

        private static int GcdOf(int numerator, int denominator)
            => denominator == 0
            ? numerator
            : GcdOf(denominator, numerator % denominator);

        internal static int ToProperNegativeForm(this int intNumber, int den)
            => den < 0 ? -intNumber : intNumber;
    }
}
