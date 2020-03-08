using System;
using System.Runtime.CompilerServices;
using RationalNumbers;

[assembly: InternalsVisibleTo("RationalNumbers.Test")]
namespace InternalExtensions
{
    internal static class RationalNumberExtensions
    {
        internal static IRationalNumber Reduce(this IRationalNumber number) =>
            new RationalNumber(
                number.Numerator.DivideByGcd(number.Numerator, number.Denominator),
                number.Denominator.DivideByGcd(number.Numerator, number.Denominator));

        private static int GcdOf( int numerator, int denominator) =>
            denominator == 0 ? numerator : GcdOf(denominator, numerator % denominator);


        internal static int DivideByGcd(this int number, int numerator, int denominator) =>
            number / GcdOf(numerator, denominator);
    }
}
