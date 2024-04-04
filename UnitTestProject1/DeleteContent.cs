using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System;
using Hotel

namespace UnitTestProjectForHotelApp
{
    [TestClass]
    public class DeleteContent
    {
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
