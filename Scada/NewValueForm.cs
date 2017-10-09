using System;
using System.Windows.Forms;

namespace Scada
{
    public partial class NewValueForm : Form
    {
        private double result;
        public double Result { get { return result; } set { result = value; } }

        private bool digital;

        public NewValueForm(bool digital)
        {
            this.digital = digital;
            result = Double.MinValue;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxNewVal.Text, out result))
            {
                if (digital && (result != 0 && result != 1)) {
                    Util.ShowErrorMessage("Value must be a 0 or a 1!");
                    return;
                }
                this.Close();
            }
            else
            {
                Util.ShowErrorMessage("Value must be of type double!");
                return;
            }
        }
    }
}
