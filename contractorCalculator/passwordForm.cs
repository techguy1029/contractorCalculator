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
    public partial class passwordForm : Form
    {
        public authenticatePassword _authPass { get; private set; }

        private static passwordForm openForm = null;
        //Form searchForm = null;
        public passwordForm()
        {
            InitializeComponent();
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            _authPass = new authenticatePassword();
            if (projectSelectionForm._settingsClass.setLanguage() == "Spanish")
            {
                changeLang.setToSpanish(this);
            }
        }

        public static passwordForm GetInstance()
        {
            if(openForm == null)
            {
                openForm = new passwordForm();
                openForm.FormClosed += delegate { openForm = null; };
            }
            return openForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*bool login = passwordOperations.correctPasswordInput(textBoxPasswordInput.Text);
            bool login = passwordOperations.correctPasswordInput(textBoxPasswordInput.Text);
            if(login)
            {
                _authPass.correctPasswordInput = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
            */
            string password = passwordOperations.readInPassword();
            if(textBoxPasswordInput.Text == password)
            {
                _authPass.correctPasswordInput = true;
                MessageBox.Show("Correct Password");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
