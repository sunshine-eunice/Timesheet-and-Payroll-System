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
            WindowState = FormWindowState.Maximized;
            MaximumSize = this.Size;
            MinimumSize = this.Size;
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
<<<<<<< HEAD
            form.ShowDialog(this);
=======
            form.ShowDialog();
<<<<<<< HEAD
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployees form = new ViewEmployees();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void tSDepartment_Click(object sender, EventArgs e)
        {
            Departments form = new Departments();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
<<<<<<< HEAD
=======
        }
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
        }

       
 
<<<<<<< HEAD
=======
=======
<<<<<<< HEAD
        }
 
=======
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        }      
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
    }
}