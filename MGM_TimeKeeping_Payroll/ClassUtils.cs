using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MGM_TimeKeeping_Payroll
{
    class ClassUtils
    {
        public string DateNow()
        {
            string dateNow = "NA";
            dateNow = DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Year;
            return dateNow;
        }
        public string validateDate(string inputDate)
        {
            try
            {
                DateTime tmpDate = DateTime.Parse(inputDate);
                inputDate = tmpDate.Month.ToString().PadLeft(2, '0') + "/" + tmpDate.Day.ToString().PadLeft(2, '0') + "/" + tmpDate.Year;
                return inputDate;
            }
            catch
            {
               inputDate = DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Year;
               return inputDate;
            }
        }

        public void emptySQLString()
        
        {
            EmployeeEntry.sqlString = "empty";

        }

        public string cleanString(string input)
        {
            input = input.Replace("\'", "");
            input = input.Replace("\"", "");
            input = input.Replace("\\0", "");
            input = input.Replace("\\n", "");
            input = input.Replace("\\r", "");
            input = input.Replace("\\z", "");
            input = input.Replace("\\", "");
            input = input.Replace(";", "");
            return input;
        }

        public static DataTable GetData() {
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("GetEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable ddt = new DataTable();
            try
            {
                conn.Open();              
                ddt.Load(cmd.ExecuteReader());
                return ddt;
            }
            finally
            {
                conn.Close();
                //Disposing(ddt, cmd, conn);
            }
            }

        public void DisposeConn(SqlDataAdapter da,DataSet ds ,SqlCommand cmd,SqlConnection conn )
        {
            da.Dispose();
            ds.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }
        public void Disposing(DataTable dt, SqlCommand cmd, SqlConnection conn) {
            dt.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }
        public void ClearResultBox(TextBox min, TextBox max, TextBox ave, TextBox result)
        {
            min.Text=null;
            max.Text = null;
            ave.Text = null;
            result.Text = null;
        }
        
        public string TrimNumeric(string decimalString)
        {
            string trimNumeric = "";
            trimNumeric = decimal.Parse(decimalString).ToString("G29");
            return  trimNumeric;
        }
        public string ExactNumeric(string decimalString)
        {
            string exactNumeric = "";
            exactNumeric = string.Format("{0:n}", decimal.Parse(decimalString));
            return exactNumeric;
        }
       


    }
}
