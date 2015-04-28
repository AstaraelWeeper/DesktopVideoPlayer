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
        string FPSstring;
        List<string> subRouteTitles = new List<string>(); //to display
        List<string> frameInfo = new List<string>(); //to display
        public List<int> FPS = new List<int>(); //to use to adjust settings
      

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
            if (FPSstring == null)
            { FPSvalue = 1; }
            else
            { FPSvalue = Int32.Parse(element.Attribute("FPS").Value); }
            FPS.Add(FPSvalue);
        }


        public List<string> GetFrameInfo(string XMlfilepath) 
        {
            XDocument doc = XDocument.Load(XMlfilepath); //to complete

            var FramesElement = doc.Descendants("Frames").First().Descendants("Frame");

            foreach (var element in FramesElement)
            {
                var distAttribute = element.Attribute("elrdst").Value.ToString();
                frameInfo.Add(distAttribute);
            }

            return frameInfo;
        }
    }
}
