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

        internal static IRationalNumber Reduce(this IRationalNumber number) => throw new NotImplementedException();
            //new ReducedRationalNumber(number.Numerator, number.Denominator);

        internal static int DivideByGcd(this int dividend, int numerator, int denominator) =>
            dividend / GcdOf(numerator, denominator);

        internal static int ToProperNegativeForm(this int original, int denominator) =>
            denominator < 0 ? -original : original;
        
    }
}
