﻿using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RationalNumbers.Test")]
namespace RationalNumbers
{
    /// <summary>
    /// Represents a rational number.
    /// </summary>
    public struct RationalNumber : IRationalNumber
    {
        /// <summary>
        /// An integer which is the numerator of the rational number.
        /// </summary>
        public int Numerator { get; private set; }

        /// <summary>
        /// An integer which is the denominator of the rational number.
        /// </summary>
        public int Denominator { get; private set; }

        /// <summary>
        /// Initialises a new instance of the <see cref="RationalNumber"/> class, with a default denominator of 1.
        /// </summary>
        /// <param name="numerator">The integer numerator of the rational number.</param>
        public RationalNumber(int numerator) : this(numerator, 1)
        { }

        /// <summary>
        /// Initialises a new instance of the <see cref="RationalNumber"/> class.
        /// </summary>
        /// <param name="numerator">The integer numerator of the rational number.</param>
        /// <param name="denominator">The integer denominator of the rational number.</param>
        /// <exception cref="DivideByZeroException">
        /// When <paramref name="denominator"/> has a value of zero.
        /// </exception>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();

            int tempNumerator = numerator.DivideByGcd(numerator, denominator);
            int tempDenominator = denominator.DivideByGcd(numerator,denominator);

            Numerator = tempNumerator.ToProperNegativeForm(tempDenominator);
            Denominator = tempDenominator.ToProperNegativeForm(tempDenominator);
        }

        public static IRationalNumber operator +(RationalNumber r) => r;

        public static IRationalNumber operator -(RationalNumber r) => new RationalNumber(-r.Numerator, r.Denominator);

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        public static bool operator ==(RationalNumber r1, RationalNumber r2) => Equals(r1, r2);

        public static bool operator !=(RationalNumber r1, RationalNumber r2) => !Equals(r1, r2);

        public static bool operator <(RationalNumber r1, RationalNumber r2) => (decimal) r1 < r2;

        public static bool operator >(RationalNumber r1, RationalNumber r2) => (decimal) r1 > r2;

        public static implicit operator int(RationalNumber r) => (int)(decimal) r;

        public static implicit operator decimal(RationalNumber r) => (decimal) r.Numerator / r.Denominator;

        public static implicit operator double(RationalNumber r) => (double) r.Numerator / r.Denominator;

        public static implicit operator bool(RationalNumber r) => r.Numerator != 0;


        /// <summary>
        /// Returns a rational number representing the absolute value of this instance.
        /// </summary>
        /// <returns>A new rational number.</returns>
        public IRationalNumber Abs()
        {
            int num = Numerator.Abs();
            int den = Denominator.Abs();
            return new RationalNumber(num, den);
        }

        /// <summary>
        /// Returns a rational number representing this instance (the base) raised to the power of the specified integer (the exponent).
        /// </summary>
        /// <param name="power">An integer exponent.</param>
        /// <returns>A new rational number.</returns>
        public IRationalNumber ExpRational(int power)
        {
            int num = power >= 0 ? Numerator.Pow(power) : Denominator.Abs().Pow(power);
            int den = power >= 0 ? Denominator.Pow(power) : Numerator.Abs().Pow(power);
            return new RationalNumber(num, den);
        }

        /// <summary>
        /// Returns a rational number representing this instance reduced to it's lowest form.
        /// </summary>
        /// <returns>A new rational number.</returns>
        internal IRationalNumber Reduce()
        {
            int num = Numerator.DivideByGcd(Numerator, Denominator);
            int den = Denominator.DivideByGcd(Numerator, Denominator);
            return new RationalNumber(num, den);
        }

        /// <summary>
        /// Returns a double-precision floating point number representing the given base integer raised to the power of this instance.
        /// </summary>
        /// <param name="baseNumber">An integer base.</param>
        /// <returns>A double-precision floating point number.</returns>
        public double ExpReal(int baseNumber)
            => Math.Pow(baseNumber, (double) Numerator / Denominator);
       
        

        /// <summary>
        /// Returns a rational number representing the sum of this instance and the given rational number.
        /// </summary>
        /// <param name="number">A rational number to be added to this instance.</param>
        /// <returns>A new rational number.</returns>
        public IRationalNumber Add(IRationalNumber number) {
            int num = this.Numerator * number.Denominator + this.Denominator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }


        /// <summary>
        /// Returns a rational number representing the difference between this instance and the given rational number.
        /// </summary>
        /// <param name="number">A rational number to be subtracted from this instance<./param>
        /// <returns>A new rational number.</returns>
        public IRationalNumber Subtract(IRationalNumber number)
        {
            int num = this.Numerator * number.Denominator - this.Denominator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }

        /// <summary>
        /// Returns a rational number representing the product of this instance and the given rational number.
        /// </summary>
        /// <param name="number">A rational number to be multiplied by this instance.</param>
        /// <returns>A new rational number.</returns>
        public IRationalNumber Multiply(IRationalNumber number)
        {
            int num = this.Numerator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }


        /// <summary>
        /// Returns a rational number representing the quotient of this instance and the given rational number.
        /// </summary>
        /// <param name="number">A rational number divisor.</param>
        /// <returns>A new rational number.</returns>
        /// <exception cref="DivideByZeroException">
        /// When <paramref name="number"/> has a value of zero.
        /// </exception>
        public IRationalNumber Divide(IRationalNumber number)
        {
            if (number.Numerator == 0)
                throw new DivideByZeroException();

            int num = this.Numerator * number.Denominator;
            int den = number.Numerator * this.Denominator;
            return new RationalNumber(num, den);
        }

        /// <summary>
        /// Converts the numeric value of this rational number to it's equivalent string representation, in the format "n/d".
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specifed rational number object represent the same value. 
        /// </summary>
        /// <param name="obj">A rational number to be used in the comparison.</param>
        /// <returns>A boolean value.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            IRationalNumber number = obj as IRationalNumber;
            return this.Numerator * number.Denominator
                == this.Denominator * number.Numerator
                && this.Numerator == number.Numerator;
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>An Int32 number.</returns>
        public override int GetHashCode()
        {
            int prime = 31;
            return (Numerator / Denominator + Denominator / Numerator) * prime;
        }
    }
}
