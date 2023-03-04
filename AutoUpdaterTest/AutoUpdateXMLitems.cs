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

        public static string root { get; set; } = "item";
        public static string version { get; set; }
        public static int url { get; set; }
        public static string checksum { get; set; }
        public static string mandatory { get; set; } = "false";
        public static string mandatory_minVersion { get; set; } = "false";
        public static string xmlFileName { get; set; }


        //Not used yet Todo allow the xml file to be uploaded
        public static string serverType { get; set; }
        public static string serverPath { get; set; }
    }
}


//<mandatory mode="2">true</mandatory>
//<mandatory minVersion="1.2.0.0">true</mandatory>
//<checksum algorithm="MD5">Update file Checksum</checksum>