using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
                    textBox.SelectAll();
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
                    richTextBox.SelectAll();
                    return false;
                }
            }
            return true;
        }

        public static bool IsEmail(TextBox textBox)
        {
            if (IsPresent(textBox))
            {
                try
                {
                    MailAddress address = new MailAddress(textBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " email@domain.com");
                    textBox.Focus();
                    textBox.SelectAll();
                    return false;
                }
                return true;
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
                    textBox.SelectAll();
                }
            }
            return false;
        }

        public static bool IsEqualTo(TextBox txt1, TextBox txt2)
        {
            if (txt1.Text == txt2.Text)
            {
                return true;
            }
            MessageBox.Show("Passwords must be equal.");
            txt1.Focus();
            txt1.SelectAll();
            return false;
        }

        public static bool IsStateCode(TextBox textBox)
        {
            if (IsPresent(textBox))
            {
                if (Regex.IsMatch(textBox.Text, @"^[A-Za-z]{2}$"))
                {
                    return true;
                }
                MessageBox.Show("Must be a valid two character state code");
                textBox.Focus();
                textBox.SelectAll();
            }
            return false;
        }
    }
}
