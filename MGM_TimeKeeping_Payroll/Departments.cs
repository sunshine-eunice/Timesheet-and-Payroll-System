using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;

namespace MGM_TimeKeeping_Payroll
{
    public partial class Departments : Form
    {
        private const string StrCon = @"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234";
        SqlConnection con = new SqlConnection(StrCon);
        
        public Departments()
        {
            InitializeComponent();
        }
        private void InsertDept() {
           // string query = @"";
            try
            {
                con.Open();      
            }
            finally {
                con.Close();
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
