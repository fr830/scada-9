using System;
using System.Windows.Forms;
using DataConcentrator;
using System.Linq;
using DataConcentrator.Model;

namespace Scada
{
    public partial class MainForm : Form
    {
        DataConcentratorManager dataConcentratorManager;
        delegate void SetListCallback(ListView listView, int index, string tagId, double value);
        delegate void SetAlarmCallback(string alarmId);

        public MainForm(DataConcentratorManager dataConcentratorManager)
        {
            this.dataConcentratorManager = dataConcentratorManager;
            this.dataConcentratorManager.AlarmHandler += AlarmRaised;
            this.dataConcentratorManager.ValueChangedHandler += ValueChanged;

            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            foreach (var tag in dataConcentratorManager.Tags.Values)
            {
                ListViewItem listItem = new ListViewItem(tag.Id);
                listItem.SubItems.Add(tag.Description);
                listItem.SubItems.Add(tag.Address);
                
                if (tag.GetType() == typeof(DigitalInput))
                {
                    var t = (DigitalInput)tag;
                    listItem.SubItems.Add(t.ScanTime.ToString());
                    listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                    listViewDI.Items.Add(listItem);
                }
                else if (tag.GetType() == typeof(DigitalOutput))
                {
                    listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                    listViewDO.Items.Add(listItem);
                }
                else if (tag.GetType() == typeof(AnalogInput))
                {
                    var t = (AnalogInput)tag;
                    listItem.SubItems.Add(t.ScanTime.ToString());
                    listItem.SubItems.Add(t.Unit);
                    listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                    listViewAI.Items.Add(listItem);
                }
                else
                {
                    var t = (AnalogOutput)tag;
                    listItem.SubItems.Add(t.Unit);
                    listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                    listViewAO.Items.Add(listItem);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            dataConcentratorManager.SaveData();
            Environment.Exit(0);
        }

        private void btnAddDI_Click(object sender, EventArgs e)
        {
            AddDigitalInputForm form = new AddDigitalInputForm(dataConcentratorManager);
            form.ShowDialog();

            var tag = form.Result;
            if (tag != null)
            {
                ListViewItem listItem = new ListViewItem(tag.Id);
                listItem.SubItems.Add(tag.Description);
                listItem.SubItems.Add(tag.Address);

                var t = (DigitalInput)tag;
                listItem.SubItems.Add(t.ScanTime.ToString());
                listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                listViewDI.Items.Add(listItem);
            }
        }

        private void btnAddDO_Click(object sender, EventArgs e)
        {
            AddDigitalOutputForm form = new AddDigitalOutputForm(dataConcentratorManager);
            form.ShowDialog();

            var tag = form.Result;
            if (tag != null)
            {
                ListViewItem listItem = new ListViewItem(tag.Id);
                listItem.SubItems.Add(tag.Description);
                listItem.SubItems.Add(tag.Address);
                listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                listViewDO.Items.Add(listItem);
            }
        }

        private void btnAddAI_Click(object sender, EventArgs e)
        {
            AddAnalogInputForm form = new AddAnalogInputForm(dataConcentratorManager);
            form.ShowDialog();

            var tag = form.Result;
            if (tag != null)
            {
                ListViewItem listItem = new ListViewItem(tag.Id);
                listItem.SubItems.Add(tag.Description);
                listItem.SubItems.Add(tag.Address);
                var t = (AnalogInput)tag;
                listItem.SubItems.Add(t.ScanTime.ToString());
                listItem.SubItems.Add(t.Unit);
                listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                listViewAI.Items.Add(listItem);
            }
        }

        private void btnAddAO_Click(object sender, EventArgs e)
        {
            AddAnalogOutputForm form = new AddAnalogOutputForm(dataConcentratorManager);
            form.ShowDialog();

            var tag = form.Result;
            if (tag != null)
            {
                ListViewItem listItem = new ListViewItem(tag.Id);
                listItem.SubItems.Add(tag.Description);
                listItem.SubItems.Add(tag.Address);
                var t = (AnalogOutput)tag;
                listItem.SubItems.Add(t.Unit);
                listItem.SubItems.Add(dataConcentratorManager.CurrentValues[tag.Id].ToString());
                listViewAO.Items.Add(listItem);
            }
        }

        private void AlarmRaised(string alarmId)
        {
            if (listViewAlarms != null)
            {
                if (listViewAlarms.InvokeRequired)
                {
                    SetAlarmCallback callback = new SetAlarmCallback(AlarmRaised);
                    this.Invoke(callback, alarmId);
                    return;
                }
                AlarmDTO alarm = dataConcentratorManager.DbContext.Alarms.FirstOrDefault(a =>
                a.AlarmId == alarmId && a.Handled == false);
                ListViewItem item = new ListViewItem(alarm.AlarmId);
                item.SubItems.Add(alarm.TagId);
                item.SubItems.Add(alarm.Message);
                item.SubItems.Add(alarm.Time.ToString());
                listViewAlarms.Items.Add(item);
                alarm.Handled = true;
                dataConcentratorManager.DbContext.Entry(alarm).State = System.Data.Entity.EntityState.Modified;
                dataConcentratorManager.DbContext.SaveChanges();
            }
        }

        private void ValueChanged(string tagId, double value)
        {
            var tag = dataConcentratorManager.Tags[tagId];

            if (tag.GetType() == typeof(DigitalInput))
            {
                UpdateList(listViewDI, 4, tagId, value);
            }
            else if (tag.GetType() == typeof(DigitalOutput))
            {
                UpdateList(listViewDO, 3, tagId, value);
            }
            else if (tag.GetType() == typeof(AnalogInput))
            {
                UpdateList(listViewAI, 5, tagId, value);             
            }
            else
            {
                UpdateList(listViewAO, 4, tagId, value);
            }
        }

        private void UpdateList(ListView listView, int index, string tagId, double value) {
            if (listView.InvokeRequired) {
                SetListCallback callback = new SetListCallback(UpdateList);
                this.Invoke(callback, listView, index, tagId, value);
                return;
            }
            int cnt = 0;
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Text == tagId)
                {
                    listView.Items[cnt].SubItems[index].Text = value.ToString();
                } else
                {
                    cnt++;
                }
            }
        }

        private void btnRemoveDI_Click(object sender, EventArgs e)
        {
            if (listViewDI.SelectedItems.Count > 0)
            {
                var item = listViewDI.SelectedItems[0];
                listViewDI.Items.Remove(item);
                dataConcentratorManager.RemoveTag(item.Text);
            }
            else {
                Util.ShowErrorMessage("You must select a tag in order to remove it!");
            }
        }

        private void btnRemoveDO_Click(object sender, EventArgs e)
        {
            if (listViewDO.SelectedItems.Count > 0)
            {
                var item = listViewDO.SelectedItems[0];
                listViewDO.Items.Remove(item);
                dataConcentratorManager.RemoveTag(item.Text);
            }
            else
            {
                Util.ShowErrorMessage("You must select a tag in order to remove it!");
            }
        }

        private void btnRemoveAI_Click(object sender, EventArgs e)
        {
            if (listViewAI.SelectedItems.Count > 0)
            {
                var item = listViewAI.SelectedItems[0];
                listViewAI.Items.Remove(item);
                dataConcentratorManager.RemoveTag(item.Text);
            }
            else
            {
                Util.ShowErrorMessage("You must select a tag in order to remove it!");
            }
        }

        private void btnRemoveAO_Click(object sender, EventArgs e)
        {
            if (listViewAO.SelectedItems.Count > 0)
            {
                var item = listViewAO.SelectedItems[0];
                listViewAO.Items.Remove(item);
                dataConcentratorManager.RemoveTag(item.Text);
            }
            else
            {
                Util.ShowErrorMessage("You must select a tag in order to remove it!");
            }
        }

        private void listViewDO_DoubleClick(object sender, EventArgs e)
        {
            if (listViewDO.SelectedItems.Count > 0)
            {
                NewValueForm form = new NewValueForm(true);
                form.ShowDialog();

                UpdateOutputValue(listViewDO, 3, form.Result);
            }
        }

        private void listViewAO_DoubleClick(object sender, EventArgs e)
        {
            if (listViewAO.SelectedItems.Count > 0)
            {
                NewValueForm form = new NewValueForm(false);
                form.ShowDialog();

                UpdateOutputValue(listViewAO, 4, form.Result);
            }
        }

        private void UpdateOutputValue(ListView listView, int index, double newValue) {
            if (newValue != Double.MinValue)
            {
                var item = listView.SelectedItems[0];
                var tagId = item.Text;

                if (dataConcentratorManager.WriteToTag(tagId, newValue))
                {
                    int cnt = listView.Items.IndexOf(item);
                    listView.Items[cnt].SubItems[index].Text = newValue.ToString();
                }
            }
        }

        private void btnShowAlarms_Click(object sender, EventArgs e)
        {
            if (listViewAI.SelectedItems.Count > 0)
            {
                var item = listViewAI.SelectedItems[0];
                var tagId = item.Text;
                ShowAlarmsForm form = new ShowAlarmsForm(dataConcentratorManager, tagId);
                form.ShowDialog();
            }
            else
            {
                Util.ShowErrorMessage("You must select an analog tag in order to show alarms!");
            }
        }
    }
}
