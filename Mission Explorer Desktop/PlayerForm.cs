using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mission_Explorer_Desktop
{
    public partial class PlayerForm : Form
    {
        public PlayerForm(string mediaPath)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = mediaPath;
            lblPlaying.Text = "Playing: " + mediaPath;
        }

        private void btnPlayNext_Click(object sender, EventArgs e)
        {
            
        }
    }
}
