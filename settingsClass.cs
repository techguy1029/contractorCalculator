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
    public class settingsClass
    {

        public bool passwordEnabled { get; set; }
        
        public void createSettingsXml()
        {
            string settingsXmlFolder = "C:\\ProgramData\\contractorCalc\\Settings";
            System.IO.Directory.CreateDirectory(settingsXmlFolder);
            string settingsFile = "settings.xml";
            string xmlSettingsPath = System.IO.Path.Combine(settingsXmlFolder, settingsFile);
            System.IO.File.Create(xmlSettingsPath).Dispose();
            
        }

        public string returnXmlPath()
        {
            string settingsXmlFolder = "C:\\ProgramData\\contractorCalc\\Settings\\settings.xml";
            if (File.Exists(settingsXmlFolder))
            {
                return settingsXmlFolder;
            }
            else
            {
                return "null";
            }
            
        }

        public void setUpXmlSettings()
        {
            string pathToSettings = returnXmlPath();
            if(File.Exists(pathToSettings))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;

                using(XmlWriter xmlWriter = XmlWriter.Create(pathToSettings, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Settings");
                        xmlWriter.WriteStartElement("PasswordEnabled");
                        xmlWriter.WriteString("False");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteStartElement("Language");
                        xmlWriter.WriteString("English");
                        xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }

            }
        }

        public string settingsPasswordEnabled()
        {
            string pathToSettings = returnXmlPath();
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToSettings);
            XmlNode node = doc.DocumentElement.SelectSingleNode("PasswordEnabled");
            string text = node.InnerText;
            return text;
        }

        public string setLanguage()
        {
            string pathToSettings = returnXmlPath();
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToSettings);
            XmlNode node = doc.DocumentElement.SelectSingleNode("Language");
            string text = node.InnerText;
            return text;

        }

        public void languageToSpanish()
        {
            string pathToSettings = returnXmlPath();
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToSettings);
            XmlNode node = doc.DocumentElement.SelectSingleNode("Language");
            node.InnerText = "Spanish";
            doc.Save(pathToSettings);
        }

        public void languageToEnglish()
        {
            string pathToSettings = returnXmlPath();
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToSettings);
            XmlNode node = doc.DocumentElement.SelectSingleNode("Language");
            node.InnerText = "English";
            doc.Save(pathToSettings);
        }

        public void disablePasswordSetting()
        {
            //https://stackoverflow.com/questions/9616163/c-sharp-modify-a-xml-node
            string pathToSettings = returnXmlPath();
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToSettings);
            XmlNode node = doc.DocumentElement.SelectSingleNode("PasswordEnabled");
            node.InnerText = "False";
            doc.Save(pathToSettings);
        }

        public void enablePasswordSetting()
        {
            string pathToSettings = returnXmlPath();
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToSettings);
            XmlNode node = doc.DocumentElement.SelectSingleNode("PasswordEnabled");
            node.InnerText = "True";
            doc.Save(pathToSettings);
        }
    }
}
