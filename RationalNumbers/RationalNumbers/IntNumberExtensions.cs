using System;
namespace RationalNumbers
{
    public static class IntNumberExtensions
    {
        /// <summary>
        /// Returns a double-precision floating point number representing this real number (double)  raised to the power of the given rational number.
        /// </summary>
        /// <param name="baseNumber">This integer number.</param>
        /// <param name="r">A rational number exponent.</param>
        /// <returns>A double-precision floating point number.</returns>
        public static double ExpReal(this double baseNumber, IRationalNumber r) => r.ExpReal(baseNumber);

        /// <summary>
        /// Returns the instance integer to the power of the given power.
        /// </summary>
        internal static int Pow(this int intNumber, double power) => (int)Math.Pow(intNumber, power);

        /// <summary>
        /// Returns the absolute value of the instance integer.
        /// </summary>
        internal static int Abs(this int intNumber) => Math.Abs(intNumber);

        /// <summary>
        /// Divides the instance intenger by the greatest common divisor of two given integers.
        /// </summary>
        internal static int DivideByGcd(this int intNumber, int num, int den) => intNumber / GcdOf(num, den);

        /// <summary>
        /// Returns the greatest common divisor of the two given integers.
        /// </summary>
        private static int GcdOf(int numerator, int denominator) => denominator == 0 ? numerator : GcdOf(denominator, numerator % denominator);

        /// <summary>
        /// Returns the negation of this integer number if the given denominator is negative.
        /// </summary>
        /// <param name="intNumber">An integer number representing either the numerator or denominator parameter of a new rational number.</param>
        /// <param name="den">An integer number representing the denominator parameter of a new rational number.</param>
        /// <returns>An Int32 number.</returns>
        internal static int ToProperNegativeForm(this int intNumber, int den) => den < 0 ? -intNumber : intNumber;
    }
}
