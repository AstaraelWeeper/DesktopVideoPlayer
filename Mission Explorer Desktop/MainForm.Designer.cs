﻿namespace Mission_Explorer_Desktop
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
            this.loadfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.lblFilesLoadedNo = new System.Windows.Forms.Label();
            this.splitTopBottom = new System.Windows.Forms.SplitContainer();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnGoogleMaps = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTrackDistance = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.radioBackwards = new System.Windows.Forms.RadioButton();
            this.radioForwards = new System.Windows.Forms.RadioButton();
            this.listBoxSubRouteNo = new System.Windows.Forms.ListBox();
            this.lstSubRouteXML = new System.Windows.Forms.ListBox();
            this.splitLeftRight = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxfront = new System.Windows.Forms.PictureBox();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTopBottom)).BeginInit();
            this.splitTopBottom.Panel1.SuspendLayout();
            this.splitTopBottom.Panel2.SuspendLayout();
            this.splitTopBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).BeginInit();
            this.splitLeftRight.Panel1.SuspendLayout();
            this.splitLeftRight.Panel2.SuspendLayout();
            this.splitLeftRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadfilesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadfilesToolStripMenuItem
            // 
            this.loadfilesToolStripMenuItem.Name = "loadfilesToolStripMenuItem";
            this.loadfilesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.loadfilesToolStripMenuItem.Text = "Load Files";
            this.loadfilesToolStripMenuItem.Click += new System.EventHandler(this.loadFilesToolStripMenuItem_Click);
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
            this.lstRoute.Location = new System.Drawing.Point(12, 26);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstRoute.Size = new System.Drawing.Size(169, 108);
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
            // splitTopBottom
            // 
            this.splitTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTopBottom.Location = new System.Drawing.Point(0, 24);
            this.splitTopBottom.Name = "splitTopBottom";
            this.splitTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitTopBottom.Panel1
            // 
            this.splitTopBottom.Panel1.Controls.Add(this.groupBox1);
            this.splitTopBottom.Panel1.Controls.Add(this.textBox3);
            this.splitTopBottom.Panel1.Controls.Add(this.textBox2);
            this.splitTopBottom.Panel1.Controls.Add(this.textBox1);
            this.splitTopBottom.Panel1.Controls.Add(this.lblTrackDistance);
            this.splitTopBottom.Panel1.Controls.Add(this.listBoxSubRouteNo);
            this.splitTopBottom.Panel1.Controls.Add(this.lstSubRouteXML);
            this.splitTopBottom.Panel1.Controls.Add(this.lblFilesLoadedNo);
            this.splitTopBottom.Panel1.Controls.Add(this.lstRoute);
            // 
            // splitTopBottom.Panel2
            // 
            this.splitTopBottom.Panel2.Controls.Add(this.splitLeftRight);
            this.splitTopBottom.Size = new System.Drawing.Size(2584, 656);
            this.splitTopBottom.SplitterDistance = 200;
            this.splitTopBottom.TabIndex = 3;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(315, 19);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 16;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnGoogleMaps
            // 
            this.btnGoogleMaps.Location = new System.Drawing.Point(115, 129);
            this.btnGoogleMaps.Name = "btnGoogleMaps";
            this.btnGoogleMaps.Size = new System.Drawing.Size(201, 23);
            this.btnGoogleMaps.TabIndex = 15;
            this.btnGoogleMaps.Text = "View in Google Maps";
            this.btnGoogleMaps.UseVisualStyleBackColor = true;
            this.btnGoogleMaps.Click += new System.EventHandler(this.btnGoogleMaps_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(249, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Sub Routes";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(15, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Route Information";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(826, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Select a Sub Route Number";
            // 
            // lblTrackDistance
            // 
            this.lblTrackDistance.AutoSize = true;
            this.lblTrackDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackDistance.Location = new System.Drawing.Point(596, 137);
            this.lblTrackDistance.Name = "lblTrackDistance";
            this.lblTrackDistance.Size = new System.Drawing.Size(0, 16);
            this.lblTrackDistance.TabIndex = 11;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(212, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(115, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(15, 19);
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
            this.radioBackwards.Location = new System.Drawing.Point(262, 62);
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
            this.radioForwards.Location = new System.Drawing.Point(75, 62);
            this.radioForwards.Name = "radioForwards";
            this.radioForwards.Size = new System.Drawing.Size(91, 17);
            this.radioForwards.TabIndex = 6;
            this.radioForwards.TabStop = true;
            this.radioForwards.Text = "Play Forwards";
            this.radioForwards.UseVisualStyleBackColor = true;
            // 
            // listBoxSubRouteNo
            // 
            this.listBoxSubRouteNo.FormattingEnabled = true;
            this.listBoxSubRouteNo.Location = new System.Drawing.Point(883, 26);
            this.listBoxSubRouteNo.Name = "listBoxSubRouteNo";
            this.listBoxSubRouteNo.Size = new System.Drawing.Size(43, 108);
            this.listBoxSubRouteNo.TabIndex = 4;
            // 
            // lstSubRouteXML
            // 
            this.lstSubRouteXML.Enabled = false;
            this.lstSubRouteXML.FormattingEnabled = true;
            this.lstSubRouteXML.Location = new System.Drawing.Point(187, 26);
            this.lstSubRouteXML.Name = "lstSubRouteXML";
            this.lstSubRouteXML.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSubRouteXML.Size = new System.Drawing.Size(690, 108);
            this.lstSubRouteXML.TabIndex = 3;
            // 
            // splitLeftRight
            // 
            this.splitLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeftRight.Location = new System.Drawing.Point(0, 0);
            this.splitLeftRight.Name = "splitLeftRight";
            // 
            // splitLeftRight.Panel1
            // 
            this.splitLeftRight.Panel1.Controls.Add(this.splitLeft);
            // 
            // splitLeftRight.Panel2
            // 
            this.splitLeftRight.Panel2.Controls.Add(this.splitRight);
            this.splitLeftRight.Size = new System.Drawing.Size(2584, 452);
            this.splitLeftRight.SplitterDistance = 1292;
            this.splitLeftRight.SplitterWidth = 1;
            this.splitLeftRight.TabIndex = 0;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.pictureBoxLeft);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.pictureBoxfront);
            this.splitLeft.Size = new System.Drawing.Size(1292, 452);
            this.splitLeft.SplitterDistance = 646;
            this.splitLeft.SplitterWidth = 1;
            this.splitLeft.TabIndex = 0;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(646, 452);
            this.pictureBoxLeft.TabIndex = 0;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxfront
            // 
            this.pictureBoxfront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxfront.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxfront.Name = "pictureBoxfront";
            this.pictureBoxfront.Size = new System.Drawing.Size(645, 452);
            this.pictureBoxfront.TabIndex = 0;
            this.pictureBoxfront.TabStop = false;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.pictureBoxRight);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.pictureBoxBack);
            this.splitRight.Size = new System.Drawing.Size(1291, 452);
            this.splitRight.SplitterDistance = 646;
            this.splitRight.SplitterWidth = 1;
            this.splitRight.TabIndex = 0;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRight.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(646, 452);
            this.pictureBoxRight.TabIndex = 0;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(644, 452);
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnGoogleMaps);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.radioForwards);
            this.groupBox1.Controls.Add(this.radioBackwards);
            this.groupBox1.Location = new System.Drawing.Point(987, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 167);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(63, 97);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(127, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "Previous Slide";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(244, 97);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next Slide";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2584, 680);
            this.Controls.Add(this.splitTopBottom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Mission Explorer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitTopBottom.Panel1.ResumeLayout(false);
            this.splitTopBottom.Panel1.PerformLayout();
            this.splitTopBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTopBottom)).EndInit();
            this.splitTopBottom.ResumeLayout(false);
            this.splitLeftRight.Panel1.ResumeLayout(false);
            this.splitLeftRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftRight)).EndInit();
            this.splitLeftRight.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfront)).EndInit();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListBox lstRoute;
        private System.Windows.Forms.Label lblFilesLoadedNo;
        private System.Windows.Forms.SplitContainer splitTopBottom;
        private System.Windows.Forms.SplitContainer splitLeftRight;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxfront;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.ListBox lstSubRouteXML;
        private System.Windows.Forms.ListBox listBoxSubRouteNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioBackwards;
        private System.Windows.Forms.RadioButton radioForwards;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTrackDistance;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGoogleMaps;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}

