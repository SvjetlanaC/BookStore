using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class TranslateAndThemeUtil
    {
        public static String language = "";
        public static int theme = 2;
        public static void CheckLanguage(Label l,String srb,String eng)
        {
            if (l.Text.Equals("SRB"))
            {
                MessageBox.Show(srb);
            }
            else
            {
                MessageBox.Show(eng);
            }
        }
        
    }
}
