using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hotel;

namespace UnitTestProjectForHotelApp
{
    [TestClass]
    public class CalculationPayment
    {
        [TestMethod]
        public void CalculationPaymentFor_10Days()
        {
            var numberOfDays = 10;
            var dailyFee = 1000;
            var expected = 10000;

            int actual = ClassOfMethodsForUnitTests.CalculationOfPaymentForAccommodation(numberOfDays, dailyFee);

            Assert.AreEqual(expected, actual);
        }
    }
}
