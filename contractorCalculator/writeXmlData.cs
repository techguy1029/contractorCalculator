using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string xmlFilePath = programDir + "\\data-1.xml";
            return xmlFilePath;
        }
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        public static void writeRetainingWallDataToXML(decimal wallHeight, 
            decimal wallLength, decimal blockHeight, decimal blockLength, 
            string projectName, decimal blocksNeeded, decimal blockCost,
            decimal totalCost, decimal allBlockCost, decimal rowNum, decimal colNum,
            decimal capCost = 0, decimal allCapCost = 0, decimal totalCaps = 0)
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

            XElement root = xDocument.Element("Projects");


            //https://stackoverflow.com/questions/6219454/efficient-way-to-remove-all-whitespace-from-string


            string xmlProjectNameElement = Regex.Replace(projectName, @"\s+", "");
            xmlProjectNameElement = "_" + xmlProjectNameElement;

            XElement xmlForProject = new XElement(xmlProjectNameElement,
                new XElement("ProjectName", projectName),
                new XElement("ProjectType", "RetainingWall"),
                new XElement("WallHeight", wallHeight),
                new XElement("WallLength", wallLength),
                new XElement("BlockHeight", blockHeight),
                new XElement("BlockLength", blockLength),
                new XElement("BlocksNeeded", blocksNeeded),
                new XElement("BlockCost", blockCost),
                new XElement("TotalCost", totalCost),
                new XElement("AllBlockCost", allBlockCost),
                new XElement("RowNum", rowNum),
                new XElement("ColNum", colNum),
                new XElement("CapCost", capCost),
                new XElement("AllCapCost", allCapCost),
                new XElement("TotalCaps", totalCaps)


            );
            root.Add
                (
                    xmlForProject
                );
            xDocument.Save(pathToXml);
            
        }
    }
}
