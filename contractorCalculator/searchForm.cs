using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace contractorCalculator
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = searchXml.returnAllProjects();

            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            if (projectSelectionForm._settingsClass.setLanguage() == "Spanish")
            {
                changeLang.setToSpanish(this);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = textBoxSearchBox.Text;
            //dataGridView1.DataSource = searchXml.returnSearchItem(searchString);
            dataGridView1.DataSource = searchXml.returnSimilarSearchItem(searchString);
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = searchXml.returnAllProjects();
        }

        private void searchForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
