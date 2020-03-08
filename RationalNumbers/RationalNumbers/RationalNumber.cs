﻿using System;
using InternalExtensions;
using static InternalExtensions.RationalNumberExtensions;


namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator)
        {
            throw new NotImplementedException("You need to implement this operator.");
        }

        public RationalNumber(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        public IRationalNumber Abs()
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public IRationalNumber ExpRational(int power)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public double ExpReal(int baseNumber)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /**
         * The sum of two rational numbers r1 = a1/b1 and r2 = a2/b2 is r1 + r2 =
         * a1/b1 + a2/b2 =
         * (a1 * b2 + a2 * b1) / (b1 * b2).
         */
        public IRationalNumber Add(IRationalNumber number) => new RationalNumber(
            this.Numerator * number.Denominator + this.Denominator * number.Numerator,
            this.Denominator * number.Denominator);


        /**
         * The difference of two rational numbers r1 = a1/b1 and r2 = a2/b2 is r1 - r2 =
         * a1/b1 - a2/b2 = (a1 * b2 - a2 * b1) / (b1 * b2).
         */
        public IRationalNumber Subtract(IRationalNumber number) => new RationalNumber(
            this.Numerator * number.Denominator - this.Denominator * number.Numerator,
            this.Denominator * number.Denominator);

        /**
         * The product (multiplication) of two rational numbers r1 = a1/b1 and r2 =
         * a2/b2 is r1 * r2 = (a1 * a2) / (b1 * b2).
         */
        public IRationalNumber Multiply(IRationalNumber number) => new RationalNumber(
            this.Numerator * number.Numerator,
            this.Denominator * number.Denominator);
        
        /**
         */
        public IRationalNumber Divide(IRationalNumber number)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj); // replace this with the correct expression or remove
            var number = obj as IRationalNumber;
            return this.Numerator * number.Denominator == this.Denominator * number.Numerator;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); // replace this with the correct expression or remove
        }

        // plus any other methods you deem necessary to meet the specification
    }

    public static class IntNumberExtension
    {
        // exponentiate real number to the rational number power
        public static double ExpReal(this int intNumber, RationalNumber r)
        {
            return 0; // replace with correct call
        }
    }
}
