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
        int VerySlow = 3000;
        int Slow = 2000;
        int Medium = 500;
        int Fast = 250;
        

        public Settings settings = new Settings();

        public SettingsForm(Settings existingSettings)
        {
            InitializeComponent();
            settings = existingSettings;
            InitialseSettings();
        }


        //show existing settings on new settings form
        private void InitialseSettings()
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

            if (settings.mode == "video")
            {
                rbtnVideo.Checked = true;
                rbtnPresentation.Checked = false;
            }
            else if (settings.mode == "slideshow")
            {
                rbtnPresentation.Checked = true;
                rbtnVideo.Checked = false;
            }
            

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

        //units

       private void rdoMetres_CheckedChanged(object sender, EventArgs e)
        {
           if(rdoMetres.Checked == true)
           {
            settings.units = "metres";
           }
        }

        private void rdoMiles_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoMiles.Checked == true)
            {
            settings.units = "miles";
            }
        }

        //mode

        private void rbtnVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVideo.Checked == true)
            {
                settings.mode = "video";
                rbtnVerySlow.Enabled = true;
                rbtnSlow.Enabled = true;
                rbtnMedium.Enabled = true;
                rbtnFast.Enabled = true;
            }
        }

        private void rbtnPresentation_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPresentation.Checked == true)
            {
                settings.mode = "slideshow";
                rbtnVerySlow.Enabled = false;
                rbtnSlow.Enabled = false;
                rbtnMedium.Enabled = false;
                rbtnFast.Enabled = false;
            }
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
