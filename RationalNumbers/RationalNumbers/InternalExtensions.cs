using System;
using System.Runtime.CompilerServices;
using RationalNumbers;

[assembly: InternalsVisibleTo("RationalNumbers.Test")]
namespace InternalExtensions
{
    internal static class RationalNumberExtensions
    {
        internal static IRationalNumber Reduce(this IRationalNumber rationalNumber)
        {
            throw new NotImplementedException();
            //return a new class: ReducedRationalNumber
        }
    }

}
