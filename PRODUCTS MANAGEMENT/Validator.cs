using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductMaintainance
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsPresent(TextBox textBox)
        {
         if(textBox.Text == "")
         {
             MessageBox.Show(textBox.Tag + "is a required field ..." + Title);
             textBox.Focus();
             return false;
         }
         return true;
        }

        public static bool IsDecimal(TextBox textbox)
        {
            try
            {
                Convert.ToDecimal(textbox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(textbox.Tag + "invalid entry ... must be number" + Title);
                textbox.Focus();
                return false;
            }
        }



        internal static bool IsInt32(TextBox textbox)
        {
            try
            {
                Convert.ToInt32(textbox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(textbox.Tag + "invalid entry ... must be number" + Title);
                textbox.Focus();
                return false;
            }
        }
    }
}
