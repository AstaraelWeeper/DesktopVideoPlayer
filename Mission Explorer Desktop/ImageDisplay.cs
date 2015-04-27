using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Explorer_Desktop
{
    class ImageDisplay 
    {
        public List<string> leftPictures = new List<string>();
        public List<string> frontPictures = new List<string>();
        public List<string> rightPictures = new List<string>();
        public List<string> backPictures = new List<string>();
        string[] allSubroutePictures;
        


        public void LoadAllPicturePaths(string[]subrouteJpegFilePaths)
        {
            allSubroutePictures = subrouteJpegFilePaths;
            LoadLeftPictures();
            LoadFrontPictures();
            LoadRightPictures();
            LoadBackPictures();
        }
        
        
        void LoadLeftPictures()
        {
            for (int i=0; i<allSubroutePictures.Length; i+=4)
            {
                leftPictures.Add(allSubroutePictures[i]);
            }
        }

        void LoadFrontPictures()
        {
            for (int i = 1; i < allSubroutePictures.Length; i += 4)
            {
                frontPictures.Add(allSubroutePictures[i]);
            }
        }

        void LoadRightPictures()
        {
            for (int i = 2; i < allSubroutePictures.Length; i += 4)
            {
                rightPictures.Add(allSubroutePictures[i]);
            }
        }

        void LoadBackPictures()
        {
            for (int i = 3; i < allSubroutePictures.Length; i += 4)
            {
                backPictures.Add(allSubroutePictures[i]);
            }
        }

    }
}
