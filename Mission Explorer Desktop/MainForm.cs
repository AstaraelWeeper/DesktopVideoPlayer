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
using System.IO;


namespace Mission_Explorer_Desktop
{
    public partial class MainForm : Form
     {
        Settings returnedSettings = new Settings();
        FolderTraverse folderTraverse = new FolderTraverse();
        XMLparse xmlparse = new XMLparse();
       List<string> JsonRouteTitle = new List<string>();
       List<string> leftPictures = new List<string>();
       List<string> frontPictures = new List<string>();
       List<string> rightPictures = new List<string>();
       List<string> backPictures = new List<string>();
       private System.Timers.Timer _timer;
        //picture indexes
       int frameNumber = 0;
       int settingsSpeedMultiplier = 1000;
       int playSpeed = 0;
        List<string> frameInfo = new List<string>();
        int subRoute = 0;
        bool playing;
       private static GoogleMaps googleMaps = null;
       int channels = 0; //this can be changed if the xml indicates more than 4 screens are used
       int currentSubroute = -1;
       int slideshowSpeed = 5000;
       
       

       public MainForm()
       {
           InitializeComponent();
           // MainForm.ActiveForm.Width = 2600;
           splitLeftRight.SplitterDistance = splitLeftRight.Size.Width / 2;
           splitLeft.SplitterDistance = splitLeft.Size.Width / 2;
           splitRight.SplitterDistance = splitRight.Size.Width / 2;
           
           
       }

        private void RefreshData()
        {
          
          if (string.IsNullOrEmpty(folderTraverse.startFolder))
          {//error
          }
          else
          {
              folderTraverse.getInitialData();
              JsonRouteTitle = folderTraverse.ParseJson(); //get json
              lstRoute.DataSource = JsonRouteTitle; //display it in listbox
              listBoxSubRouteNo.DataSource = folderTraverse.countDirectoriesString;
              lstSubRouteXML.DataSource = xmlparse.GetSubRouteTitles(folderTraverse.xmlFilePaths);
          }

        }

        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) //open Settings Form
        {
            if (_timer != null)
            {
                _timer.Stop();
            }
            SettingsForm settingsForm = new SettingsForm(returnedSettings);
            if (settingsForm.ShowDialog(this) == DialogResult.OK)
            {
                returnedSettings = settingsForm.settings; //returned settings come through from the settings form
                updateSettings(); 
            }
            
            settingsForm.Dispose();
            
        }

        private void updateSettings()
        {
           settingsSpeedMultiplier = returnedSettings.playbackSpeed;
            if(returnedSettings.scaleImages == true)
            {
                pictureBoxLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxfront.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxRight.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (returnedSettings.scaleImages == false)
            {
                pictureBoxLeft.SizeMode = PictureBoxSizeMode.Normal;
                pictureBoxfront.SizeMode = PictureBoxSizeMode.Normal;
                pictureBoxRight.SizeMode = PictureBoxSizeMode.Normal;
                pictureBoxBack.SizeMode = PictureBoxSizeMode.Normal;
            }
            if (_timer != null)
            {
                playSpeed = settingsSpeedMultiplier / xmlparse.FPS[subRoute]; //added to use the FPS from XML

                if (returnedSettings.mode == "video")
                {
                    _timer.Interval = playSpeed;
                    btnNext.Enabled = false;
                    btnPrevious.Enabled = false;
                    radioBackwards.Enabled = true;
                    radioForwards.Enabled = true;
                }
                else if (returnedSettings.mode == "slideshow")
                {
                    _timer.Interval = slideshowSpeed;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    radioBackwards.Enabled = false;
                    radioForwards.Enabled = false;
                }
            }
        }

        private void loadFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                folderTraverse.startFolder = openFileDialog1.FileName;
                RefreshData();
            }

        }


        void SetUpNewVideo() 
        {
            frameInfo = xmlparse.GetFrameInfo(folderTraverse.xmlFilePaths[subRoute]); //returns frame info
            channels = xmlparse.GetChannelNumber(folderTraverse.xmlFilePaths[subRoute]);
            playSpeed = settingsSpeedMultiplier / xmlparse.FPS[subRoute]; //added to use the FPS from XML

            if (returnedSettings.mode == "video")
            {
              _timer = new System.Timers.Timer(playSpeed); //this will change to number passed in.
            }

             else if (returnedSettings.mode == "slideshow")
            {
              _timer = new System.Timers.Timer(slideshowSpeed); //this will change to number passed in.
            }
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            _timer.AutoReset = true;
            _timer.Enabled = true;
            frameNumber = 0;
            playing = true;

            

            for (int i = 0; i < channels; i++)
            {
                ImageDisplay imageDisplay = new ImageDisplay();

                if (i == 0)
                {
                    leftPictures = imageDisplay.LoadAllPicturePaths(folderTraverse.jpgPaths[subRoute], i, channels);
                }
                else if (i == 1)
                {
                    frontPictures = imageDisplay.LoadAllPicturePaths(folderTraverse.jpgPaths[subRoute], i, channels);
                }
                else if (i == 2)
                {
                    rightPictures = imageDisplay.LoadAllPicturePaths(folderTraverse.jpgPaths[subRoute], i, channels);
                }
                else if (i == 3)
                {
                    backPictures = imageDisplay.LoadAllPicturePaths(folderTraverse.jpgPaths[subRoute], i, channels);
                }


            } 
            LoadPictures();
            

        }

        private void LoadPictures()
        {
            
            _timer.Stop();

         
                pictureBoxLeft.WaitOnLoad = false;
                pictureBoxfront.WaitOnLoad = false;
                pictureBoxRight.WaitOnLoad = false;
                pictureBoxBack.WaitOnLoad = false;

                pictureBoxLeft.LoadAsync(leftPictures[frameNumber]);
                pictureBoxfront.LoadAsync(frontPictures[frameNumber]);
                pictureBoxRight.LoadAsync(rightPictures[frameNumber]);
                pictureBoxBack.LoadAsync(backPictures[frameNumber]);

            UpdateTrackDistance();
        }

        private void UpdateTrackDistance()
        {
            if (lblTrackDistance.InvokeRequired)
            {
                lblTrackDistance.BeginInvoke(new Action(() =>
                    {
                        UpdateTrackLabel();

                    }));

            }
            else

                UpdateTrackLabel();
        }

        private void UpdateTrackLabel()
        {
            if (returnedSettings.units == "meters")
            {
                lblTrackDistance.Text = "Distance = " + string.Format(frameInfo[frameNumber]) + " " + returnedSettings.units;
            }
            else if (returnedSettings.units == "miles")
            {
                double frameInfoDouble = (Double.Parse(frameInfo[frameNumber]) / 1609.344);//convert to miles
                lblTrackDistance.Text = "Distance = " + frameInfoDouble.ToString("F") + " " + returnedSettings.units;
            }
        }


        private void NextFrame(){

                if (radioForwards.Checked == true)
                {
                    if (frameNumber < (leftPictures.Count - 1)) //should all be the same
                    { frameNumber++; }

                }

                else if (radioBackwards.Checked == true)
                {
                    if (frameNumber > 0)
                    { frameNumber--; }
                }
             
            _timer.Start();
        }


        private void Timer_Elapsed(object sender, EventArgs e)
        {
            LoadPictures();
            NextFrame();
        }

        private void btnStop_Click(object sender, EventArgs e) //stop and clear
        {
                _timer.Stop();
                playing = false;
                pictureBoxLeft.Image = null;
                pictureBoxfront.Image = null;
                pictureBoxRight.Image = null;
                pictureBoxBack.Image = null;

                lblTrackDistance.Text = "";

                frameNumber = 0;


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _timer.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listBoxSubRouteNo.SelectedItem != null)
            {
                subRoute = Convert.ToInt32(listBoxSubRouteNo.SelectedItem);
                if (subRoute != currentSubroute)
                {
                    currentSubroute = subRoute;
                    SetUpNewVideo();
                }

                LoadPictures();
                _timer.Start();
            }
        }

        private void btnGoogleMaps_Click(object sender, EventArgs e)
        {
            if(_timer !=null)
            { _timer.Stop(); }

            if (playing == true)
            {
                string check = xmlparse.GoogleMapsCoords[frameNumber];
                if (googleMaps == null)
                {
                    googleMaps = new GoogleMaps(check);
                    googleMaps.Show();
                }
                else
                {
                    googleMaps.AddMarkers(check);
                    googleMaps.Focus();
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            frameNumber = 0;
            _timer.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            if (frameNumber < (leftPictures.Count - 1)) //should all be the same
            { frameNumber++; }
            LoadPictures();
            _timer.Start();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            if (frameNumber > 0)
            { frameNumber--; }
            LoadPictures();
            _timer.Start();
        }

  
    }
}


