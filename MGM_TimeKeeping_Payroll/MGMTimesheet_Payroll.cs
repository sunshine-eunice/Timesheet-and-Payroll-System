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
    public partial class MGMTimesheet_Payroll : Form
    {
        public MGMTimesheet_Payroll()
        {
            InitializeComponent();
        }     

        private void MGMTimesheet_Payroll_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Login show = new Login();
            show.StartPosition = FormStartPosition.CenterParent;
            show.ShowDialog();           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //enter or add employee on dbase
            EmployeeEntry form = new EmployeeEntry();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
      /*  private void timesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            EmployeeTnP form = new EmployeeTnP();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntry form = new EmployeeEntry();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
<<<<<<< HEAD
        }
 
=======
        }      
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
    }
}