namespace Scada
{
    partial class ShowAlarmsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewShowAlarms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveAlarm = new System.Windows.Forms.Button();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewShowAlarms
            // 
            this.listViewShowAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewShowAlarms.FullRowSelect = true;
            this.listViewShowAlarms.GridLines = true;
            this.listViewShowAlarms.Location = new System.Drawing.Point(12, 12);
            this.listViewShowAlarms.MultiSelect = false;
            this.listViewShowAlarms.Name = "listViewShowAlarms";
            this.listViewShowAlarms.Size = new System.Drawing.Size(537, 189);
            this.listViewShowAlarms.TabIndex = 0;
            this.listViewShowAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewShowAlarms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Limit";
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Message";
            this.columnHeader4.Width = 394;
            // 
            // btnRemoveAlarm
            // 
            this.btnRemoveAlarm.Location = new System.Drawing.Point(473, 208);
            this.btnRemoveAlarm.Name = "btnRemoveAlarm";
            this.btnRemoveAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAlarm.TabIndex = 1;
            this.btnRemoveAlarm.Text = "-";
            this.btnRemoveAlarm.UseVisualStyleBackColor = true;
            this.btnRemoveAlarm.Click += new System.EventHandler(this.btnRemoveAlarm_Click);
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.Location = new System.Drawing.Point(392, 208);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlarm.TabIndex = 2;
            this.btnAddAlarm.Text = "+";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // ShowAlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.btnRemoveAlarm);
            this.Controls.Add(this.listViewShowAlarms);
            this.Name = "ShowAlarmsForm";
            this.Text = "Alarms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewShowAlarms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnRemoveAlarm;
        private System.Windows.Forms.Button btnAddAlarm;
    }
}