using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace contractorCalculator
{
    public partial class retainingWallForm : Form
    {
        private projectInformation _projectInformation;
        public bool firstPageDone = false;
        public bool secondPageDone = false;
        public retainingWallForm()
        {
            InitializeComponent();
            _projectInformation = new projectInformation();
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            ((Control)this.tabPage3).Enabled = false;
            //((Control)this.tabPage3);
            ((Control)this.tabPage2).Enabled = false;
            if (projectSelectionForm._settingsClass.setLanguage() == "Spanish")
            {
                changeLang.setToSpanish(this);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (validateInput.IsDecimal(wallHeightTextBox) &&
                validateInput.IsDecimal(wallLengthTextBox) &&
                validateInput.IsDecimal(blockHeightTextBox) &&
                validateInput.IsDecimal(blockLengthTextBox))
            {
                _projectInformation.wallHeight = convertInput.stringToDecimal(wallHeightTextBox);
                _projectInformation.wallLength = convertInput.stringToDecimal(wallLengthTextBox);
                _projectInformation.blockHeight = convertInput.stringToDecimal(blockHeightTextBox);
                _projectInformation.blockLength = convertInput.stringToDecimal(blockLengthTextBox);
                decimal numOfBlocks;
                decimal numOfCaps;
                if (!includeCapsCheckBox.Checked)
                {
                    numOfBlocks = _projectInformation.blocksNeeded;
                    _projectInformation.includeCaps = false;
                }
                else
                {
                    numOfBlocks = _projectInformation.blockNeededWithCaps;
                    numOfCaps = _projectInformation.capsNeeded;
                    _projectInformation.includeCaps = true;
                    labelDisplayNumberOfCaps.Text = numOfCaps.ToString();
                }
                displayBlocksLabel.Text = numOfBlocks.ToString();
                ((Control)this.tabPage2).Enabled = true;
                ((Control)this.tabPage3).Enabled = true;
            }
        }

        private void includeCapsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveToDbButton_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/21330080/creating-and-using-c-sharp-application-folder
            if (validateInput.IsPresent(projectNameTextBox))
            {
                _projectInformation.projectName = projectNameTextBox.Text;
                if(_projectInformation.includeCaps)
                {
                    writeXmlData.writeRetainingWallDataToXML(_projectInformation.wallHeight, _projectInformation.wallLength, 
                        _projectInformation.blockHeight, _projectInformation.blockLength, _projectInformation.projectName, 
                        _projectInformation.blocksNeeded, _projectInformation.costOfBlock, _projectInformation.totalCost, 
                        _projectInformation.costOfAllBlocks, _projectInformation.numberOfRows, _projectInformation.numberOfColumns,
                        _projectInformation.costOfCap, _projectInformation.costOfAllCaps, _projectInformation.capsNeeded);
                }
                else
                {
                    writeXmlData.writeRetainingWallDataToXML(_projectInformation.wallHeight, _projectInformation.wallLength, 
                        _projectInformation.blockHeight, _projectInformation.blockLength, _projectInformation.projectName, 
                        _projectInformation.blocksNeeded, _projectInformation.costOfBlock, _projectInformation.totalCost, 
                        _projectInformation.costOfAllBlocks, _projectInformation.numberOfRows, _projectInformation.numberOfColumns);
                }
                MessageBox.Show("Data Saved");
            }
        }

        private void wallHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _projectInformation.projectName = projectNameTextBox.Text;
            string projectName = _projectInformation.projectName;
            if (validateInput.IsPresent(projectNameTextBox))
            {
                //https://stackoverflow.com/questions/7330111/select-folder-path-with-savefiledialog
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFile.FileName = projectName;
                DialogResult fileSelected = saveFile.ShowDialog();
                string savePath = Path.GetDirectoryName(saveFile.FileName);

                if (fileSelected == DialogResult.OK)
                {
                    string textFile = textFileOperations.createTextFile(savePath, projectName);
                    string textToBeSaved = "Project Information: " + _projectInformation.projectName + "\n" +
                                                "Wall Height: " + _projectInformation.wallHeight + "\n" +
                                                "Wall Length: " + _projectInformation.wallLength + "\n" +
                                                "Number of Rows: " + _projectInformation.numberOfRows + "\n" +
                                                "Number of Columns: " + _projectInformation.numberOfColumns + "\n" +
                                                "Block Length: " + _projectInformation.blockLength + "\n" +
                                                "Block Height: " + _projectInformation.blockHeight + "\n" +
                                                "Blocks Needed: " + displayBlocksLabel.Text + "\n" +
                                                "Cost per Block: " + convertInput.stringToMoney(_projectInformation.costOfBlock.ToString()) + "\n" +
                                                "Cost of All Blocks: " + convertInput.stringToMoney(_projectInformation.costOfAllBlocks.ToString()) + "\n";
                    string includeCaps = "Caps Needed: " + _projectInformation.capsNeeded + "\n" +
                            "Cost per Cap: " + convertInput.stringToMoney(_projectInformation.costOfCap.ToString()) + "\n" +
                            "Cost of All Caps: " + convertInput.stringToMoney(_projectInformation.costOfAllCaps.ToString());
                    if (_projectInformation.includeCaps)
                    {
                        textToBeSaved += includeCaps;
                    }
                    string totalCost = "\n" + "Total Cost: " + convertInput.stringToMoney(_projectInformation.totalCost.ToString());
                    textToBeSaved += totalCost;
                    textFileOperations.writeToRetainingWallText(textToBeSaved, textFile);
                }
                ((Control)this.tabPage3).Enabled = true;
            }

        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayBlocksLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _projectInformation.costOfBlock = convertInput.stringToDecimal(textBoxCostOfBlock);
            _projectInformation.costOfCap = convertInput.stringToDecimal(textBoxCostOfCap);

            if (_projectInformation.includeCaps)
            {
                labelCostOfCaps.Text = convertInput.stringToMoney(_projectInformation.costOfAllCaps.ToString());
                labelCostOfBlocks.Text = convertInput.stringToMoney(_projectInformation.costOfAllBlocks.ToString());
                labelTotalCost.Text = convertInput.stringToMoney(_projectInformation.totalCost.ToString());
            }
            else
            {
                labelCostOfBlocks.Text = convertInput.stringToMoney(_projectInformation.costOfAllBlocks.ToString());
                labelTotalCost.Text = convertInput.stringToMoney(_projectInformation.totalCost.ToString());
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void retainingWallForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/3546016/how-to-copy-data-to-clipboard-in-c-sharp
            string textToBeSaved = "Project Information: " + _projectInformation.projectName + "\n" +
                                                "Wall Height: " + _projectInformation.wallHeight + "\n" +
                                                "Wall Length: " + _projectInformation.wallLength + "\n" +
                                                "Number of Rows: " + _projectInformation.numberOfRows + "\n" +
                                                "Number of Columns: " + _projectInformation.numberOfColumns + "\n" +
                                                "Block Length: " + _projectInformation.blockLength + "\n" +
                                                "Block Height: " + _projectInformation.blockHeight + "\n" +
                                                "Blocks Needed: " + displayBlocksLabel.Text + "\n" +
                                                "Cost per Block: " + convertInput.stringToMoney(_projectInformation.costOfBlock.ToString()) + "\n" +
                                                "Cost of All Blocks: " + convertInput.stringToMoney(_projectInformation.costOfAllBlocks.ToString()) + "\n";
           string includeCaps = "Caps Needed: " + _projectInformation.capsNeeded + "\n" +
                "Cost per Cap: " + convertInput.stringToMoney(_projectInformation.costOfCap.ToString()) + "\n" +
                "Cost of All Caps: " + convertInput.stringToMoney(_projectInformation.costOfAllCaps.ToString());
            if (_projectInformation.includeCaps)
            {
                Clipboard.SetText(textToBeSaved + "\n" + includeCaps);
            }
            else
            {
                Clipboard.SetText(textToBeSaved);
            }
        }
    }
}
