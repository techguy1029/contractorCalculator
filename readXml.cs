using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contractorCalculator
{
    class readXml
    {
        public static string returnXmlPath()
        {
            string commonDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string programDir = Path.Combine(commonDir, @"contractorCalc\\Data");
            string xmlFilePath = programDir + "\\data.xml";
            return xmlFilePath;
        }
        public static void readInXmlToGridView()
        {
            DataSet xmlData = new DataSet();
            string filePath = returnXmlPath();
            xmlData.ReadXml(filePath);
        }
    }
}
