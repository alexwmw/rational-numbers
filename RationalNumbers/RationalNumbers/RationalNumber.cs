using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("RationalNumbers.Test")]
namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator) : this(numerator, 1)
        { }


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


        public IRationalNumber Abs()
        {
            int num = Numerator.Abs();
            int den = Denominator.Abs();
            return new RationalNumber(num, den);
        }

        public IRationalNumber ExpRational(int power)
        {
            int num = power >= 0 ? Numerator.Pow(power) : Denominator.Abs().Pow(power);
            int den = power >= 0 ? Denominator.Pow(power) : Numerator.Abs().Pow(power);
            return new RationalNumber(num, den);
        }

        internal IRationalNumber Reduce()
        {
            int num = Numerator.DivideByGcd(Numerator, Denominator);
            int den = Denominator.DivideByGcd(Numerator, Denominator);
            return new RationalNumber(num, den);
        }

        public double ExpReal(int baseNumber)
        {
            return Math.Pow(baseNumber, (double) Numerator / Denominator);
        }


        public IRationalNumber Add(IRationalNumber number) {
            int num = this.Numerator * number.Denominator + this.Denominator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }



        public IRationalNumber Subtract(IRationalNumber number)
        {
            int num = this.Numerator * number.Denominator - this.Denominator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }


        public IRationalNumber Multiply(IRationalNumber number)
        {
            int num = this.Numerator * number.Numerator;
            int den = this.Denominator * number.Denominator;
            return new RationalNumber(num, den);
        }



        public IRationalNumber Divide(IRationalNumber number)
        {
            if (number.Numerator == 0)
                throw new DivideByZeroException();

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
            if (obj == null)
                return false;

            IRationalNumber number = obj as IRationalNumber;
            return this.Numerator * number.Denominator
                == this.Denominator * number.Numerator
                && this.Numerator == number.Numerator;
        }

        public override int GetHashCode()
        {
            int prime = 31;
            return (Numerator / Denominator + Denominator / Numerator) * prime;
        }
    }
}
