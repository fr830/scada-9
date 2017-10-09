using DataConcentrator;
using System;
using System.Windows.Forms;

namespace Scada
{
    public partial class AddAnalogOutputForm : Form
    {
        DataConcentratorManager dataConcentratorManager;

        private Tag result;
        public Tag Result { get { return result; } set { result = value; } }

        public AddAnalogOutputForm(DataConcentratorManager dm)
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
               string.IsNullOrEmpty(textBoxInitialValue.Text) ||
               string.IsNullOrEmpty(textBoxUnit.Text))
            {
                Util.ShowErrorMessage("You must fill in all fields!");
                return;
            }
            int value;
            if (Int32.TryParse(textBoxInitialValue.Text, out value))
            {
                result = new AnalogOutput(textBoxId.Text, textBoxDescription.Text,
                    comboBoxAddress.SelectedItem.ToString(), value, textBoxUnit.Text);
                if (dataConcentratorManager.AddTag(result))
                {
                    this.Close();
                }
                else
                {
                    Util.ShowErrorMessage("Tag Id must be unique!");
                    return;
                }
            }
            else
            {
                Util.ShowErrorMessage("Initial Value must be an integer!");
                return;
            }
        }
    }
}
