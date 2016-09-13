using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MGM_TimeKeeping_Payroll
{
    public partial class EmployeeTnP : Form
    {
        //char delimiter;
        //char[] delimitChars = {',','"'};
       // string[] words;
        //Boolean DataLoaded = false;

        public EmployeeTnP()
        {
            InitializeComponent();     
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //Form.CenterToScreen();
            tb_EmName.Enabled = false;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //show lookup table
        }

        private void btn_payroll_Click(object sender, EventArgs e)
        {
            Payroll show = new Payroll();
            show.ShowDialog();
            this.Hide();
        }
     
        private void btn_timesheet_Click(object sender, EventArgs e)
        {
            DataTable tb_sheet = ConverttoDataTable(tb_filename.Text);
            dgv_Timesheet.DataSource = tb_sheet;            
            Sum_totalHrs();
            MinutesOfLates();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Browse Text or CSV Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.RestoreDirectory = true;
            
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "TXT|*.txt|CSV|*.csv|All Files|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            openFileDialog1.ShowDialog();           
            tb_filename.Text = openFileDialog1.FileName;                  
        }

        private void refresh()
        {
            new EmployeeTnP().Show();
            this.Dispose(false);
        }

        private void btn_clrtimesheet_Click(object sender, EventArgs e)
        {
            refresh();
        }
      
        private void Sum_totalHrs() {
            double sum = 0;
            //sum += Convert.ToDouble(dgv_Timesheet.Rows.Cells[8].Value);
          for (int i = 0; i < dgv_Timesheet.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgv_Timesheet.Rows[i].Cells[7].Value);
            } 
   
            tb_workhrs.Text = sum.ToString();
        }
        public static DataTable ConverttoDataTable(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string removeDquote = sr.ReadLine().Replace('"', ' ').Trim();
            string[] headers = removeDquote.Split(',');
            DataTable dt = new DataTable();
            DataColumn number = new DataColumn("No.", Type.GetType("System.Int32"));
            dt.Columns.Add(number);
            DataColumn timesheet_id = new DataColumn("User ID", Type.GetType("System.Int32"));
            dt.Columns.Add(timesheet_id);
            DataColumn emp_name = new DataColumn("Employee Name", Type.GetType("System.String"));
            dt.Columns.Add(emp_name);
            DataColumn wrkday = new DataColumn("Day", Type.GetType("System.String"));
            dt.Columns.Add(wrkday);
            DataColumn date = new DataColumn("Date", Type.GetType("System.DateTime"));
            dt.Columns.Add(date);
            DataColumn timein = new DataColumn("Time IN", Type.GetType("System.TimeSpan"));
            dt.Columns.Add(timein);
            DataColumn timeout = new DataColumn("Time OUT", Type.GetType("System.TimeSpan"));
            dt.Columns.Add(timeout);
            DataColumn totWrkHrs = new DataColumn("Total Working Hours", Type.GetType("System.Double"));
            dt.Columns.Add(totWrkHrs);          
          /*  foreach (string header in headers)
            {
                dt.Columns.Add(header);
            } */           
            while (!sr.EndOfStream)
            {
                string removequote = sr.ReadLine().Replace('"', ' ').Trim();
                string[] rows = removequote.Split(',');
                DataRow dr = dt.NewRow();

                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;  
        }
       
        private void MinutesOfLates()
        {
            TimeSpan late_duration;
            double sum_late = 0;
            DateTime start_time;
            DateTime.TryParse("08:00:00", out start_time); // to be replaced by parameter of schedule_start**
            TimeSpan timestart = start_time.TimeOfDay;
            TimeSpan timein;         

            for (int i = 0; i<dgv_Timesheet.Rows.Count; ++i)
            {
                timein = TimeSpan.Parse(Convert.ToString(dgv_Timesheet.Rows[i].Cells[5].Value));
                late_duration = timein.Subtract(timestart);
                double tot_minute = late_duration.TotalMinutes;

                if (tot_minute > 0)
                {
                    sum_late += tot_minute;
                }
            }
            tb_MinsOfLate.Text = sum_late.ToString();
        }
   }
}