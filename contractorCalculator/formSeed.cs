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
    public partial class formSeed : Form
    {
        private seedProjectInformation _seedProjectInformation;
        public formSeed()
        {
            InitializeComponent();
            _seedProjectInformation = new seedProjectInformation();
            ((Control)this.tabPage3).Enabled = false;
            ((Control)this.tabPage2).Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBoxTriangleHeight.Visible = false;
            comboBoxShape.SelectedIndex = 0;
        }

        private void formSeed_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxShape.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBoxTriangleHeight.Visible = false;
            }
            else if(comboBoxShape.SelectedIndex == 1)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBoxTriangleHeight.Visible = false;
            }
            else if (comboBoxShape.SelectedIndex == 2)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBoxTriangleHeight.Visible = false;
            }
            else if (comboBoxShape.SelectedIndex == 3)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBoxTriangleHeight.Visible = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedIndex == 0)
            {
                _seedProjectInformation.rectangleLength = convertInput.stringToDecimal(textBoxRectangleLength);
                _seedProjectInformation.rectangleWidth = convertInput.stringToDecimal(textBoxRectangleWidth);
                _seedProjectInformation.rectangleCoverageRate = convertInput.stringToDecimal(textBoxRectangleCoverage);
                _seedProjectInformation.seedNeeded = _seedProjectInformation.rectangleCoverageRate * ((_seedProjectInformation.rectangleLength * _seedProjectInformation.rectangleWidth) / 1000); 

            }
            else if (comboBoxShape.SelectedIndex == 1)
            {
                _seedProjectInformation.circleRadius= convertInput.stringToDecimal(textBoxCircleRadius);
                _seedProjectInformation.circleCoverageRate = convertInput.stringToDecimal(textBoxCircleCoverageRate);
                //_seedProjectInformation.seedNeeded;
            }
            else if (comboBoxShape.SelectedIndex == 2)
            {
                _seedProjectInformation.ellipsisAAxis = convertInput.stringToDecimal(textBoxEllipsisAAxis);
                _seedProjectInformation.ellipsisBAxis = convertInput.stringToDecimal(textBoxEllipsisBAxis);
                _seedProjectInformation.ellipsisCoverageRate = convertInput.stringToDecimal(textBoxEllipsisCoverageRate);
            }
            else if (comboBoxShape.SelectedIndex == 3)
            {
                _seedProjectInformation.triangleBase = convertInput.stringToDecimal(textBoxTriangleHeight);
                _seedProjectInformation.triangleHeight= convertInput.stringToDecimal(textBoxTriangleBase);
                _seedProjectInformation.triangleCoverageRate = convertInput.stringToDecimal(textBoxTriangleCoverageRate);
            }
        }
    }
}
