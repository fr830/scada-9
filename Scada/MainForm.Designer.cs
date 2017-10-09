namespace Scada
{
    partial class MainForm
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
            this.listViewDI = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddDI = new System.Windows.Forms.Button();
            this.listViewDO = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDO = new System.Windows.Forms.Button();
            this.listViewAI = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAO = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAI = new System.Windows.Forms.Button();
            this.btnAddAO = new System.Windows.Forms.Button();
            this.btnShowAlarms = new System.Windows.Forms.Button();
            this.btnRemoveDI = new System.Windows.Forms.Button();
            this.btnRemoveDO = new System.Windows.Forms.Button();
            this.btnRemoveAI = new System.Windows.Forms.Button();
            this.btnRemoveAO = new System.Windows.Forms.Button();
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDI
            // 
            this.listViewDI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDI.FullRowSelect = true;
            this.listViewDI.GridLines = true;
            this.listViewDI.Location = new System.Drawing.Point(12, 20);
            this.listViewDI.MultiSelect = false;
            this.listViewDI.Name = "listViewDI";
            this.listViewDI.Size = new System.Drawing.Size(428, 96);
            this.listViewDI.TabIndex = 0;
            this.listViewDI.UseCompatibleStateImageBehavior = false;
            this.listViewDI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 23;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Value";
            this.columnHeader5.Width = 48;
            // 
            // btnAddDI
            // 
            this.btnAddDI.Location = new System.Drawing.Point(334, 122);
            this.btnAddDI.Name = "btnAddDI";
            this.btnAddDI.Size = new System.Drawing.Size(50, 27);
            this.btnAddDI.TabIndex = 1;
            this.btnAddDI.Text = "+";
            this.btnAddDI.UseVisualStyleBackColor = true;
            this.btnAddDI.Click += new System.EventHandler(this.btnAddDI_Click);
            // 
            // listViewDO
            // 
            this.listViewDO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.listViewDO.FullRowSelect = true;
            this.listViewDO.GridLines = true;
            this.listViewDO.Location = new System.Drawing.Point(457, 20);
            this.listViewDO.MultiSelect = false;
            this.listViewDO.Name = "listViewDO";
            this.listViewDO.Size = new System.Drawing.Size(422, 96);
            this.listViewDO.TabIndex = 2;
            this.listViewDO.UseCompatibleStateImageBehavior = false;
            this.listViewDO.View = System.Windows.Forms.View.Details;
            this.listViewDO.DoubleClick += new System.EventHandler(this.listViewDO_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 25;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Description";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Address";
            this.columnHeader8.Width = 134;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            this.columnHeader10.Width = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digital Input Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digital Output Tags";
            // 
            // btnAddDO
            // 
            this.btnAddDO.Location = new System.Drawing.Point(769, 122);
            this.btnAddDO.Name = "btnAddDO";
            this.btnAddDO.Size = new System.Drawing.Size(52, 27);
            this.btnAddDO.TabIndex = 5;
            this.btnAddDO.TabStop = false;
            this.btnAddDO.Text = "+";
            this.btnAddDO.UseVisualStyleBackColor = true;
            this.btnAddDO.Click += new System.EventHandler(this.btnAddDO_Click);
            // 
            // listViewAI
            // 
            this.listViewAI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewAI.FullRowSelect = true;
            this.listViewAI.GridLines = true;
            this.listViewAI.Location = new System.Drawing.Point(12, 167);
            this.listViewAI.MultiSelect = false;
            this.listViewAI.Name = "listViewAI";
            this.listViewAI.Size = new System.Drawing.Size(428, 97);
            this.listViewAI.TabIndex = 6;
            this.listViewAI.UseCompatibleStateImageBehavior = false;
            this.listViewAI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id";
            this.columnHeader9.Width = 22;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Description";
            this.columnHeader11.Width = 130;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Address";
            this.columnHeader12.Width = 58;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Time";
            this.columnHeader13.Width = 74;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Unit";
            this.columnHeader14.Width = 43;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Value";
            this.columnHeader15.Width = 40;
            // 
            // listViewAO
            // 
            this.listViewAO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.listViewAO.FullRowSelect = true;
            this.listViewAO.GridLines = true;
            this.listViewAO.Location = new System.Drawing.Point(457, 167);
            this.listViewAO.MultiSelect = false;
            this.listViewAO.Name = "listViewAO";
            this.listViewAO.Size = new System.Drawing.Size(422, 97);
            this.listViewAO.TabIndex = 7;
            this.listViewAO.UseCompatibleStateImageBehavior = false;
            this.listViewAO.View = System.Windows.Forms.View.Details;
            this.listViewAO.DoubleClick += new System.EventHandler(this.listViewAO_DoubleClick);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Id";
            this.columnHeader16.Width = 25;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Description";
            this.columnHeader17.Width = 206;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Address";
            this.columnHeader18.Width = 56;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Unit";
            this.columnHeader19.Width = 40;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Value";
            this.columnHeader20.Width = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Analog Input Tags";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Analog Output Tags";
            // 
            // btnAddAI
            // 
            this.btnAddAI.Location = new System.Drawing.Point(334, 270);
            this.btnAddAI.Name = "btnAddAI";
            this.btnAddAI.Size = new System.Drawing.Size(49, 26);
            this.btnAddAI.TabIndex = 10;
            this.btnAddAI.Text = "+";
            this.btnAddAI.UseVisualStyleBackColor = true;
            this.btnAddAI.Click += new System.EventHandler(this.btnAddAI_Click);
            // 
            // btnAddAO
            // 
            this.btnAddAO.Location = new System.Drawing.Point(772, 270);
            this.btnAddAO.Name = "btnAddAO";
            this.btnAddAO.Size = new System.Drawing.Size(49, 27);
            this.btnAddAO.TabIndex = 11;
            this.btnAddAO.Text = "+";
            this.btnAddAO.UseVisualStyleBackColor = true;
            this.btnAddAO.Click += new System.EventHandler(this.btnAddAO_Click);
            // 
            // btnShowAlarms
            // 
            this.btnShowAlarms.Location = new System.Drawing.Point(279, 270);
            this.btnShowAlarms.Name = "btnShowAlarms";
            this.btnShowAlarms.Size = new System.Drawing.Size(49, 26);
            this.btnShowAlarms.TabIndex = 12;
            this.btnShowAlarms.Text = "Alarms";
            this.btnShowAlarms.UseVisualStyleBackColor = true;
            this.btnShowAlarms.Click += new System.EventHandler(this.btnShowAlarms_Click);
            // 
            // btnRemoveDI
            // 
            this.btnRemoveDI.Location = new System.Drawing.Point(390, 122);
            this.btnRemoveDI.Name = "btnRemoveDI";
            this.btnRemoveDI.Size = new System.Drawing.Size(50, 27);
            this.btnRemoveDI.TabIndex = 13;
            this.btnRemoveDI.Text = "-";
            this.btnRemoveDI.UseVisualStyleBackColor = true;
            this.btnRemoveDI.Click += new System.EventHandler(this.btnRemoveDI_Click);
            // 
            // btnRemoveDO
            // 
            this.btnRemoveDO.Location = new System.Drawing.Point(827, 122);
            this.btnRemoveDO.Name = "btnRemoveDO";
            this.btnRemoveDO.Size = new System.Drawing.Size(52, 27);
            this.btnRemoveDO.TabIndex = 14;
            this.btnRemoveDO.Text = "-";
            this.btnRemoveDO.UseVisualStyleBackColor = true;
            this.btnRemoveDO.Click += new System.EventHandler(this.btnRemoveDO_Click);
            // 
            // btnRemoveAI
            // 
            this.btnRemoveAI.Location = new System.Drawing.Point(391, 270);
            this.btnRemoveAI.Name = "btnRemoveAI";
            this.btnRemoveAI.Size = new System.Drawing.Size(49, 26);
            this.btnRemoveAI.TabIndex = 15;
            this.btnRemoveAI.Text = "-";
            this.btnRemoveAI.UseVisualStyleBackColor = true;
            this.btnRemoveAI.Click += new System.EventHandler(this.btnRemoveAI_Click);
            // 
            // btnRemoveAO
            // 
            this.btnRemoveAO.Location = new System.Drawing.Point(830, 270);
            this.btnRemoveAO.Name = "btnRemoveAO";
            this.btnRemoveAO.Size = new System.Drawing.Size(49, 27);
            this.btnRemoveAO.TabIndex = 16;
            this.btnRemoveAO.Text = "-";
            this.btnRemoveAO.UseVisualStyleBackColor = true;
            this.btnRemoveAO.Click += new System.EventHandler(this.btnRemoveAO_Click);
            // 
            // listViewAlarms
            // 
            this.listViewAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listViewAlarms.FullRowSelect = true;
            this.listViewAlarms.GridLines = true;
            this.listViewAlarms.Location = new System.Drawing.Point(11, 324);
            this.listViewAlarms.MultiSelect = false;
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(864, 184);
            this.listViewAlarms.TabIndex = 17;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Alarm";
            this.columnHeader21.Width = 94;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Tag";
            this.columnHeader22.Width = 69;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Message";
            this.columnHeader23.Width = 561;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Date";
            this.columnHeader24.Width = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alarms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewAlarms);
            this.Controls.Add(this.btnRemoveAO);
            this.Controls.Add(this.btnRemoveAI);
            this.Controls.Add(this.btnRemoveDO);
            this.Controls.Add(this.btnRemoveDI);
            this.Controls.Add(this.btnShowAlarms);
            this.Controls.Add(this.btnAddAO);
            this.Controls.Add(this.btnAddAI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewAO);
            this.Controls.Add(this.listViewAI);
            this.Controls.Add(this.btnAddDO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDO);
            this.Controls.Add(this.btnAddDI);
            this.Controls.Add(this.listViewDI);
            this.Name = "MainForm";
            this.Text = "Scada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDI;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAddDI;
        private System.Windows.Forms.ListView listViewDO;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDO;
        private System.Windows.Forms.ListView listViewAI;
        private System.Windows.Forms.ListView listViewAO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddAI;
        private System.Windows.Forms.Button btnAddAO;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Button btnShowAlarms;
        private System.Windows.Forms.Button btnRemoveDI;
        private System.Windows.Forms.Button btnRemoveDO;
        private System.Windows.Forms.Button btnRemoveAI;
        private System.Windows.Forms.Button btnRemoveAO;
        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
    }
}

