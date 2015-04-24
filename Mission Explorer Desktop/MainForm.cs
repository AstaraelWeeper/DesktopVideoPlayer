using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Ionic.Zip;
using System.Reflection;


namespace Mission_Explorer_Desktop
{
    public partial class MainForm : Form
     {
        Settings returnedSettings = new Settings();
        FolderTraverse folderTraverse = new FolderTraverse();
       List<string> JsonRouteTitle = new List<string>();
        

       public MainForm()
       {
           InitializeComponent();
           RefreshData();
       }

        private void RefreshData()
        {
          folderTraverse.getInitialData();
          JsonRouteTitle = folderTraverse.ParseJson(); //get json
          lstRoute.DataSource = JsonRouteTitle; //display it in listbox
          listBoxTest.DataSource = folderTraverse.countDirectoriesString;
     
        }

        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) //open Settings Form
        {
            SettingsForm settingsForm = new SettingsForm(returnedSettings);
            if (settingsForm.ShowDialog(this) == DialogResult.OK)
            {
                returnedSettings = settingsForm.settings;
                updateSettings();
                
            }
            else
            {
                this.txtSettingsTest.Text = "settings cancelled";
            }
            settingsForm.Dispose();
            
        }

        private void updateSettings()
        {
           // axWindowsMediaPlayer1.settings.rate = returnedSettings.playbackSpeed;
        }

        private void loadFIlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            //now will only be used to change the start folder
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                folderTraverse.startFolder = openFileDialog1.FileName;
                Refresh();
            }

        }

      

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) //click on a specific item
        {
            if (lstRoute.SelectedItem != null)
            {
                string currentFile = lstRoute.SelectedItem.ToString();
                folderTraverse.getRouteImages(currentFile); //ensure this is the subroute directory
              //  axWindowsMediaPlayer1.URL = currentFile;
              
            }
        }

        private void btnPlay_Click(object sender, EventArgs e) //select an item and press play
        {
            if (lstRoute.SelectedItem != null)
            {
                string currentFile = lstRoute.SelectedItem.ToString();
              //  axWindowsMediaPlayer1.URL = currentFile;
              //  PlayerForm playerForm = new PlayerForm(currentFile);
              //  playerForm.ShowDialog(this);
            }
        }

  
    }
}
