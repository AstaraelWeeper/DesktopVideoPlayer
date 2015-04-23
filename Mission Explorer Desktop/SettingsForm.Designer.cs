namespace Mission_Explorer_Desktop
{
    partial class SettingsForm
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
            this.lblPlaybackSpeed = new System.Windows.Forms.Label();
            this.rbtnVerySlow = new System.Windows.Forms.RadioButton();
            this.rbtnSlow = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnFast = new System.Windows.Forms.RadioButton();
            this.chkScale = new System.Windows.Forms.CheckBox();
            this.btnSettingsApply = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaybackSpeed
            // 
            this.lblPlaybackSpeed.AutoSize = true;
            this.lblPlaybackSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaybackSpeed.Location = new System.Drawing.Point(13, 13);
            this.lblPlaybackSpeed.Name = "lblPlaybackSpeed";
            this.lblPlaybackSpeed.Size = new System.Drawing.Size(136, 13);
            this.lblPlaybackSpeed.TabIndex = 0;
            this.lblPlaybackSpeed.Text = "Select the Playback Speed";
            // 
            // rbtnVerySlow
            // 
            this.rbtnVerySlow.AutoSize = true;
            this.rbtnVerySlow.Location = new System.Drawing.Point(13, 43);
            this.rbtnVerySlow.Name = "rbtnVerySlow";
            this.rbtnVerySlow.Size = new System.Drawing.Size(72, 17);
            this.rbtnVerySlow.TabIndex = 1;
            this.rbtnVerySlow.Text = "Very Slow";
            this.rbtnVerySlow.UseVisualStyleBackColor = true;
            this.rbtnVerySlow.CheckedChanged += new System.EventHandler(this.rbtnVerySlow_CheckedChanged);
            // 
            // rbtnSlow
            // 
            this.rbtnSlow.AutoSize = true;
            this.rbtnSlow.Location = new System.Drawing.Point(105, 43);
            this.rbtnSlow.Name = "rbtnSlow";
            this.rbtnSlow.Size = new System.Drawing.Size(48, 17);
            this.rbtnSlow.TabIndex = 2;
            this.rbtnSlow.Text = "Slow";
            this.rbtnSlow.UseVisualStyleBackColor = true;
            this.rbtnSlow.CheckedChanged += new System.EventHandler(this.rbtnSlow_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Checked = true;
            this.rbtnMedium.Location = new System.Drawing.Point(173, 43);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rbtnMedium.TabIndex = 3;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged);
            // 
            // rbtnFast
            // 
            this.rbtnFast.AutoSize = true;
            this.rbtnFast.Location = new System.Drawing.Point(262, 43);
            this.rbtnFast.Name = "rbtnFast";
            this.rbtnFast.Size = new System.Drawing.Size(45, 17);
            this.rbtnFast.TabIndex = 4;
            this.rbtnFast.Text = "Fast";
            this.rbtnFast.UseVisualStyleBackColor = true;
            this.rbtnFast.CheckedChanged += new System.EventHandler(this.rbtnFast_CheckedChanged);
            // 
            // chkScale
            // 
            this.chkScale.AutoSize = true;
            this.chkScale.Location = new System.Drawing.Point(16, 81);
            this.chkScale.Name = "chkScale";
            this.chkScale.Size = new System.Drawing.Size(143, 17);
            this.chkScale.TabIndex = 5;
            this.chkScale.Text = "Scale Images To Screen";
            this.chkScale.UseVisualStyleBackColor = true;
            this.chkScale.CheckedChanged += new System.EventHandler(this.chkScale_CheckedChanged);
            // 
            // btnSettingsApply
            // 
            this.btnSettingsApply.Location = new System.Drawing.Point(34, 120);
            this.btnSettingsApply.Name = "btnSettingsApply";
            this.btnSettingsApply.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsApply.TabIndex = 6;
            this.btnSettingsApply.Text = "Apply";
            this.btnSettingsApply.UseVisualStyleBackColor = true;
            this.btnSettingsApply.Click += new System.EventHandler(this.btnSettingsApply_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettingsCancel.Location = new System.Drawing.Point(182, 120);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 7;
            this.btnSettingsCancel.Text = "Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSettingsApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSettingsCancel;
            this.ClientSize = new System.Drawing.Size(322, 163);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsApply);
            this.Controls.Add(this.chkScale);
            this.Controls.Add(this.rbtnFast);
            this.Controls.Add(this.rbtnMedium);
            this.Controls.Add(this.rbtnSlow);
            this.Controls.Add(this.rbtnVerySlow);
            this.Controls.Add(this.lblPlaybackSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaybackSpeed;
        private System.Windows.Forms.RadioButton rbtnVerySlow;
        private System.Windows.Forms.RadioButton rbtnSlow;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnFast;
        private System.Windows.Forms.CheckBox chkScale;
        private System.Windows.Forms.Button btnSettingsApply;
        private System.Windows.Forms.Button btnSettingsCancel;
    }
}