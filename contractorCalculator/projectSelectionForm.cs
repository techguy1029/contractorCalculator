using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public partial class projectSelectionForm : Form
    {
        //sizing
        //private Rectangle selectProjectLabelOriginalRectangle;
        private Size formOriginalSize;

        Form retainingWallForm = null;
        Form formSeed = null;
        Form formInformation = null;
        Form searchForm = null;
        //https://stackoverflow.com/questions/42331210/c-sharp-creating-a-global-object-of-a-class-for-use-on-multiple-forms
        Form settingsForm = null;
        public settingsClass _settingsClass { get; private set; }
        public Form passwordForm { get; set; }

        public projectSelectionForm()
        {
            InitializeComponent();
            /*
            foreach (Control c in this.Controls)
            {
                customizeAllControls.changeControl(c);
            }
            */
            _settingsClass = new settingsClass();
            if(_settingsClass.settingsPasswordEnabled() == "True")
            {
                _settingsClass.passwordEnabled = true;
            }
            if (_settingsClass.setLanguage() == "Spanish")
            {
                changeLang.setToSpanish(this);
            }

            /*
            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1280;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 800f;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
            */


        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //only one instance of retaining wall
            if (retainingWallRadioButton.Checked /*&& retainingWallForm == null*/)
            {
                retainingWallForm = new retainingWallForm();
                retainingWallForm.Show();
            }
            else if(radioButtonSeedCalculator.Checked)
            {
                formSeed = new formSeed();
                formSeed.Show();
            }
        }

        private void projectSelectionForm_Load(object sender, EventArgs e)
        {
            /*
            formOriginalSize = this.Size;
            selectProjectLabelOriginalRectangle = new Rectangle(selectProjectLabel.Location.X, selectProjectLabel.Location.Y, selectProjectLabel.Width, selectProjectLabel.Height);
            */
        }

        private void resizeChildrenControl()
        {
            /*
            resizeControl(selectProjectLabelOriginalRectangle, selectProjectLabel);
            */
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width)/(float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height)/(float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void searchProjectsButton_Click(object sender, EventArgs e)
        {
            
            if (_settingsClass.passwordEnabled == true)
            {
                passwordForm passwordForm = new passwordForm();
                passwordForm.ShowDialog();
                //https://stackoverflow.com/questions/4359924/how-can-i-make-execution-pause-until-new-form-is-closed
                if (passwordForm._authPass.correctPasswordInput)
                {
                    searchForm = new searchForm();
                    searchForm.Show();
                }
            }
            else
            {
                searchForm = new searchForm();
                searchForm.Show();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            settingsForm = new settingsForm();
            settingsForm.Show();
        }

        private void retainingWallRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formInformation = new formInformation();
            formInformation.Show();
        }
        /*
Button nextButton = new Button();
nextButton.KeyDown  += new KeyEventHandler(nextButton_KeyDown);
private void nextButton_KeyDown(object sender, KeyEventArgs e)
{
   if(this.retainingWallRadioButton.Checked)
   {
       if(e.KeyCode == Keys.Enter)
       {
           retainingWallForm = new retainingWallForm();
           retainingWallForm.Show();
       }
   }
}
*/
    }
}
