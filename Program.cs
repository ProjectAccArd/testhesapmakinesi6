using System;
using System.Windows.Forms;

namespace testhesapmakinesi6
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
			//test commit
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}