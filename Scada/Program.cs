using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataConcentrator;

namespace Scada
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DataConcentratorManager dataConcentratorManager = new DataConcentratorManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(dataConcentratorManager));
        }
    }
}
