using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public class changeLang
    {
        public static void setToSpanish(Form form)
        {
            //https://stackoverflow.com/questions/2113069/c-sharp-getting-its-own-class-name
            Type formClass = form.GetType();
            foreach(Control c in form.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(formClass);
                resources.ApplyResources(c, c.Name, new CultureInfo("es-US"));

            }
        }
        public static void setToEnglish(Form form)
        {
            Type formClass = form.GetType();
            foreach(Control c in form.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(formClass);
                resources.ApplyResources(c, c.Name, new CultureInfo("en"));
            }
        }
    }
}
