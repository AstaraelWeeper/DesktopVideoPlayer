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
        int VerySlow = 250;
        int Slow = 500;
        int Medium = 1000;
        int Fast = 2000;
        

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

        //units

       private void rdoMetres_CheckedChanged(object sender, EventArgs e)
        {
            settings.units = "metres";
        }

        private void rdoMiles_CheckedChanged(object sender, EventArgs e)
        {
            settings.units = "miles";
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
