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
        double VerySlow = 0.25;
        double Slow = 0.6;
        double Medium = 1.0;
        double Fast = 2.0;


        public Settings settings = new Settings();

        public SettingsForm(Settings existingSettings)
        {
            InitializeComponent();
            settings = existingSettings;
            initialseSettings();
        }


        //show existing settings on new settings form
        private void initialseSettings()
        {
            switch (settings.playbackSpeed.ToString())
            {
                case "0.25":
                    rbtnVerySlow.Checked = true;
                    rbtnSlow.Checked = false;
                    rbtnMedium.Checked = false;
                    rbtnFast.Checked = false;
                    break;

                case "0.6":
                    rbtnVerySlow.Checked = false;
                    rbtnSlow.Checked = true;
                    rbtnMedium.Checked = false;
                    rbtnFast.Checked = false;
                    break;
                case "1.0":
                    rbtnVerySlow.Checked = false;
                    rbtnSlow.Checked = false;
                    rbtnMedium.Checked = true;
                    rbtnFast.Checked = false;
                    break;
                case "2.0":
                    rbtnVerySlow.Checked = false;
                    rbtnSlow.Checked = false;
                    rbtnMedium.Checked = false;
                    rbtnFast.Checked = true;
                    break;
            }

            chkScale.Checked = settings.scaleImages;

        }

        //update settings from buttons

        private void rbtnVerySlow_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = VerySlow;  
        }

        private void rbtnSlow_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = Slow; 
        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = Medium;
        }

        private void rbtnFast_CheckedChanged(object sender, EventArgs e)
        {
            settings.playbackSpeed = Fast; 
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
