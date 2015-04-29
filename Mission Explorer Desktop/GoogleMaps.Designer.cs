namespace Mission_Explorer_Desktop
{
    partial class GoogleMaps
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoPurple = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(667, 483);
            this.webBrowser1.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.rdoPurple);
            this.splitContainer1.Panel1.Controls.Add(this.rdoRed);
            this.splitContainer1.Panel1.Controls.Add(this.rdoBlue);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numZoom);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(667, 536);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marker Colour";
            // 
            // rdoPurple
            // 
            this.rdoPurple.AutoSize = true;
            this.rdoPurple.Location = new System.Drawing.Point(362, 15);
            this.rdoPurple.Name = "rdoPurple";
            this.rdoPurple.Size = new System.Drawing.Size(55, 17);
            this.rdoPurple.TabIndex = 9;
            this.rdoPurple.Text = "Purple";
            this.rdoPurple.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(287, 15);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 8;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Checked = true;
            this.rdoBlue.Location = new System.Drawing.Point(217, 15);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(46, 17);
            this.rdoBlue.TabIndex = 7;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom";
            // 
            // numZoom
            // 
            this.numZoom.Location = new System.Drawing.Point(63, 12);
            this.numZoom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numZoom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(53, 20);
            this.numZoom.TabIndex = 1;
            this.numZoom.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(451, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GoogleMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 536);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 575);
            this.MinimumSize = new System.Drawing.Size(683, 575);
            this.Name = "GoogleMaps";
            this.Text = "Google Maps";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoPurple;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlue;


    }
}