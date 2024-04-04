using System.Windows.Forms;

namespace Hotel
{
    static public class ClassOfMethodsForUnitTests
    {
        static public int CalculationOfPaymentForAccommodation(decimal numberOfDays, int dailyFee)
        {
            return (int)numberOfDays * dailyFee;
        }

        static public int DeletesContentOfTableLayoutPanel(TableLayoutPanel tableLayoutPanel)
        {
            for (int i = tableLayoutPanel.Controls.Count - 1; i > 0; i--)
            {
                tableLayoutPanel.Controls[i].Dispose();
            }

            return tableLayoutPanel.Controls.Count;
        }
    }
}
