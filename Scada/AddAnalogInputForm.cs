using DataConcentrator;
using System;
using System.Windows.Forms;

namespace Scada
{
    public partial class AddAnalogInputForm : Form
    {
        DataConcentratorManager dataConcentratorManager;

        private Tag result;
        public Tag Result { get { return result; } set { result = value; } }

        public AddAnalogInputForm(DataConcentratorManager dm)
        {
            result = null;
            this.dataConcentratorManager = dm;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text) ||
                string.IsNullOrEmpty(textBoxDescription.Text) ||
                comboBoxAddress.SelectedItem == null ||
                string.IsNullOrEmpty(textBoxScanTime.Text) ||
                string.IsNullOrEmpty(textBoxUnit.Text)) {
                Util.ShowErrorMessage("You must fill in all fields!");
                return;
            }
            int time;
            if (Int32.TryParse(textBoxScanTime.Text, out time))
            {
                if (time < 0)
                {
                    Util.ShowErrorMessage("Scan time must be an integer greater than 0!");
                }
                else
                {
                    result = new AnalogInput(textBoxId.Text, textBoxDescription.Text,
                        comboBoxAddress.SelectedItem.ToString(), time, textBoxUnit.Text);
                    if (dataConcentratorManager.AddTag(result))
                    {
                        this.Close();
                    }
                    else {
                        Util.ShowErrorMessage("Tag Id must be unique!");
                        return;
                    }
                }
            }
            else {
                Util.ShowErrorMessage("Scan time must be an integer greater than 0!");
                return;
            }
        }
    }
}
