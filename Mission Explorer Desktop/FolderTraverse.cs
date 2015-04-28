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
        public string startFolder = "C:\\Users\\Rachel Griffiths\\Documents\\Testing\\Demodata.zip";
        string startFolderExtracted;
        string[] outerFolder; 
        string[] JSONRouteInfoPath; //should only need [0]
       public List<string[]> jpgPaths = new List<string[]>(); //the final list of jpeg paths
        
        public List<string> xmlFilePaths = new List<string>();
         int countDirectories = 0; 
        public List<string> countDirectoriesString = new List<string>();
        
        string extractPath;
        

        



        public void getInitialData() //should populate outerfolders file paths (subroute folders), the JSON file path, and each XML file path
        {
          startFolderExtracted = startFolder + "extracted";
            using (ZipFile zip = ZipFile.Read(startFolder))
            {
                zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                zip.ExtractAll(startFolderExtracted);
            }    //this is for changing file
            outerFolder = Directory.GetDirectories(startFolderExtracted); //needs to be startfolderextracted if the above code is active
            JSONRouteInfoPath = Directory.GetFiles(startFolderExtracted, "*.json"); //needs to be startfolderextracted if the above code is active

    
            foreach (string directory in outerFolder)
            {
                GetXMLFilePaths(directory);
                ExtractJpegZips(directory);
                getRouteImages(directory);
                AddToNumberOfDirectories();

                countDirectories++;
               
            } 
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        }

        public void AddToNumberOfDirectories()
        {
            countDirectoriesString.Add(countDirectories.ToString());
        }
        public void GetXMLFilePaths(string directory)
        {
             //XML file paths//
             string[] xmlTemp =  Directory.GetFiles(directory, "*.xml");
             string xmlTempString = xmlTemp[0];
             xmlFilePaths.Add (xmlTempString); //xml is the only file so it should go into 0 of xml temp, and can be extracted here into xml FilePath
        }

        public void ExtractJpegZips(string directory)
        {
            //through zip1 to JPEGS
            string zipPath = directory +"\\" + Path.GetFileName(directory) + ".pmd";
            extractPath = directory + "\\" + Path.GetFileName(directory) + "extractedjpgs";
            using (ZipFile zip1 = ZipFile.Read(zipPath))
            {
                zip1.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                zip1.ExtractAll(extractPath);
            }
        }

        public void getRouteImages(string directory)
        {
            string[] routeJpegs = Directory.GetFiles(extractPath);
            jpgPaths.Add(routeJpegs);
        }

        public List<string> ParseJson() //get the json for the route title info
        {
            StreamReader JsonStream = new StreamReader(JSONRouteInfoPath[0]);
            string Json = JsonStream.ReadToEnd(); //extract JSON
            var JsonRouteInfo = JsonConvert.DeserializeObject<JSONClass>(Json); //deserialise into class

            List<string> list = new List<string>(); 
            PropertyInfo[] JsonProperties  = JsonRouteInfo.GetType().GetProperties();//get the properties of the class

            foreach (var prop in JsonProperties) 
            {
                string name = prop.Name as string; //get property name
                string value = prop.GetValue(JsonRouteInfo,null) as string; //get property value
                
                list.Add(name + ": " + value); //add both to list
            }
            return list;
            
        }

    }
}
