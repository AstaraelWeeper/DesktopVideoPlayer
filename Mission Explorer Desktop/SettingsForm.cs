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
    public partial class SettingsForm : Form
    {
        public Settings settings = new Settings();

        public SettingsForm()
        {
            InitializeComponent();

        }


        //update settings from buttons

        private void rbtnVerySlow_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = 0.25;  //1 = very slow
        }

        private void rbtnSlow_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = 0.6; //2 = slow
        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = 1.0; //3= medium
        }

        private void rbtnFast_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = 2.0; //4 = fast
        }

        private void chkScale_CheckedChanged(object sender, EventArgs e)
        {
            settings.scaleImages = chkScale.Checked;
        }


        //return buttons

        private void btnSettingsApply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }

        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
