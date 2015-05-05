using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Mission_Explorer_Desktop
{
    class XMLparse
    {
        string xmlBuilder;//for adding to the list of titles
        string coordsBuilder;
        List<string> subRouteTitles = new List<string>(); //to display
        List<string> frameInfo = new List<string>(); //to display
        public List<int> FPS = new List<int>(); //to use to adjust settings
        public List<string> GoogleMapsCoords = new List<string>();
        

        
        public List<string> GetSubRouteTitles(List<string> XMlfilepaths)
        {  
            foreach (string path in XMlfilepaths) //for each XML file
            {
              
                XDocument xmldoc = XDocument.Load(path);
               var pmdMetaElement = xmldoc.Descendants("pmdmeta");

               foreach (var element in pmdMetaElement)
               {
                   var elrfrom = element.Attribute("elrfrom").ToString();
                   var elrto = element.Attribute("elrto").ToString();
                   xmlBuilder = elrfrom + elrto;
                   subRouteTitles.Add(xmlBuilder);

                   GetFPS(element);
               }
            }

            return subRouteTitles;
            
        }

        public void GetFPS(XElement element)
        {
            string FPSstring = (string)element.Attribute("FPS");
            int FPSvalue;
            if (string.IsNullOrEmpty(FPSstring))
            { FPSvalue = Int32.Parse(element.Attribute("FPS").Value); }
            else
            { FPSvalue = 5; }
            FPS.Add(FPSvalue);
        }


        public List<string> GetFrameInfo(string XMlfilepath) 
        {
            
            XDocument doc = XDocument.Load(XMlfilepath);

            frameInfo.Clear(); //clears previous subroute data

            var FramesElement = doc.Descendants("frames").First();
            var frames = doc.Descendants("frame");

            foreach (var element in frames) //for each frame
            {
                var distAttribute = element.Attribute("elrdst").Value.ToString();
                frameInfo.Add(distAttribute);
                var mapAttribute = element.Attribute("pos").Value.ToString(); //get the positions as one string
                var mapLatLong = mapAttribute.Split(','); //split into 2 or 3 strings in an array

                for (int i = 0; i < 2; i++)
                {
                     //only need the first 2 out of possible 3 coordinates, with a comma between them, adding back into one string
                    if (i == 1)
                    {
                        coordsBuilder += "," + mapLatLong[i];
                    }
                    else
                    { coordsBuilder += mapLatLong[i]; }
                }

                GoogleMapsCoords.Add(coordsBuilder); //add each string into a list
                coordsBuilder = "";
                
            }

            return frameInfo;
        }
    } 
}
