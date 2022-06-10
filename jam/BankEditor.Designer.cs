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
            this.lblIns = new System.Windows.Forms.Label();
            this.instrumentList = new System.Windows.Forms.ListBox();
            this.oscTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.osciList = new System.Windows.Forms.ListBox();
            this.envTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.envVectorMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.envValue = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.envTime = new System.Windows.Forms.NumericUpDown();
            this.vectorList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.envList = new System.Windows.Forms.ListBox();
            this.sensEffTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.sensList = new System.Windows.Forms.ListBox();
            this.randEffTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.randList = new System.Windows.Forms.ListBox();
            this.bnkedittabs.SuspendLayout();
            this.instEditorTab.SuspendLayout();
            this.oscTab.SuspendLayout();
            this.envTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.envValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envTime)).BeginInit();
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
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.Location = new System.Drawing.Point(6, 7);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(70, 15);
            this.lblIns.TabIndex = 15;
            this.lblIns.Text = "Instruments";
            // 
            // instrumentList
            // 
            this.instrumentList.FormattingEnabled = true;
            this.instrumentList.ItemHeight = 15;
            this.instrumentList.Location = new System.Drawing.Point(6, 25);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.Size = new System.Drawing.Size(186, 649);
            this.instrumentList.TabIndex = 12;
            // 
            // oscTab
            // 
            this.oscTab.Controls.Add(this.label1);
            this.oscTab.Controls.Add(this.osciList);
            this.oscTab.Location = new System.Drawing.Point(4, 24);
            this.oscTab.Name = "oscTab";
            this.oscTab.Padding = new System.Windows.Forms.Padding(3);
            this.oscTab.Size = new System.Drawing.Size(562, 707);
            this.oscTab.TabIndex = 1;
            this.oscTab.Text = "OSC";
            this.oscTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Instruments";
            // 
            // osciList
            // 
            this.osciList.FormattingEnabled = true;
            this.osciList.ItemHeight = 15;
            this.osciList.Location = new System.Drawing.Point(6, 25);
            this.osciList.Name = "osciList";
            this.osciList.Size = new System.Drawing.Size(186, 649);
            this.osciList.TabIndex = 16;
            // 
            // envTab
            // 
            this.envTab.Controls.Add(this.label9);
            this.envTab.Controls.Add(this.envVectorMode);
            this.envTab.Controls.Add(this.label8);
            this.envTab.Controls.Add(this.label7);
            this.envTab.Controls.Add(this.label6);
            this.envTab.Controls.Add(this.envValue);
            this.envTab.Controls.Add(this.label5);
            this.envTab.Controls.Add(this.envTime);
            this.envTab.Controls.Add(this.vectorList);
            this.envTab.Controls.Add(this.label2);
            this.envTab.Controls.Add(this.envList);
            this.envTab.Location = new System.Drawing.Point(4, 24);
            this.envTab.Name = "envTab";
            this.envTab.Padding = new System.Windows.Forms.Padding(3);
            this.envTab.Size = new System.Drawing.Size(562, 707);
            this.envTab.TabIndex = 2;
            this.envTab.Text = "ENV";
            this.envTab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "MODE";
            // 
            // envVectorMode
            // 
            this.envVectorMode.FormattingEnabled = true;
            this.envVectorMode.Items.AddRange(new object[] {
            "0x00 LINEAR",
            "0x01 SQUARE",
            "0x02 SQUARE_ROOT",
            "0x03 SAMPLECELL ",
            "0x0D LOOP ",
            "0x0E HOLD  ",
            "0x0F STOP",
            ""});
            this.envVectorMode.Location = new System.Drawing.Point(197, 428);
            this.envVectorMode.Name = "envVectorMode";
            this.envVectorMode.Size = new System.Drawing.Size(359, 23);
            this.envVectorMode.TabIndex = 25;
            this.envVectorMode.SelectedIndexChanged += new System.EventHandler(this.envVectorMode_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "32768";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "VALUE";
            // 
            // envValue
            // 
            this.envValue.Location = new System.Drawing.Point(197, 516);
            this.envValue.Maximum = 32767;
            this.envValue.Name = "envValue";
            this.envValue.Size = new System.Drawing.Size(358, 45);
            this.envValue.TabIndex = 21;
            this.envValue.Scroll += new System.EventHandler(this.envValue_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "DELTA TIME";
            // 
            // envTime
            // 
            this.envTime.Location = new System.Drawing.Point(197, 472);
            this.envTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.envTime.Name = "envTime";
            this.envTime.Size = new System.Drawing.Size(358, 23);
            this.envTime.TabIndex = 19;
            this.envTime.ValueChanged += new System.EventHandler(this.envTime_ValueChanged);
            // 
            // vectorList
            // 
            this.vectorList.FormattingEnabled = true;
            this.vectorList.ItemHeight = 15;
            this.vectorList.Location = new System.Drawing.Point(198, 270);
            this.vectorList.Name = "vectorList";
            this.vectorList.Size = new System.Drawing.Size(358, 124);
            this.vectorList.TabIndex = 18;
            this.vectorList.SelectedIndexChanged += new System.EventHandler(this.vectorList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Instruments";
            // 
            // envList
            // 
            this.envList.FormattingEnabled = true;
            this.envList.ItemHeight = 15;
            this.envList.Location = new System.Drawing.Point(6, 25);
            this.envList.Name = "envList";
            this.envList.Size = new System.Drawing.Size(186, 649);
            this.envList.TabIndex = 16;
            this.envList.SelectedIndexChanged += new System.EventHandler(this.envList_SelectedIndexChanged);
            // 
            // sensEffTab
            // 
            this.sensEffTab.Controls.Add(this.label3);
            this.sensEffTab.Controls.Add(this.sensList);
            this.sensEffTab.Location = new System.Drawing.Point(4, 24);
            this.sensEffTab.Name = "sensEffTab";
            this.sensEffTab.Padding = new System.Windows.Forms.Padding(3);
            this.sensEffTab.Size = new System.Drawing.Size(562, 707);
            this.sensEffTab.TabIndex = 3;
            this.sensEffTab.Text = "SENS";
            this.sensEffTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Instruments";
            // 
            // sensList
            // 
            this.sensList.FormattingEnabled = true;
            this.sensList.ItemHeight = 15;
            this.sensList.Location = new System.Drawing.Point(6, 25);
            this.sensList.Name = "sensList";
            this.sensList.Size = new System.Drawing.Size(186, 649);
            this.sensList.TabIndex = 16;
            // 
            // randEffTab
            // 
            this.randEffTab.Controls.Add(this.label4);
            this.randEffTab.Controls.Add(this.randList);
            this.randEffTab.Location = new System.Drawing.Point(4, 24);
            this.randEffTab.Name = "randEffTab";
            this.randEffTab.Padding = new System.Windows.Forms.Padding(3);
            this.randEffTab.Size = new System.Drawing.Size(562, 707);
            this.randEffTab.TabIndex = 4;
            this.randEffTab.Text = "RAND";
            this.randEffTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Instruments";
            // 
            // randList
            // 
            this.randList.FormattingEnabled = true;
            this.randList.ItemHeight = 15;
            this.randList.Location = new System.Drawing.Point(6, 25);
            this.randList.Name = "randList";
            this.randList.Size = new System.Drawing.Size(186, 664);
            this.randList.TabIndex = 16;
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
            ((System.ComponentModel.ISupportInitialize)(this.envValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envTime)).EndInit();
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
        private TabPage envTab;
        private TabPage sensEffTab;
        private TabPage randEffTab;
        private Label label1;
        private ListBox osciList;
        private Label label2;
        private ListBox envList;
        private Label label3;
        private ListBox sensList;
        private Label label4;
        private ListBox randList;
        private BankEnvelopeEditor bankOscillatorEditor1;
        private BankEnvelopeEditor bankOscillatorEditor2;
        private ListBox vectorList;
        private Label label9;
        private ComboBox envVectorMode;
        private Label label8;
        private Label label7;
        private Label label6;
        private TrackBar envValue;
        private Label label5;
        private NumericUpDown envTime;
    }
}
