using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scada
{
    public static class Util
    {
        public static void ShowErrorMessage(string message) {
            MessageBox.Show(message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
