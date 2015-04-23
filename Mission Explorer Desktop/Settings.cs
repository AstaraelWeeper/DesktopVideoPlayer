using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Explorer_Desktop
{
    public class Settings //to pass all settings back as an object
    {
        public double playbackSpeed { get; set; }

        public bool scaleImages { get; set; }

        public Settings() //constructor
        {
            playbackSpeed = 1.0;
            scaleImages = true;
        }   

    }
}
