using System.Windows.Forms;

namespace Hotel.Tests
{
    [TestClass()]
    public class ClassOfMethodsForUnitTestsTests
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

        [TestMethod]
        public void DeletingContentInTableLayoutPanel()
        {
            var tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Controls.Add(new Label());
            tableLayoutPanel.Controls.Add(new Label());
            tableLayoutPanel.Controls.Add(new Label());
            tableLayoutPanel.Controls.Add(new Label());
            int expected = 1;

            int actual = ClassOfMethodsForUnitTests.DeletesContentOfTableLayoutPanel(tableLayoutPanel);

            Assert.AreEqual(expected, actual);
        }
    }
}