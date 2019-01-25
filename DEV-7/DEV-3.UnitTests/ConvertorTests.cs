using System;
using NUnit.Framework;
using DEV_3;

namespace DEV_3.UnitTests
{
    [TestFixture]
    public class ConvertorTests
    {
        [TestCase("3", "2", "11")]
        [TestCase("5", "3", "12")]
        [TestCase("7", "4", "13")]
        [TestCase("9", "5", "14")]
        [TestCase("13", "6", "21")]
        [TestCase("17", "7", "23")]
        [TestCase("19", "8", "23")]
        [TestCase("47", "9", "52")]
        [TestCase("59", "10", "59")]
        [TestCase("777", "11", "647")]
        [TestCase("57931", "12", "29637")]
        [TestCase("33", "13", "27")]
        [TestCase("100", "14", "72")]
        [TestCase("4546", "15", "1531")]
        [TestCase("123", "16", "7B")]
        [TestCase("897", "17", "31D")]
        [TestCase("13", "18", "D")]
        [TestCase("3578", "19", "9H6")]
        [TestCase("42478322", "20", "D59FG2")]
        public void ConvertInto_NumberConvertIntoSystemWithRadixNumber_expectedNumber
            (string Number, string Basis, string expectedNumber)
        {
            
            NumericConverterToNewNumberSystem convertor = 
                new NumericConverterToNewNumberSystem(Number, Basis);
            string afterConvertion = convertor.ConvertInto();

            Assert.AreEqual(afterConvertion, expectedNumber);
        }

        [Test]
        public void ConvertInto_ABCDConvertIntoSystemWithRadix20_Error()
        {
            string number = "1AB!)@*&<";
            string basis = "20";
            int exceptionWasCalled = 0;

            try
            {
                NumericConverterToNewNumberSystem convertor = new NumericConverterToNewNumberSystem(number, basis);
                string afterConvertion = convertor.ConvertInto();
            }
            catch (Exception ex)
            {
                exceptionWasCalled++;
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(1, exceptionWasCalled);
        }

        [Test]
        public void ConvertInto_420ConvertIntoSystemWithRadixASD_Error()
        {
            string number = "420";
            string basis = "ASD";
            int exceptionWasCalled = 0;

            try
            {
                NumericConverterToNewNumberSystem convertor = new NumericConverterToNewNumberSystem(number, basis);
                string afterConvertion = convertor.ConvertInto();
            }
            catch (Exception ex)
            {
                exceptionWasCalled++;
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(1, exceptionWasCalled);
        }

        [Test]
        public void ConvertInto_420ConvertIntoSystemWithRadix0_Error()
        {
            string number = "420";
            string basis = "0";
            int exceptionWasCalled = 0;

            try
            {
                NumericConverterToNewNumberSystem convertor = new NumericConverterToNewNumberSystem(number, basis);
                string afterConvertion = convertor.ConvertInto();
            }
            catch (Exception ex)
            {
                exceptionWasCalled++;
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(1, exceptionWasCalled);
        }

        [Test]
        public void ConvertInto_420ConvertIntoSystemWithRadix21_Error()
        {
            string number = "420";
            string basis = "21";
            int exceptionWasCalled = 0;

            try
            {
                NumericConverterToNewNumberSystem convertor = new NumericConverterToNewNumberSystem(number, basis);
                string afterConvertion = convertor.ConvertInto();
            }
            catch (Exception ex)
            {
                exceptionWasCalled++;
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(1, exceptionWasCalled);
        }

        [Test]
        public void ConvertInto_1234567891ConvertIntoSystemWithRadix20_Error()
        {
            string number = "1234567891";
            string basis = "20";
            int exceptionWasCalled = 0;

            try
            {
                NumericConverterToNewNumberSystem convertor = new NumericConverterToNewNumberSystem(number, basis);
                string afterConvertion = convertor.ConvertInto();
            }
            catch (Exception ex)
            {
                exceptionWasCalled++;
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(1, exceptionWasCalled);
        }
    }
}
