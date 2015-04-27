namespace Mission_Explorer_Desktop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.lblFilesLoadedNo = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.radioBackwards = new System.Windows.Forms.RadioButton();
            this.radioForwards = new System.Windows.Forms.RadioButton();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.lstSubRoute = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxfront = new System.Windows.Forms.PictureBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFIleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFIleToolStripMenuItem
            // 
            this.loadFIleToolStripMenuItem.Name = "loadFIleToolStripMenuItem";
            this.loadFIleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadFIleToolStripMenuItem.Text = "Load Files";
            this.loadFIleToolStripMenuItem.Click += new System.EventHandler(this.loadFIlesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // lstRoute
            // 
            this.lstRoute.Enabled = false;
            this.lstRoute.FormattingEnabled = true;
            this.lstRoute.Location = new System.Drawing.Point(15, 27);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstRoute.Size = new System.Drawing.Size(268, 69);
            this.lstRoute.TabIndex = 1;
            // 
            // lblFilesLoadedNo
            // 
            this.lblFilesLoadedNo.AutoSize = true;
            this.lblFilesLoadedNo.Location = new System.Drawing.Point(12, 438);
            this.lblFilesLoadedNo.Name = "lblFilesLoadedNo";
            this.lblFilesLoadedNo.Size = new System.Drawing.Size(0, 13);
            this.lblFilesLoadedNo.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnPause);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlay);
            this.splitContainer1.Panel1.Controls.Add(this.radioBackwards);
            this.splitContainer1.Panel1.Controls.Add(this.radioForwards);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxTest);
            this.splitContainer1.Panel1.Controls.Add(this.lstSubRoute);
            this.splitContainer1.Panel1.Controls.Add(this.lblFilesLoadedNo);
            this.splitContainer1.Panel1.Controls.Add(this.lstRoute);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1380, 594);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1176, 39);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(1058, 39);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(933, 39);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // radioBackwards
            // 
            this.radioBackwards.AutoSize = true;
            this.radioBackwards.Location = new System.Drawing.Point(1058, 78);
            this.radioBackwards.Name = "radioBackwards";
            this.radioBackwards.Size = new System.Drawing.Size(101, 17);
            this.radioBackwards.TabIndex = 7;
            this.radioBackwards.Text = "Play Backwards";
            this.radioBackwards.UseVisualStyleBackColor = true;
            // 
            // radioForwards
            // 
            this.radioForwards.AutoSize = true;
            this.radioForwards.Checked = true;
            this.radioForwards.Location = new System.Drawing.Point(933, 78);
            this.radioForwards.Name = "radioForwards";
            this.radioForwards.Size = new System.Drawing.Size(91, 17);
            this.radioForwards.TabIndex = 6;
            this.radioForwards.TabStop = true;
            this.radioForwards.Text = "Play Forwards";
            this.radioForwards.UseVisualStyleBackColor = true;
            // 
            // listBoxTest
            // 
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.Location = new System.Drawing.Point(760, 28);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(115, 69);
            this.listBoxTest.TabIndex = 4;
            this.listBoxTest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTest_MouseDoubleClick);
            // 
            // lstSubRoute
            // 
            this.lstSubRoute.FormattingEnabled = true;
            this.lstSubRoute.Location = new System.Drawing.Point(308, 28);
            this.lstSubRoute.Name = "lstSubRoute";
            this.lstSubRoute.Size = new System.Drawing.Size(357, 69);
            this.lstSubRoute.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1380, 481);
            this.splitContainer2.SplitterDistance = 665;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pictureBoxLeft);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxfront);
            this.splitContainer3.Size = new System.Drawing.Size(665, 481);
            this.splitContainer3.SplitterDistance = 322;
            this.splitContainer3.TabIndex = 0;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(322, 481);
            this.pictureBoxLeft.TabIndex = 0;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxfront
            // 
            this.pictureBoxfront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxfront.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxfront.Name = "pictureBoxfront";
            this.pictureBoxfront.Size = new System.Drawing.Size(339, 481);
            this.pictureBoxfront.TabIndex = 0;
            this.pictureBoxfront.TabStop = false;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.pictureBoxRight);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.pictureBoxBack);
            this.splitContainer4.Size = new System.Drawing.Size(711, 481);
            this.splitContainer4.SplitterDistance = 355;
            this.splitContainer4.TabIndex = 0;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRight.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(355, 481);
            this.pictureBoxRight.TabIndex = 0;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(352, 481);
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 594);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Mission Explorer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfront)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFIleToolStripMenuItem;
        private System.Windows.Forms.ListBox lstRoute;
        private System.Windows.Forms.Label lblFilesLoadedNo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxfront;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.ListBox lstSubRoute;
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioBackwards;
        private System.Windows.Forms.RadioButton radioForwards;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
    }
}

