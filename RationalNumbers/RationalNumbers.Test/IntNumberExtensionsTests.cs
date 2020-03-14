using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace RationalNumbers.Test
{
    [TestClass]
    public class IntNumberExtensionsTests
    {
        [TestMethod]
        public void to_proper_negative_form_positive()
        {
            Assert.AreEqual(1, 1.ToProperNegativeForm(2));
        }

        [TestMethod]
        public void to_proper_negative_form_negative()
        {
            Assert.AreEqual(-1, 1.ToProperNegativeForm(-2));
        }

        [TestMethod]
        public void divide_positive_int_by_gcd()
        {
            Assert.AreEqual(3, 12.DivideByGcd(12,16));
            Assert.AreEqual(4, 16.DivideByGcd(12,16));
        }

        [TestMethod]
        public void divide_negative_int_by_gcd()
        {
            Assert.AreEqual(3, -15.DivideByGcd(-15,25));
            Assert.AreEqual(-5, 25.DivideByGcd(-15,25));
        }

        [TestMethod]
        public void divide_zero_by_gcd()
        {
            Assert.AreEqual(0, 0.DivideByGcd(0,5));
            Assert.AreEqual(1, 5.DivideByGcd(0,5));
        }
    }
}
