using DataConcentrator;
using System;
using System.Windows.Forms;

namespace Scada
{
    public partial class ShowAlarmsForm : Form
    {
        private DataConcentratorManager dataConcentratorManager;
        private string tagId;

        public ShowAlarmsForm(DataConcentratorManager dataConcentratorManager, string tagId)
        {
            this.dataConcentratorManager = dataConcentratorManager;
            this.tagId = tagId;
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            foreach (var alarm in ((AnalogInput)dataConcentratorManager.Tags[tagId]).Alarms)
            {
                ListViewItem listItem = new ListViewItem(alarm.Id);
                listItem.SubItems.Add(alarm.Limit.ToString());
                listItem.SubItems.Add(alarm.Type.ToString());
                listItem.SubItems.Add(alarm.Message);

                listViewShowAlarms.Items.Add(listItem);
            }
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarmForm form = new AddAlarmForm(dataConcentratorManager);
            form.ShowDialog();

            var alarm = form.Result;
            if (alarm != null)
            {
                dataConcentratorManager.AddAlarmToTag(tagId, alarm);
                ListViewItem listItem = new ListViewItem(alarm.Id);
                listItem.SubItems.Add(alarm.Limit.ToString());
                listItem.SubItems.Add(alarm.Type.ToString());
                listItem.SubItems.Add(alarm.Message);

                listViewShowAlarms.Items.Add(listItem);
            }
        }

        private void btnRemoveAlarm_Click(object sender, EventArgs e)
        {
            if (listViewShowAlarms.SelectedItems.Count > 0)
            {
                var item = listViewShowAlarms.SelectedItems[0];
                dataConcentratorManager.RemoveAlarm(tagId, item.Text);
                listViewShowAlarms.Items.Remove(item);
            }
        }
    }
}
