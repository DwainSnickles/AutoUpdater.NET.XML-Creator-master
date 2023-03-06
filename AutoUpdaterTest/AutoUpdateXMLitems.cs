using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.iditect.com/guide/csharp/xml-serialize.html

namespace AutoUpdaterTest
{
    public class AutoUpdateXMLitems
    {
        public MandatoryTypes MandatoryType;

        public enum MandatoryTypes
         {
            Not_Mandatory,
            Mandatory,
            MandatoryOption1,
            MandatoryOption2,
            MandatoryMinVersion
         }

        public enum HashingAlgoTypes
        {
            None,
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }

        //string variables
        public string root { get; set; } = "item";
        public string version { get; set; }
        public string downLoadurl { get; set; }
        public string changelogurl { get; set; } = string.Empty;
        public string checksum { get; set; }
        public string CommandLineArgs { get; set; } = string.Empty;
        public string minVersion { get; set; }
        public string xmlFileName { get; set; }
        public string xmlFolderPath { get; set; }
        public string UpdateFilePath { get; set; }

        //Boolean varaibles
        public Boolean mandatory { get; set; } = false;
        public Boolean mandatoryOption1 { get; set; }
        public Boolean mandatoryOption2 { get; set; }
        public Boolean mandatory_minVersion { get; set; }

        //Algoritm
        public HashingAlgoTypes AlgoritmType { get; set; }
       

        //Not used yet Todo allow the xml file to be uploaded
        public string serverType { get; set; }
        public string serverPath { get; set; }

    }
}


//<mandatory mode="2">true</mandatory>
//<mandatory minVersion="1.2.0.0">true</mandatory>
//<checksum algorithm="MD5">Update file Checksum</checksum>