using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace contractorCalculator
{
    public partial class retainingWallForm : Form
    {
        public retainingWallForm()
        {
            InitializeComponent();
        }
        public string wallLengthTextBoxText
        {
            get { return wallHeightTextBox.Text; }
            set { wallHeightTextBox.Text = value; }
        }

        /*
         * https://www.codeproject.com/Questions/96744/how-to-access-the-textBox-value-of-one-form-from-a
        public decimal wallLength
        {
            get { return wallLength; }
            set { wallLength = valwallLengthTextBoxText}
        }
        */

        private void tabPage1_Click(object sender, EventArgs e)
        {
            getValues.wallHeightValue();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (validateInput.IsDecimal(wallHeightTextBox) && validateInput.IsDecimal(wallLengthTextBox) && validateInput.IsDecimal(blockHeightTextBox) && validateInput.IsDecimal(blockLengthTextBox))
            {
                //decimal wallHeight = convertInput.stringToDecimal(wallHeightTextBox);
                decimal wallLength = convertInput.stringToDecimal(wallLengthTextBox);
                decimal blockHeight = convertInput.stringToDecimal(blockHeightTextBox);
                decimal blockLength = convertInput.stringToDecimal(blockLengthTextBox);
                decimal numOfRows = wallHeight / (blockHeight / 12);
                decimal numOfCol = wallLength / (blockLength / 12);
                decimal numOfBlocks;
                if (!includeCapsCheckBox.Checked)
                { 
                    numOfBlocks = numOfCol * numOfRows;
                }
                else
                {
                    numOfBlocks = numOfCol * (numOfRows - 1);
                }
                displayBlocksLabel.Text = numOfBlocks.ToString();
            }
        }

        private void buttonSaveOptions_Click(object sender, EventArgs e)
        {
            if(!tabControl1.TabPages.Contains(tabPage2))
            {
                tabControl1.TabPages.Add(tabPage2);
            }
            tabControl1.SelectedIndex = 1;
            tabPage2.Focus();
            
            /*
            if (displayBlocksLabel.Text == null)
            {
                tabControl1.DeselectTab(0);
            }
            /*
            if (tabControl1.Deselected. == 1)
            {
                tabControl1.TabPages.Add(tabPage2);
            }
            tabControl1.SelectedIndex = 1;
            tabPage2.Focus();
            */
        }


        private void includeCapsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveToDbButton_Click(object sender, EventArgs e)
        {
            /*
            //https://stackoverflow.com/questions/21330080/creating-and-using-c-sharp-application-folder
            string commonDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string programDir = Path.Combine(commonDir, @"contractorCalc\\Data");
            System.IO.Directory.CreateDirectory(programDir);
            string xmlFilePath = programDir + "\\data.xml";
            File.Create(xmlFilePath).Dispose();

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.NewLineOnAttributes = true;

            using (XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath, xmlWriterSettings))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("savedData");

                    xmlWriter.WriteStartElement("retainingWall");
                    xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();
            }
            */
            //decimal wallHeight = 2.3m;
            decimal wallLength = 2.3m;
            decimal blockLength = 2.3m;
            decimal blockHeight = 2.3m;
            string projectName = "testProject";
            decimal blockNeeded = 247m;

            writeXmlData.writeRetainingWallDataToXML(wallHeight, wallLength, blockHeight, blockLength, projectName, blockNeeded);

        }
    }
}
