using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public partial class retainingWallForm : Form
    {
        public retainingWallForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (validateInput.IsDecimal(wallHeightTextBox) && validateInput.IsDecimal(wallLengthTextBox) && validateInput.IsDecimal(blockHeightTextBox) && validateInput.IsDecimal(blockLengthTextBox))
            {
                decimal wallHeight = convertInput.stringToDecimal(wallHeightTextBox);
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
            string programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string folderForXmlData = programFilesPath + "\\contractorCalculator";
            System.IO.Directory.CreateDirectory(folderForXmlData);

        }
    }
}
