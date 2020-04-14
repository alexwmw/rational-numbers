using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RationalNumbers.Test
{
    [TestClass]
    public class RationalTests
    {

        [TestMethod]
        public void Add_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) + new RationalNumber(2, 3));
        }


        [TestMethod]
        public void Add_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) + new RationalNumber(-2, 3));
        }


        [TestMethod]
        public void Add_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(-7, 6), new RationalNumber(-1, 2) + new RationalNumber(-2, 3));
        }


        [TestMethod]
        public void Add_a_rational_number_to_its_additive_inverse()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) + new RationalNumber(-1, 2));
        }


        [TestMethod]
        public void Subtract_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) - new RationalNumber(2, 3));
        }


        [TestMethod]
        public void Subtract_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) - new RationalNumber(-2, 3));
        }


        [TestMethod]
        public void Subtract_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 6), new RationalNumber(-1, 2) - new RationalNumber(-2, 3));
        }


        [TestMethod]
        public void Subtract_a_rational_number_from_itself()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) - new RationalNumber(1, 2));
        }


        [TestMethod]
        public void Multiply_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(1, 2) * new RationalNumber(2, 3));
        }


        [TestMethod]
        public void Multiply_a_negative_rational_number_by_a_positive_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(-1, 2) * new RationalNumber(2, 3));
        }


        [TestMethod]
        public void Multiply_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(-1, 2) * new RationalNumber(-2, 3));
        }

        
        [TestMethod]
        public void Multiply_a_rational_number_by_its_reciprocal()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2) * new RationalNumber(2, 1));
        }


        [TestMethod]
        public void Multiply_a_rational_number_by_1()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2) * new RationalNumber(1, 1));
        }


        [TestMethod]
        public void Multiply_a_rational_number_by_0()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) * new RationalNumber(0, 1));
        }


        [TestMethod]
        public void Divide_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(1, 2) / new RationalNumber(2, 3));
        }


        [TestMethod]
        public void Divide_a_positive_rational_number_by_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-3, 4), new RationalNumber(1, 2) / new RationalNumber(-2, 3));
        }


        [TestMethod]
        public void Divide_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-1, 2) / new RationalNumber(-2, 3));
        }


        [TestMethod]
        public void Divide_a_rational_number_by_1()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2) / new RationalNumber(1, 1));
        }


        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2).Abs());
        }


        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number_with_negative_numerator_and_denominator()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, -2).Abs());
        }


        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, 2).Abs());
        }


        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number_with_negative_denominator()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, -2).Abs());
        }


        [TestMethod]
        public void Absolute_value_of_zero()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).Abs());
        }


        [TestMethod]
        public void Raise_a_positive_rational_number_to_a_positive_integer_power()
        {
            Assert.AreEqual(new RationalNumber(1, 8), new RationalNumber(1, 2).ExpRational(3));
        }


        [TestMethod]
        public void Raise_a_negative_rational_number_to_a_positive_integer_power()
        {
            Assert.AreEqual(new RationalNumber(-1, 8), new RationalNumber(-1, 2).ExpRational(3));
        }


        [TestMethod]
        public void Raise_zero_to_an_integer_power()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).ExpRational(5));
        }


        [TestMethod]
        public void Raise_one_to_an_integer_power()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 1).ExpRational(4));
        }


        [TestMethod]
        public void Raise_a_positive_rational_number_to_the_power_of_zero()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2).ExpRational(0));
        }


        [TestMethod]
        public void Raise_a_negative_rational_number_to_the_power_of_zero()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-1, 2).ExpRational(0));
        }


        [TestMethod]
        public void Raise_a_real_number_to_a_positive_rational_number()
        {
            Assert.AreEqual(16, 8.0.ExpReal(new RationalNumber(4, 3)), 0.0000001);
        }


        [TestMethod]
        public void Raise_a_real_number_to_a_negative_rational_number()
        {
            Assert.AreEqual(0.33333334, 9.0.ExpReal(new RationalNumber(-1, 2)), 0.0000001);
        }


        [TestMethod]
        public void Raise_a_real_number_to_a_zero_rational_number()
        {
            Assert.AreEqual(1, 2.0.ExpReal(new RationalNumber(0, 1)), 0.0000001);
        }


        [TestMethod]
        public void Reduce_a_positive_rational_number_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(2, 4).Reduce());
        }


        [TestMethod]
        public void Reduce_a_negative_rational_number_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-2, 3), new RationalNumber(-4, 6).Reduce());
        }


        public void Reduce_a_rational_number_with_a_negative_denominator_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(3, -9).Reduce());
        }


        [TestMethod]
        public void Reduce_zero_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 6).Reduce());
        }


        [TestMethod]
        public void Reduce_an_integer_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-2, 1), new RationalNumber(-14, 7).Reduce());
        }


        [TestMethod]
        public void Reduce_one_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(13, 13).Reduce());
        }


        [TestMethod]
        public void Throws_exception_if_denominator_is_zero()
        {
            RationalNumber number;
            Assert.ThrowsException<DivideByZeroException>
                (() => number = new RationalNumber(1, 0));
        }


        [TestMethod]
        public void Throws_exception_if_denominator_is_zero_and_numerator_is_negative()
        {
            RationalNumber number;
            Assert.ThrowsException<DivideByZeroException>
                (() => number = new RationalNumber(-2, 0));
        }


        [TestMethod]
        public void Throws_exception_if_divide_by_RationalNumber_equal_to_zero()
        {
            Assert.ThrowsException<DivideByZeroException>
                (() => new RationalNumber(3, 4) / new RationalNumber(0, 1));
        }


        [TestMethod]
        public void Single_integer_constructor()
        {
            Assert.AreEqual(new RationalNumber(3, 1), new RationalNumber(3));
        }


        [TestMethod]
        public void Single_integer_constructor_with_zero()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0));
        }


        [TestMethod]
        public void Single_integer_constructor_with_negative_number()
        {
            Assert.AreEqual(new RationalNumber(-4, 1), new RationalNumber(-4));
        }


        [TestMethod]
        public void Two_negative_parts_is_equal_to_two_positive_parts()
        {
            Assert.AreEqual(new RationalNumber(4, 4), new RationalNumber(-4, -4));
        }


        [TestMethod]
        public void Proper_negative_form_if_negative_denominator()
        {
            RationalNumber r = new RationalNumber(1, -2);
            Assert.AreEqual(-1, r.Numerator);
            Assert.AreEqual(2, r.Denominator);
        }


        [TestMethod]
        public void Proper_negative_form_if_both_parts_negative()
        {
            RationalNumber r = new RationalNumber(-1, -2);
            Assert.AreEqual(1, r.Numerator);
            Assert.AreEqual(2, r.Denominator);
        }


        [TestMethod]
        public void Proper_negative_form_if_both_parts_postive()
        {
            RationalNumber r = new RationalNumber(1, 2);
            Assert.AreEqual(1, r.Numerator);
            Assert.AreEqual(2, r.Denominator);
        }


        [TestMethod]
        public void Proper_negative_form_if_negative_numerator()
        {
            RationalNumber r = new RationalNumber(-1, 2);
            Assert.AreEqual(-1, r.Numerator);
            Assert.AreEqual(2, r.Denominator);
        }


        [TestMethod]
        public void Negative_sign_applied_to_numerator_internally()
        {
            Assert.AreEqual(-1, new RationalNumber(1, -3).Numerator);
        }


        [TestMethod]
        public void Reduced_upon_contruction()
        {
            RationalNumber r = new RationalNumber(4, 8);
            Assert.AreEqual(1, r.Numerator);
            Assert.AreEqual(2, r.Denominator);
        }
    }
}