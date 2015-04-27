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
        string frameStringBuilder; //for adding to the list of frame info
        List<string> subRouteTitles = new List<string>(); //to display
        List<string> frameInfo = new List<string>(); //to display
      

        public List<string> GetSubRouteTitles(List<string> XMlfilepaths)
        {  
            foreach (string path in XMlfilepaths) //still needs work!
            {
              
                XDocument xmldoc = XDocument.Load(path);
               var pmdMetaElement = xmldoc.Descendants("pmdmeta");
               XAttribute elrfrom = pmdMetaElement.Attribute("elrfrom");
           
                foreach (var attribute in titleAttributes)//
                {
                    xmlBuilder += attribute;
                }
                subRouteTitles.Add(xmlBuilder);
                

            }

            return subRouteTitles;
            
        }


        public List<string> GetFrameInfo(string XMlfilepath) //think where to call this
        {
            XDocument doc = XDocument.Load(XMLfilepath); //to complete


            foreach (var attribute in frameAttributes)//
            {
                frameStringBuilder += attribute;
            }
            frameInfo.Add(frameStringBuilder);

            return frameInfo;
        }
    }
}
