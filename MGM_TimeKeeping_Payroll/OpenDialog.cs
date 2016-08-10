using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MGM_TimeKeeping_Payroll
{
    class OpenDialog
    {
        private void ReadTextorCSV() {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.InitialDirectory = @"C:\";
            openfiledialog1.Title = "Browse Text or CSV Files";

            openfiledialog1.CheckFileExists = true;
            openfiledialog1.CheckPathExists = true;

            openfiledialog1.RestoreDirectory = true;

            openfiledialog1.DefaultExt = "txt";
            openfiledialog1.Filter = "TXT|*.txt|CSV|*.csv";
            openfiledialog1.FilterIndex = 1;

            openfiledialog1.ReadOnlyChecked = true;
            openfiledialog1.ShowReadOnly = true;

            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                 //tb_filename.Text = openfiledialog1.FileName;
            }          
        }
    }
}