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
using System.Configuration;

namespace MGM_TimeKeeping_Payroll
{
    public partial class SearchEmployee : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ClassUtils utilsClass = new ClassUtils();
        public delegate void PassPerNo(string sender);
        public PassPerNo perNo;
        public static string sqlString;
        int selectedIndex = -1;

        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            loadRecords();
        }
        private void loadRecords()
        {
            ds.Clear();
            sqlString = @"SELECT EmployeeMaster.EmployeeID AS [Employee ID], ISNULL(EmployeeMaster.EmpLName, '')+', '+ISNULL(EmployeeMaster.EmpFName,'')+' '+ISNULL(EmployeeMaster.EmpMName,'')+' '+ISNULL(EmployeeMaster.EmpSuffix,'') AS Name, 
                          EmployeeEmploymentInfo.CmpBranch AS [Office], EmployeeEmploymentInfo.GrpofComp AS [Company Group], EmployeeEmploymentInfo.DeptCd AS [Dept] FROM EmployeeMaster 
                          LEFT OUTER JOIN dbo.EmployeeEmploymentInfo ON EmployeeEmploymentInfo.EmployeeID = EmployeeMaster.EmployeeID
                          ORDER BY EmployeeMaster.EmployeeID ASC";

            var constring = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            try
            {
                conn = new SqlConnection(@constring);
                conn.Open();
                cmd = new SqlCommand(sqlString, conn);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                da.Dispose();
                dgvDispRec.DataSource = ds.Tables[0];
                EmpCount.Text = dgvDispRec.Rows.Count.ToString() + " Record(s) Found";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                utilsClass = new ClassUtils();
                utilsClass.DisposeConn(da, ds, cmd, conn);
            }
        }

        private void tbSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            tbSearchbox.Text = utilsClass.cleanString(tbSearchbox.Text);
            da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            var constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            conn = new SqlConnection(@constr);
            try
            {
                if (rbEmpID.Checked == true)
                {
                    string query = @"SELECT EmployeeMaster.EmployeeID AS [Employee ID], ISNULL(EmployeeMaster.EmpLName, '')+', '+ISNULL(EmployeeMaster.EmpFName,'')+' '+ISNULL(EmployeeMaster.EmpMName,'')+' '+ISNULL(EmployeeMaster.EmpSuffix,'') AS Name, 
                                    EmployeeEmploymentInfo.CmpBranch AS [Office], EmployeeEmploymentInfo.GrpofComp AS [Company Group], EmployeeEmploymentInfo.DeptCd AS [Dept] FROM EmployeeMaster 
                                    LEFT OUTER JOIN dbo.EmployeeEmploymentInfo ON EmployeeEmploymentInfo.EmployeeID = EmployeeMaster.EmployeeID
                                    WHERE EmployeeMaster.EmployeeID LIKE '" + tbSearchbox.Text + "%' ORDER BY EmployeeMaster.EmployeeID ASC";
                    cmd = new SqlCommand(query ,conn);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvDispRec.DataSource = dt;
                    dgvDispRec.Visible = true;
                }
                else if (rbLName.Checked == true)
                {
                    string query = @"SELECT EmployeeMaster.EmployeeID AS [Employee ID], ISNULL(EmployeeMaster.EmpLName, '')+', '+ISNULL(EmployeeMaster.EmpFName,'')+' '+ISNULL(EmployeeMaster.EmpMName,'')+' '+ISNULL(EmployeeMaster.EmpSuffix,'') AS Name, 
                                    EmployeeEmploymentInfo.CmpBranch AS [Office], EmployeeEmploymentInfo.GrpofComp AS [Company Group], EmployeeEmploymentInfo.DeptCd AS [Dept] FROM EmployeeMaster 
                                    LEFT OUTER JOIN dbo.EmployeeEmploymentInfo ON EmployeeEmploymentInfo.EmployeeID = EmployeeMaster.EmployeeID
                                    WHERE EmployeeMaster.EmpLName LIKE '" + tbSearchbox.Text + "%' ORDER BY EmployeeMaster.EmployeeID ASC";
                    cmd = new SqlCommand(query, conn);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvDispRec.DataSource = dt;
                    dgvDispRec.Visible = true;
                }
                else if (rbFName.Checked == true)
                {
                    string query = @"SELECT EmployeeMaster.EmployeeID AS [Employee ID], ISNULL(EmployeeMaster.EmpLName, '')+', '+ISNULL(EmployeeMaster.EmpFName,'')+' '+ISNULL(EmployeeMaster.EmpMName,'')+' '+ISNULL(EmployeeMaster.EmpSuffix,'') AS Name, 
                                    EmployeeEmploymentInfo.CmpBranch AS [Office], EmployeeEmploymentInfo.GrpofComp AS [Company Group], EmployeeEmploymentInfo.DeptCd AS [Dept] FROM EmployeeMaster 
                                    LEFT OUTER JOIN dbo.EmployeeEmploymentInfo ON EmployeeEmploymentInfo.EmployeeID = EmployeeMaster.EmployeeID
                                    WHERE EmployeeMaster.EmpFName LIKE '" + tbSearchbox.Text + "%' ORDER BY EmployeeMaster.EmployeeID ASC";
                    cmd = new SqlCommand(query, conn);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvDispRec.DataSource = dt;
                    dgvDispRec.Visible = true;
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message + exc.StackTrace);
            }
            finally {
                utilsClass.DisposeConn(da, ds, cmd, conn);
            }
            EmpCount.Text = dt.Rows.Count.ToString() +" Record(s) Found";
            if (e.KeyCode == Keys.Down)
            {

                if (dgvDispRec.Visible == true)
                {
                    dgvDispRec.Focus();
                }
                else tbSearchbox.Focus();
            }
        }

        private void dgvDispRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) {
                passSearchRes();
            }       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            passSearchRes();
        }

        private void dgvDispRec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            passSearchRes();           
        }

        private void passSearchRes() {
            int rowindex = dgvDispRec.CurrentCell.RowIndex;
            int columnindex = dgvDispRec.CurrentCell.ColumnIndex;
            string cellval = dgvDispRec.Rows[rowindex].Cells[columnindex].Value.ToString();
            //correct code! 4:40pm 10/24/2016
            EmployeeEntry parent = (EmployeeEntry)Application.OpenForms["EmployeeEntry"];
            parent.SearchResult(cellval);
            this.Close();    
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            tbSearchbox.Clear();
            loadRecords();

        }     
    }
}