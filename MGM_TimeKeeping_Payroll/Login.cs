using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MGM_TimeKeeping_Payroll
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)  {
            SqlConnection cn = new SqlConnection(@"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234");
                cn.Open();
                SqlCommand cmd  =   new SqlCommand("SELECT * FROM Login WHERE Username= '"+tb_username.Text+"' AND Password= '"+tb_password.Text+"'", cn);
                SqlDataReader dr;
                dr  =   cmd.ExecuteReader();
                int count = 0;

                while(dr.Read()) {
                    count   +=  1;
                }

            if (count == 1)    {
                this.Close();
            }
            else {
                MessageBox.Show("Invalid Username and Password.");
            }
                  Refresh();       
            }

        public override void Refresh() {
            tb_password.Clear();
            tb_username.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)    {
            //causing error
            Application.Exit();
        }
    }
}