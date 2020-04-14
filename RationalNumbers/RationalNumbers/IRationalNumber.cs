using System;
namespace RationalNumbers
{
    public interface IRationalNumber
    {

        public static IRationalNumber operator +(IRationalNumber r1, IRationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(IRationalNumber r1, IRationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(IRationalNumber r1, IRationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(IRationalNumber r1, IRationalNumber r2) => r1.Divide(r2);


        IRationalNumber Add(IRationalNumber number);
        IRationalNumber Subtract(IRationalNumber number);
        IRationalNumber Multiply(IRationalNumber number);
        IRationalNumber Divide(IRationalNumber number);
        IRationalNumber Abs();
        IRationalNumber ExpRational(int power);
        double ExpReal(int baseNumber);
        

        int Numerator { get; }
        int Denominator { get; }


    }
}
