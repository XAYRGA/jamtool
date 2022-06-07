namespace jam
{
    partial class JamMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdfjakdgkjadgadgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AudioTree = new System.Windows.Forms.TreeView();
            this.openAADialog = new System.Windows.Forms.OpenFileDialog();
            this.mnuLayoutPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfjakdgkjadgadgToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // asdfjakdgkjadgadgToolStripMenuItem
            // 
            this.asdfjakdgkjadgadgToolStripMenuItem.Name = "asdfjakdgkjadgadgToolStripMenuItem";
            this.asdfjakdgkjadgadgToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.asdfjakdgkjadgadgToolStripMenuItem.Text = "Open";
            this.asdfjakdgkjadgadgToolStripMenuItem.Click += new System.EventHandler(this.openToolMenu);
            // 
            // AudioTree
            // 
            this.AudioTree.Location = new System.Drawing.Point(12, 27);
            this.AudioTree.Name = "AudioTree";
            this.AudioTree.Size = new System.Drawing.Size(213, 741);
            this.AudioTree.TabIndex = 1;
            this.AudioTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AudioTree_AfterSelect);
            // 
            // openAADialog
            // 
            this.openAADialog.FileName = "openFileDialog1";
            // 
            // mnuLayoutPanel
            // 
            this.mnuLayoutPanel.Location = new System.Drawing.Point(231, 27);
            this.mnuLayoutPanel.Name = "mnuLayoutPanel";
            this.mnuLayoutPanel.Size = new System.Drawing.Size(576, 741);
            this.mnuLayoutPanel.TabIndex = 2;
            // 
            // JamMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 780);
            this.Controls.Add(this.mnuLayoutPanel);
            this.Controls.Add(this.AudioTree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JamMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.JamMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem asdfjakdgkjadgadgToolStripMenuItem;
        private TreeView AudioTree;
        private OpenFileDialog openAADialog;
        private Panel mnuLayoutPanel;
    }
}