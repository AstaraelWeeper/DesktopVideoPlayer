using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Explorer_Desktop
{
    class ImageDisplay 
    {
        public List<string> displayPictures = new List<string>();
        
        string[] allSubroutePictures;
         
        


        public List<string> LoadAllPicturePaths(string[]subrouteJpegFilePaths, int picBox, int channels)
        {
            allSubroutePictures = subrouteJpegFilePaths;
            displayPictures.Clear();
            for (int i=picBox; i<allSubroutePictures.Length; i+=channels)
            {
                displayPictures.Add(allSubroutePictures[i]);
            }
            return displayPictures;
        }
        
        
     

    }
}
