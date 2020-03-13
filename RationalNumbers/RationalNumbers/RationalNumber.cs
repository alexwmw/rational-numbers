using System;
using InternalExtensions;
using static InternalExtensions.RationalNumberExtensions;


namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber // IComparable? IConvertible?
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator)
        {
            throw new NotImplementedException("You need to implement this operator.");
        }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException(); //todo: test this

            Numerator = numerator;
            //.ToProperNegativeForm(denominator);

            Denominator = denominator;
            //.ToProperNegativeForm(denominator);

        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        public IRationalNumber Abs()
        {
            int num = Numerator.Abs();
            int den = Denominator.Abs();
            return new RationalNumber(num, den);
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
        public IRationalNumber Add(IRationalNumber number) {
            int num = this.Numerator * number.Denominator + this.Denominator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }


        /**
         * The difference of two rational numbers r1 = a1/b1 and r2 = a2/b2 is r1 - r2 =
         * a1/b1 - a2/b2 = (a1 * b2 - a2 * b1) / (b1 * b2).
         */
        public IRationalNumber Subtract(IRationalNumber number)
        {
            int num = this.Numerator * number.Denominator - this.Denominator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }

        /**
         * The product (multiplication) of two rational numbers r1 = a1/b1 and r2 =
         * a2/b2 is r1 * r2 = (a1 * a2) / (b1 * b2).
         */
        public IRationalNumber Multiply(IRationalNumber number)
        {
            int num = this.Numerator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }


        /**
         * Dividing a rational number r1 = a1/b1 by another r2 = a2/b2 is r1 / r2 =
         * (a1 * b2) / (a2 * b1) if a2 * b1 is not zero.
         */
        public IRationalNumber Divide(IRationalNumber number)
        {
            int num = this.Numerator * number.Denominator;
            int den = number.Numerator * this.Denominator;
            return new RationalNumber(num, den);
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public override bool Equals(object obj)
        {
            var number = obj as IRationalNumber;
            if (number == null)
                return false;

            return this.Numerator * number.Denominator
                == this.Denominator * number.Numerator;
        }

        public override int GetHashCode()
        {
            int prime = 31;
            return (Numerator / Denominator + Denominator / Numerator) * prime;
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
