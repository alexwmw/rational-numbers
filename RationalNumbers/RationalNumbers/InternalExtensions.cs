using System;
using System.Runtime.CompilerServices;
using RationalNumbers;

[assembly: InternalsVisibleTo("RationalNumbers.Test")]
namespace InternalExtensions
{
    //todo: test all of these!
    internal static class RationalNumberExtensions
    {
        private static int GcdOf( int numerator, int denominator) =>
            denominator == 0 ? numerator : GcdOf(denominator, numerator % denominator);

        internal static IRationalNumber Reduce(this IRationalNumber number) =>
            new RationalNumber(
                number.Numerator.DivideByGcd(number.Numerator, number.Denominator),
                number.Denominator.DivideByGcd(number.Numerator, number.Denominator));


        internal static int DivideByGcd(this int i, int numerator, int denominator) =>
            i / GcdOf(numerator, denominator);

        internal static int ToProperNegativeForm(this int i, int denominator) =>
            denominator < 0 ? i * -1 : i;
        
    }
}
