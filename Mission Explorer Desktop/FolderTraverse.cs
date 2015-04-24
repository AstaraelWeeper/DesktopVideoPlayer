using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ionic.Zip;
using System.Reflection;


namespace Mission_Explorer_Desktop
{
    class FolderTraverse
    {
        string startFolder = "C:\\Users\\Rachel Griffiths\\Documents\\Testing\\MissionRoomTestDataZip";
        string[] outerFolder; 
        string[] JSONRouteInfoPath; //should only need [0]
        string[] jpegFolders;
       // string[] routeJpegs; //not used yet
        List<string> xmlFilePaths;
        
        

        



        public void getInitialData() //should populate outerfolders file paths (subroute folders), the JSON file path, and each XML file path
        {
           // int countDirectories = 0;
            outerFolder = Directory.GetDirectories(startFolder);
            JSONRouteInfoPath = Directory.GetFiles(startFolder, "*.json");

           /* foreach (string directory in outerFolder)
            {
                string[] xmlTemp =  Directory.GetFiles(directory, "*.xml");
                string xmlTempString = xmlTemp[0];
                xmlFilePaths.Add (xmlTempString); //xml is the only file so it should go into 0 of xml temp, and can be extracted here into xml FilePath

                string [] innerDirectory = Directory.GetDirectories(directory); //local variable to store the 2 zip files in each subroute folder.
                string pmdPath = innerDirectory[0]; //temp, before extension change
                File.Move(pmdPath, Path.ChangeExtension(pmdPath, ".zip")); //need to see what this ends up as, as there is already a .zip. then need file path for image extraction method

  

                countDirectories++;

            } */
            //xmlFilePaths.ToArray();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
        }

        public void getRouteImages(string directory)
        {
            
        }

        public List<string> parseJson()
        {
            StreamReader JsonStream = new StreamReader(JSONRouteInfoPath[0]);
            string Json = JsonStream.ReadToEnd(); //extract JSON
            var JsonRouteInfo = JsonConvert.DeserializeObject<JSONClass>(Json); //deserialise into class

            List<string> list = new List<string>(); //get the properties of the class
            PropertyInfo[] JsonProperties  = JsonRouteInfo.GetType().GetProperties();

            foreach (var prop in JsonProperties)
            {
                string name = prop.Name as string;
                string value = prop.GetValue(JsonRouteInfo,null) as string;
                
                list.Add(name + ":" + value);
            }
            return list;
            
        }

    }
}
