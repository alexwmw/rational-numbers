using System;
using System.Runtime.CompilerServices;


namespace RationalNumbers
{
    
    //todo: test all of these!
    internal static class InternalExtensions
    {
        private static int GcdOf( int numerator, int denominator)
            => denominator == 0
            ? numerator
            : GcdOf(denominator, numerator % denominator);

        internal static int DivideByGcd(this int intNumber, IRationalNumber number)
            => intNumber / GcdOf(number.Numerator, number.Denominator);

        internal static int ToProperNegativeForm(this int intNumber, int denominator)
            => denominator < 0 ? -intNumber : intNumber;

        internal static int Pow(this int intNumber, int power)
            => (int) Math.Pow(intNumber, power);

        internal static int Abs(this int intNumber)
            => Math.Abs(intNumber);
        
    }
}
