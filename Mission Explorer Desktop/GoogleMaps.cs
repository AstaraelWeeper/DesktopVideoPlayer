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
        string size = "size=850x850&";
        string center = "center=";
        string zoom = "&zoom=17&";
        string coordinates;
        string marker = "markers=color:red|";
    


        public GoogleMaps(string XMLcoordinates)
        {
            InitializeComponent();
            coordinates = XMLcoordinates;
            BuildURL();
            webBrowser1.Navigate(URL);
        }

        void BuildURL()
        {
            URL = URLroot + center+ coordinates+ zoom + size + marker + coordinates;

        }
    }
}
