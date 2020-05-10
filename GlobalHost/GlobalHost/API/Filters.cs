using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.API
{
    class Filters
    {
        public static void numericField(object o)
        {
           if(o.GetType() == typeof(TextBox))
            {
                TextBox t = ((TextBox)o);
                if (!t.Text.Any(char.IsDigit))
                    t.Clear();
            }
           else
            {
                MaskedTextBox t = ((MaskedTextBox)o);
                if (!t.Text.Any(char.IsDigit))
                    t.Clear();
            }
        }
        public static void alphanumericField(object o)
        {
            if (o.GetType() == typeof(TextBox))
            {
                TextBox t = ((TextBox)o);
                if (!t.Text.Any(char.IsLetter))
                    t.Clear();
            }
            else
            {
                MaskedTextBox t = ((MaskedTextBox)o);
                if (!t.Text.Any(char.IsLetter))
                    t.Clear();
            }
        }
        public static void mixedField(object o)
        {
            if (o.GetType() == typeof(TextBox))
            {
                TextBox t = ((TextBox)o);
                if (!t.Text.Any(char.IsLetterOrDigit))
                    t.Clear();
            }
            else
            {
                MaskedTextBox t = ((MaskedTextBox)o);
                if (!t.Text.Any(char.IsLetterOrDigit))
                    t.Clear();
            }
        }

    }
}
