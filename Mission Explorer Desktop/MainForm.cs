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
       static ImageDisplay imageDisplay = new ImageDisplay();
       private System.Timers.Timer _timer;
        //picture indexes
       int l = 0;
       

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

        private void listBoxTest_MouseDoubleClick(object sender, MouseEventArgs e) //get chosen subroute from listbox, pass that array of file paths through
        {

            if (listBoxTest.SelectedItem != null)
            {
                int subRoute = Convert.ToInt32(listBoxTest.SelectedItem);
                imageDisplay.LoadAllPicturePaths(folderTraverse.jpgPaths[subRoute]);
                RunVideo();
            }

        }

        void RunVideo() //need some kind of timer to adjust with settings. it should pass in an int
        {
            _timer = new System.Timers.Timer(10); //this will change to number passed in.
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            _timer.AutoReset = true;
            _timer.Enabled = true;
            LoadPictures();
            

        }

        private void LoadPictures()
        {
            _timer.Stop();

            pictureBoxLeft.WaitOnLoad = false;
            pictureBoxfront.WaitOnLoad = false;
            pictureBoxRight.WaitOnLoad = false;
            pictureBoxBack.WaitOnLoad = false;

          pictureBoxLeft.LoadAsync (imageDisplay.leftPictures[l]);
          pictureBoxfront.LoadAsync (imageDisplay.frontPictures[l]);
          pictureBoxRight.LoadAsync (imageDisplay.rightPictures[l]);
          pictureBoxBack.LoadAsync (imageDisplay.backPictures[l]);

          if (l < (imageDisplay.leftPictures.Count-1))
          { l++; }
          
          _timer.Start();
        }
           
 
        private void Timer_Elapsed(object sender, EventArgs e)
        {
            LoadPictures();
        }

  
    }
}


