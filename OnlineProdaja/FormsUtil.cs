using OnlineProdaja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class FormsUtil
    {
        public static void Logout(Form form)
        {
            BookStoreDatabaseManipulation.UpdateTheme(Form1.username, TranslateAndThemeUtil.theme);
            Form1 f = new Form1();
            form.Hide();
            f.ShowDialog();
            form.Close();
        }

        public static void OpenForm(Form form,Form formToOpen)
        {
            form.Hide();
            formToOpen.ShowDialog();
            form.Close();
        }
        public static void OpenHelpForm(Form formToOpen)
        {
            
            formToOpen.ShowDialog();
            
        }
    }
}
