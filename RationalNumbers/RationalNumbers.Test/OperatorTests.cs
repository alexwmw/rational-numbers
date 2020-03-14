using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace RationalNumbers.Test
{
    [TestClass]
    public class OperatorTests
    {

        [TestMethod]
        public void Equality_operator_true_if_values_are_equal()
        {
            Assert.AreEqual(true, new RationalNumber(1, 4) == new RationalNumber(2, 8));
        }


        [TestMethod]
        public void Equality_operator_false_if_values_are_not_equal()
        {
            Assert.AreEqual(false, new RationalNumber(1, 3) == new RationalNumber(3, 1));
        }


        [TestMethod]
        public void Inequality_operator_false_if_values_are_equal()
        {
            Assert.AreEqual(false, new RationalNumber(1, 4) != new RationalNumber(2, 8));
        }


        [TestMethod]
        public void Inequality_operator_true_if_values_are_not_equal()
        {
            Assert.AreEqual(true, new RationalNumber(1, 3) != new RationalNumber(3, 1));
        }


        [TestMethod]
        public void GreaterThan_operator_is_true()
        {
            Assert.AreEqual(true, new RationalNumber(1, 3) > new RationalNumber(1, 6));
        }


        [TestMethod]
        public void GreaterThan_operator_is_false()
        {
            Assert.AreEqual(false, new RationalNumber(1, 3) > new RationalNumber(3, 1));
        }


        [TestMethod]
        public void LessThan_operator_is_true()
        {
            Assert.AreEqual(true, new RationalNumber(1, 3) < new RationalNumber(1, 2));
        }


        [TestMethod]
        public void LessThan_operator_is_false()
        {
            Assert.AreEqual(false, new RationalNumber(1, 3) < new RationalNumber(1, 6));
        }


        [TestMethod]
        public void To_decimal_true()
        {
            Assert.AreEqual((decimal)0.5, new RationalNumber(1, 2));
        }


        [TestMethod]
        public void To_decimal_false()
        {
            Assert.AreNotEqual((decimal)0.6, new RationalNumber(1, 2));
        }


        [TestMethod]
        public void To_double_true()
        {
            Assert.AreEqual(0.5, new RationalNumber(1, 2));
        }


        [TestMethod]
        public void To_double_false()
        {
            Assert.AreNotEqual(0.6, new RationalNumber(1, 2));
        }


        [TestMethod]
        public void Is_bool_true_if_true()
        {
            Assert.AreEqual(true, new RationalNumber(1, 2));
        }


        [TestMethod]
        public void Is_bool_false_if_false()
        {
            Assert.AreEqual(false, new RationalNumber(0, 1));
        }
    }
}
