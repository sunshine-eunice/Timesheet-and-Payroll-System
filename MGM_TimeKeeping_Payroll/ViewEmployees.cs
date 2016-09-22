using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGM_TimeKeeping_Payroll
{
    public partial class ViewEmployees : Form
    {
<<<<<<< HEAD
        public const string con = @"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234";
=======
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
        public ViewEmployees()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void btnSave_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM dbo.EmployeeMaster";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, con); //c.con is the connection string

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgViewEmployees.ReadOnly = true;
            dgViewEmployees.DataSource = ds.Tables[0];
        }
=======
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
    }
}
