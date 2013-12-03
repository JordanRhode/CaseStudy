using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy.Base
{
    public class Validator
    {
        private static string _title = "Entry Error";

        public static string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public static bool IsPresent(Object text)
        {
            if (text is TextBox)
            {
                TextBox textBox = (TextBox)text;
                if (textBox.Text == "")
                {
                    MessageBox.Show(string.Format("{0} is a required field.", textBox.Tag), Title);
                    textBox.Focus();
                    return false;
                }
            }
            else if (text is RichTextBox)
            {
                RichTextBox richTextBox = (RichTextBox)text;
                if (richTextBox.Text == "")
                {
                    MessageBox.Show(string.Format("{0} is a required field.", richTextBox.Tag), Title);
                    richTextBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool IsEmail(TextBox textBox)
        {
            string val = textBox.Text;
            if (val != "")
            {
                string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
                Match match = Regex.Match(val.Trim(), pattern, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool IsInt(TextBox textBox)
        {
            if (IsPresent(textBox))
            {
                try
                {
                    Convert.ToInt32(textBox.Text);
                    return true;
                }
                catch (FormatException)
                {
                    MessageBox.Show(string.Format("{0} must be an integer number.", textBox.Tag), Title);
                    textBox.Focus();
                    return false;
                }
            }
            return false;
        }

        public static bool IsEqualTo(TextBox txt1, TextBox txt2)
        {
            if(txt1.Text == txt2.Text)
            {
                return true;
            }
            MessageBox.Show("Passwords must be equal");
            return false;
        }
    }
}
