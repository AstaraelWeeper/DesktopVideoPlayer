﻿using System;
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
        int VerySlow = 25;
        int Slow = 15;
        int Medium = 10;
        int Fast = 5;
        

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
            if (settings.playbackSpeed == VerySlow)
            {
                    rbtnVerySlow.Checked = true;
                    rbtnSlow.Checked = false;
                    rbtnMedium.Checked = false;
                    rbtnFast.Checked = false;
            }

            else if (settings.playbackSpeed == Slow)
            {
                    rbtnVerySlow.Checked = false;
                    rbtnSlow.Checked = true;
                    rbtnMedium.Checked = false;
                    rbtnFast.Checked = false;
            }
            else if (settings.playbackSpeed == Medium)
            {
                    rbtnVerySlow.Checked = false;
                    rbtnSlow.Checked = false;
                    rbtnMedium.Checked = true;
                    rbtnFast.Checked = false;
            }
            else if (settings.playbackSpeed == Fast)
            {
                    rbtnVerySlow.Checked = false;
                    rbtnSlow.Checked = false;
                    rbtnMedium.Checked = false;
                    rbtnFast.Checked = true;
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
