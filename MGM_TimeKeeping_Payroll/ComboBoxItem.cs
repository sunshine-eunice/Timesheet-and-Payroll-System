using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGM_TimeKeeping_Payroll
{
    public class ComboBoxItem
    {
        public string val;
        public string text;


        public ComboBoxItem(string value, string Text)
        {
            val = value;
            text = Text;
        }

        public override string ToString()
        {
            return text;
        }
    }
    
}
