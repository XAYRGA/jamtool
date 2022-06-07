namespace jam
{
    partial class BankEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnkedittabs = new System.Windows.Forms.TabControl();
            this.instEditorTab = new System.Windows.Forms.TabPage();
            this.oscTab = new System.Windows.Forms.TabPage();
            this.lblIns = new System.Windows.Forms.Label();
            this.instrumentList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OsciList = new System.Windows.Forms.ListBox();
            this.envTab = new System.Windows.Forms.TabPage();
            this.sensEffTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.EnvList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.randEffTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bnkedittabs.SuspendLayout();
            this.instEditorTab.SuspendLayout();
            this.oscTab.SuspendLayout();
            this.envTab.SuspendLayout();
            this.sensEffTab.SuspendLayout();
            this.randEffTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnkedittabs
            // 
            this.bnkedittabs.Controls.Add(this.instEditorTab);
            this.bnkedittabs.Controls.Add(this.oscTab);
            this.bnkedittabs.Controls.Add(this.envTab);
            this.bnkedittabs.Controls.Add(this.sensEffTab);
            this.bnkedittabs.Controls.Add(this.randEffTab);
            this.bnkedittabs.Location = new System.Drawing.Point(3, 3);
            this.bnkedittabs.Name = "bnkedittabs";
            this.bnkedittabs.SelectedIndex = 0;
            this.bnkedittabs.Size = new System.Drawing.Size(570, 735);
            this.bnkedittabs.TabIndex = 0;
            this.bnkedittabs.SelectedIndexChanged += new System.EventHandler(this.bnkedittabs_SelectedIndexChanged);
            // 
            // instEditorTab
            // 
            this.instEditorTab.Controls.Add(this.lblIns);
            this.instEditorTab.Controls.Add(this.instrumentList);
            this.instEditorTab.Location = new System.Drawing.Point(4, 24);
            this.instEditorTab.Name = "instEditorTab";
            this.instEditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.instEditorTab.Size = new System.Drawing.Size(562, 707);
            this.instEditorTab.TabIndex = 0;
            this.instEditorTab.Text = "INST";
            this.instEditorTab.UseVisualStyleBackColor = true;
            this.instEditorTab.Click += new System.EventHandler(this.instEditorTab_Click);
            // 
            // oscTab
            // 
            this.oscTab.Controls.Add(this.label1);
            this.oscTab.Controls.Add(this.OsciList);
            this.oscTab.Location = new System.Drawing.Point(4, 24);
            this.oscTab.Name = "oscTab";
            this.oscTab.Padding = new System.Windows.Forms.Padding(3);
            this.oscTab.Size = new System.Drawing.Size(562, 707);
            this.oscTab.TabIndex = 1;
            this.oscTab.Text = "OSCI";
            this.oscTab.UseVisualStyleBackColor = true;
            this.oscTab.Click += new System.EventHandler(this.oscTab_Click);
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.Location = new System.Drawing.Point(6, 3);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(70, 15);
            this.lblIns.TabIndex = 15;
            this.lblIns.Text = "Instruments";
            this.lblIns.Click += new System.EventHandler(this.lblIns_Click);
            // 
            // instrumentList
            // 
            this.instrumentList.FormattingEnabled = true;
            this.instrumentList.ItemHeight = 15;
            this.instrumentList.Location = new System.Drawing.Point(6, 21);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.Size = new System.Drawing.Size(213, 679);
            this.instrumentList.TabIndex = 12;
            this.instrumentList.SelectedIndexChanged += new System.EventHandler(this.instrumentList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Oscillators";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // OsciList
            // 
            this.OsciList.FormattingEnabled = true;
            this.OsciList.ItemHeight = 15;
            this.OsciList.Location = new System.Drawing.Point(6, 24);
            this.OsciList.Name = "OsciList";
            this.OsciList.Size = new System.Drawing.Size(209, 679);
            this.OsciList.TabIndex = 17;
            this.OsciList.SelectedIndexChanged += new System.EventHandler(this.OsciList_SelectedIndexChanged);
            // 
            // envTab
            // 
            this.envTab.Controls.Add(this.label2);
            this.envTab.Controls.Add(this.EnvList);
            this.envTab.Location = new System.Drawing.Point(4, 24);
            this.envTab.Name = "envTab";
            this.envTab.Padding = new System.Windows.Forms.Padding(3);
            this.envTab.Size = new System.Drawing.Size(562, 707);
            this.envTab.TabIndex = 2;
            this.envTab.Text = "ENV";
            this.envTab.UseVisualStyleBackColor = true;
            this.envTab.Click += new System.EventHandler(this.envTab_Click);
            // 
            // sensEffTab
            // 
            this.sensEffTab.Controls.Add(this.label3);
            this.sensEffTab.Controls.Add(this.listBox1);
            this.sensEffTab.Location = new System.Drawing.Point(4, 24);
            this.sensEffTab.Name = "sensEffTab";
            this.sensEffTab.Padding = new System.Windows.Forms.Padding(3);
            this.sensEffTab.Size = new System.Drawing.Size(562, 707);
            this.sensEffTab.TabIndex = 3;
            this.sensEffTab.Text = "SENS";
            this.sensEffTab.UseVisualStyleBackColor = true;
            this.sensEffTab.Click += new System.EventHandler(this.sensEffTab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Envelopes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EnvList
            // 
            this.EnvList.FormattingEnabled = true;
            this.EnvList.ItemHeight = 15;
            this.EnvList.Location = new System.Drawing.Point(188, 248);
            this.EnvList.Name = "EnvList";
            this.EnvList.Size = new System.Drawing.Size(186, 229);
            this.EnvList.TabIndex = 18;
            this.EnvList.SelectedIndexChanged += new System.EventHandler(this.EnvList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Envelopes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(188, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 229);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // randEffTab
            // 
            this.randEffTab.Controls.Add(this.label4);
            this.randEffTab.Controls.Add(this.listBox2);
            this.randEffTab.Location = new System.Drawing.Point(4, 24);
            this.randEffTab.Name = "randEffTab";
            this.randEffTab.Padding = new System.Windows.Forms.Padding(3);
            this.randEffTab.Size = new System.Drawing.Size(562, 707);
            this.randEffTab.TabIndex = 4;
            this.randEffTab.Text = "RAND";
            this.randEffTab.UseVisualStyleBackColor = true;
            this.randEffTab.Click += new System.EventHandler(this.randEffTab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Envelopes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(6, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 664);
            this.listBox2.TabIndex = 18;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // BankEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.bnkedittabs);
            this.Name = "BankEditor";
            this.Size = new System.Drawing.Size(576, 741);
            this.bnkedittabs.ResumeLayout(false);
            this.instEditorTab.ResumeLayout(false);
            this.instEditorTab.PerformLayout();
            this.oscTab.ResumeLayout(false);
            this.oscTab.PerformLayout();
            this.envTab.ResumeLayout(false);
            this.envTab.PerformLayout();
            this.sensEffTab.ResumeLayout(false);
            this.sensEffTab.PerformLayout();
            this.randEffTab.ResumeLayout(false);
            this.randEffTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl bnkedittabs;
        private TabPage instEditorTab;
        private Label lblIns;
        private ListBox instrumentList;
        private TabPage oscTab;
        private Label label1;
        private ListBox OsciList;
        private TabPage envTab;
        private Label label2;
        private ListBox EnvList;
        private TabPage sensEffTab;
        private Label label3;
        private ListBox listBox1;
        private TabPage randEffTab;
        private Label label4;
        private ListBox listBox2;
    }
}
