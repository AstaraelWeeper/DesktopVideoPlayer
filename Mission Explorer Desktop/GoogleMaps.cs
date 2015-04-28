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
    public partial class GoogleMaps : Form
    {
        string URLroot = "https://maps.googleapis.com/maps/api/staticmap?";
        string URL;
        string size = "size=";
        string sizeValueHeight = "450";
        string sizeValueWidth = "800";
        string center = "center=";
        string zoom = "&zoom=";
        string zoomValue = "17";
        string coordinates;
        string marker = "&markers=color:";
        string markerColour = "red";
    


        public GoogleMaps(string XMLcoordinates)
        {
            InitializeComponent();
            coordinates = XMLcoordinates;
            BuildURL();
            webBrowser1.Navigate(URL);
        }

        void BuildURL()
        {
            int zoomInt = (int)numZoom.Value;
            zoomValue = zoomInt.ToString();
            GetMarkerColour();
            URL = URLroot + center+ coordinates + zoom + zoomValue + "&" + size + sizeValueWidth + "x" + sizeValueHeight + marker + markerColour + "|" + coordinates;

        }

        void GetMarkerColour()
        {
            if (rdoBlue.Checked == true)
            {
                markerColour = "blue";
            }
            else if(rdoRed.Checked == true)
            {
                markerColour = "red";
            }
            else if (rdoPurple.Checked ==true)
            {
                markerColour = "purple";
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BuildURL();
            webBrowser1.Navigate(URL);
        }
    }
}
