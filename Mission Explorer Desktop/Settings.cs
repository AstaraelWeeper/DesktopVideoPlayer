using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Explorer_Desktop
{
    public class Settings //to pass all settings back as an object
    {
        public int playbackSpeed { get; set; }

        public bool scaleImages { get; set; }

        public string units { get; set; }

        public Settings() //constructor
        {
            playbackSpeed = 10;
            scaleImages = true;
            units = "meters";
        }   

    }
}
