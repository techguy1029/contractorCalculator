using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace contractorCalculator
{
    public static class writeXmlData
    {
        private static string title = "Entry Error";


        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static string returnXmlPath()
        {
            string commonDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string programDir = Path.Combine(commonDir, @"contractorCalc\\Data");
            string xmlFilePath = programDir + "\\data.xml";
            return xmlFilePath;
        }
        public static void writeRetainingWallDataToXML(decimal wallHeight, decimal wallLength, decimal blockHeight, decimal blockLength, string projectName, decimal blocksNeeded)
        {
            string pathToXml = returnXmlPath();
            if(!File.Exists(pathToXml))
            {
                //https://stackoverflow.com/questions/21330080/creating-and-using-c-sharp-application-folder
                File.Create(pathToXml).Dispose();

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(pathToXml, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("SavedData");

                        xmlWriter.WriteStartElement("Project");
                        xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }

            XDocument xDocument = XDocument.Load(pathToXml);
            //gets first child element of specified element
            XElement root = xDocument.Element("SavedData");

            IEnumerable<XElement> rows = root.Descendants("Projects");

            XElement xmlForProject = new XElement(projectName,
                new XElement("ProjectName", projectName),
                new XElement("ProjectType", "RetainingWall", 1),
                new XElement("WallHeight", wallHeight, 2),
                new XElement("WallLength", wallLength, 3),
                new XElement("BlockHeight", blockHeight, 4),
                new XElement("BlockLength", blockLength, 5),
                new XElement("BlocksNeeded", blocksNeeded, 6)
            );
            XElement firstRow = rows.First();
            firstRow.Add
                (
                    xmlForProject
                );
            xDocument.Save(pathToXml);
            
        }
    }
}
