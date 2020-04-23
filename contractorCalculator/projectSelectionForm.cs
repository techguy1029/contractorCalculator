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
    public partial class projectSelectionForm : Form
    {
        Form retainingWallForm = null;

        public projectSelectionForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (retainingWallRadioButton.Checked && retainingWallForm == null)
            {
                retainingWallForm = new retainingWallForm();
                retainingWallForm.Show();
            }
        }

        private void projectSelectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
