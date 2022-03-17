using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilManager
{
    class StaticClasses
    {
        public static void TextToInt(TextBox textbox)
        {
            int newText=0;
            int.TryParse(textbox.Text, out newText);
            textbox.Text = newText.ToString();
        }
    }
}
