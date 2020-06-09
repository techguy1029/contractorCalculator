using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public partial class settingsForm : Form
    {
        public Form projectSelectionForm { get; set; }
        //Form passwordForm = null;
        

        public settingsForm()
        {
            InitializeComponent();
            //passwordOperations.setUpPasswordStorage();
            //passwordOperations.setUpLocalDb();

            if (!File.Exists("C:\\ProgramData\\contractorCalc\\Settings\\settingsData-2.mdf"))
            {
                //https://stackoverflow.com/questions/15853382/how-to-manually-create-a-mdf-file-for-localdb-to-use/37049471
                //passwordOperations.setUpLocalDb();
                passwordOperations.setUpPasswordDbStructure();
            }
            //passwordOperations.setUpPassword("yes");
            //passwordOperations.readInPassword();
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            bool pwEnabled = projectSelectionForm._settingsClass.passwordEnabled;

            if (projectSelectionForm._settingsClass.setLanguage() == "Spanish")
            {
                changeLang.setToSpanish(this);
                listBoxLanguage.SelectedIndex = 1;
            }
            else
            {
                listBoxLanguage.SelectedIndex = 0;
            }
            if (pwEnabled)
            {
                //https://stackoverflow.com/questions/28942106/c-sharp-windows-forms-textbox-greyed-out
                radioButtonPsEnabled.Checked = true;
                textBoxConfirmPs.BackColor = Color.LightGray;
                textBoxPsInput.BackColor = Color.LightGray;
                labelConfirmPass.BackColor = Color.LightGray;
                labelEnterPass.BackColor = Color.LightGray;
                buttonSetPs.BackColor = Color.LightGray;
                textBoxConfirmPs.Enabled = false;
                textBoxPsInput.Enabled = false;
                buttonSetPs.Enabled = false;
                buttonResetPs.Visible = true;
            }
            if(!pwEnabled)
            {
                radioButtonPsDisabled.Checked = true;
                labelEnterPass.Visible = false;
                labelConfirmPass.Visible = false;
                textBoxPsInput.Visible = false;
                textBoxConfirmPs.Visible = false;
                buttonSetPs.Visible = false;
                buttonResetPs.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            if (validateInput.fieldsMatch(textBoxConfirmPs, textBoxPsInput))
            {
                //string hashString = passwordOperations.setPassword(textBoxConfirmPs.Text, textBoxPsInput.Text);
                string pass = textBoxPsInput.Text;
                //string hashedPass = passwordOperations.setPassword(textBoxConfirmPs.Text, textBoxPsInput.Text,pass);
                passwordOperations.setUpPassword(pass);
                projectSelectionForm._settingsClass.enablePasswordSetting();
                MessageBox.Show("Password set");
                //Application.Restart();
            }
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPsDisabled_CheckedChanged(object sender, EventArgs e)
        {
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            bool pwEnabled = projectSelectionForm._settingsClass.passwordEnabled;
            if(pwEnabled == true)
            {
                passwordForm passwordForm = new passwordForm();
                passwordForm.ShowDialog();
                if(passwordForm._authPass.correctPasswordInput)
                {
                    radioButtonPsDisabled.Checked = true;
                    projectSelectionForm._settingsClass.disablePasswordSetting();
                    projectSelectionForm._settingsClass.passwordEnabled = false;
                }
            }
            if(pwEnabled == false)
            {
                radioButtonPsDisabled.Checked = true;
            }
        }

        private void radioButtonPsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            bool pwEnabled = projectSelectionForm._settingsClass.passwordEnabled;
            if(pwEnabled)
            {
                radioButtonPsEnabled.Checked = true;
            }
            if(!pwEnabled)
            {
                //https://stackoverflow.com/questions/10569200/how-to-reset-to-default-button-backcolor/25419219
                textBoxConfirmPs.BackColor = default(Color);
                textBoxPsInput.BackColor = default(Color);
                labelConfirmPass.BackColor = default(Color);
                labelEnterPass.BackColor = default(Color);
                buttonSetPs.BackColor = default(Color);
                textBoxConfirmPs.Enabled = true;
                textBoxPsInput.Enabled = true;
                buttonSetPs.Enabled = true;
                labelEnterPass.Visible = true;
                labelConfirmPass.Visible = true;
                textBoxPsInput.Visible = true;
                textBoxConfirmPs.Visible = true;
                buttonSetPs.Visible = true;

            }
        }

        private void labelEnterPass_Click(object sender, EventArgs e)
        {

        }

        private void listBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            projectSelectionForm projectSelectionForm = new projectSelectionForm();
            if (listBoxLanguage.SelectedIndex == 0)
            {
                projectSelectionForm._settingsClass.languageToEnglish();
            }
            if (listBoxLanguage.SelectedIndex == 1)
            {
                projectSelectionForm._settingsClass.languageToSpanish();
            }
            MessageBox.Show("Restart application to see changes");
            this.Close(); 
        }
    }
}
