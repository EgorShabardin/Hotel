using System.Windows.Forms;
using System;

namespace Hotel
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new HotelMainForm());
        }
    }
}