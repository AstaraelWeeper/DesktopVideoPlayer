using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mission_Explorer_Desktop
{
    public partial class MainForm : Form
     {
        Settings returnedSettings = new Settings();

       private const string DLLfilepath = "C:\\Program Files (x86)\\VideoLAN\\VLC\\axvlc.dll";
       List<string> filesLoaded = new List<string>();
       private int fileCounter = 0;
       
        
        public MainForm()
        {
            InitializeComponent();
            RegisterDll(DLLfilepath);
        }
         
        public static void RegisterDll(string filePath)
        {
            string fileinfo = String.Format(@"/s ""{0}""", filePath);
            Process process = new Process();
            process.StartInfo.FileName = "regsvr32.exe";
            process.StartInfo.Arguments = fileinfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.WaitForExit();
            process.Close();
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
            axWindowsMediaPlayer1.settings.rate = returnedSettings.playbackSpeed;
        }

        private void loadFIlesToolStripMenuItem_Click(object sender, EventArgs e) //loading files from local folder
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Video Files | *.mp4;*.mov;*.mpeg;*.avi";
            fileDialog.Title = "Choose Input Video File(s)...";
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                foreach (String file in fileDialog.FileNames) //display all files in listbox and the number of files in a label
                {
                    filesLoaded.Add(file);
                    fileCounter++;
                    
                }
                foreach (string fileString in filesLoaded)
                {
                      listBox1.Items.Add(fileString);
                }
               
                lblFilesLoadedNo.Text = "Number of files loaded = " + fileCounter.ToString();
            }

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) //click on a specific item
        {
            if (listBox1.SelectedItem != null)
            {
                string currentFile = listBox1.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = currentFile;
              //  PlayerForm playerForm = new PlayerForm(currentFile);
              //  playerForm.ShowDialog(this);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e) //select an item and press play
        {
            if (listBox1.SelectedItem != null)
            {
                string currentFile = listBox1.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = currentFile;
              //  PlayerForm playerForm = new PlayerForm(currentFile);
              //  playerForm.ShowDialog(this);
            }
        }

  
    }
}
