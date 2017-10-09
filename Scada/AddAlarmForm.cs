using DataConcentrator;
using System;
using System.Windows.Forms;

namespace Scada
{
    public partial class AddAlarmForm : Form
    {
        private Alarm result;
        public Alarm Result { get { return result; } set { result = value; }}

        private DataConcentratorManager dataConcentratorManager;

        public AddAlarmForm(DataConcentratorManager dataConcentratorManager)
        {
            result = null;
            this.dataConcentratorManager = dataConcentratorManager;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text) ||
               string.IsNullOrEmpty(textBoxLimit.Text) ||
               comboBoxType.SelectedItem == null ||
               string.IsNullOrEmpty(textBoxMessage.Text))
            {
                Util.ShowErrorMessage("You must fill in all fields!");
                return;
            }
            double limit;
            if (Double.TryParse(textBoxLimit.Text, out limit))
            {
                result = new Alarm(textBoxId.Text, limit,
                    comboBoxType.SelectedItem.ToString(), textBoxMessage.Text);
                if (dataConcentratorManager.AddAlarm(Result.Id))
                {
                    this.Close();
                }
                else
                {
                    Util.ShowErrorMessage("Alarm Id must be unique!");
                    return;
                }
            }
            else
            {
                Util.ShowErrorMessage("Limit must be of type double!");
                return;
            }
        }
    }
}
