using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public static class customizeAllControls
    {
        public static void changeControl(Control myControl)
        {
            if (myControl is Button)
            {
                myControl.ForeColor = Color.Black;
                myControl.BackColor = Color.AliceBlue;
                myControl.Font = new Font("Arial", 13, FontStyle.Regular);
            }
            else
            {
                myControl.ForeColor = Color.Black;
                myControl.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }
    }
}
