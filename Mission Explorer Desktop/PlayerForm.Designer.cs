namespace Mission_Explorer_Desktop
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPlayPrevious = new System.Windows.Forms.Button();
            this.btnPlayNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.78744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.212561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 414);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlayNext);
            this.panel1.Controls.Add(this.btnPlayPrevious);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(290, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 29);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.axVLCPlugin21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 373);
            this.panel3.TabIndex = 2;
            // 
            // btnPlayPrevious
            // 
            this.btnPlayPrevious.Location = new System.Drawing.Point(3, 3);
            this.btnPlayPrevious.Name = "btnPlayPrevious";
            this.btnPlayPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPrevious.TabIndex = 0;
            this.btnPlayPrevious.Text = "Previous";
            this.btnPlayPrevious.UseVisualStyleBackColor = true;
            // 
            // btnPlayNext
            // 
            this.btnPlayNext.Location = new System.Drawing.Point(206, 3);
            this.btnPlayNext.Name = "btnPlayNext";
            this.btnPlayNext.Size = new System.Drawing.Size(75, 23);
            this.btnPlayNext.TabIndex = 1;
            this.btnPlayNext.Text = "Next";
            this.btnPlayNext.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(100, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "button1";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(3, 3);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(562, 370);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Player";
            this.Text = "Player";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayNext;
        private System.Windows.Forms.Button btnPlayPrevious;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel3;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
    }
}