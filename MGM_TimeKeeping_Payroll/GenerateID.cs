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
using Microsoft.Reporting.WinForms;
using System.Configuration;

namespace MGM_TimeKeeping_Payroll
{
    public partial class GenerateID : Form
    {
       //public string EmployeeID = "MGM-PB-MAND-00007";//  //parameter for EmployeeID
        public string EmployeeID { get; set; }
      //  DataSet EmployeeMaster = new DataSet();
        public GenerateID()
        {
            InitializeComponent();
        }

        private void samplereport_Load(object sender, EventArgs e)
        {
            this.reportEmployee.RefreshReport();
            reportEmployee.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportEmployee.LocalReport;
            localReport.ReportPath = "Employee List1.rdlc";
            DataSet dataset = new DataSet();
            QueryReport("EmployeeMaster", EmployeeID,ref dataset);
            ReportDataSource empMaster = new ReportDataSource();
            ReportParameter pEmpIds = new ReportParameter("EmployeeID", EmployeeID);
            reportEmployee.LocalReport.SetParameters(new ReportParameter[] { pEmpIds });
            empMaster.Name = "EmployeeMaster";
            empMaster.Value = dataset.Tables[0];
          
            reportEmployee.RefreshReport();
            localReport.DataSources.Add(empMaster); 
            this.reportEmployee.RefreshReport();
        }

        private void QueryReport(string tblName, string EmployeeID, ref DataSet ds) {
            //pEmpID = "MGM-FD-MAND-00007";
            //string sqlString = "select *,GETDATE() as today,accountName+'/'+poNo as customerPO, CONVERT(varchar,convert(money,qtyForDelivery),1)+' '+qtyUnit as quantity from [QAQC.CocRecord] where cocNo = @cocNo";
            string sqlString = @"SELECT EmployeeMaster.EmployeeID, EmployeeMaster.EmpLName, EmployeeMaster.EmpFName, EmployeeMaster.EmpMName, EmployeeMaster.EmpSuffix, EmployeeMaster.sex, EmployeeMaster.birthdate, EmployeeMaster.EmpSSS, EmployeeMaster.EmpTIN, EmployeeMaster.EmpPagibigID, EmployeeMaster.EmpPhilhealthID, EmployeePictures.picture, EmployeeContactDetails.PCellNo, EmployeeContactDetails.PEmailAdd, EmployeeContactDetails.CtactPEgency, EmployeeContactDetails.CtactPAdd, EmployeeContactDetails.CtPsonNo
                                FROM [EmployeeMaster]
                                FULL JOIN [EmployeePictures] ON [EmployeeMaster].EmployeeID = [EmployeePictures].EmployeeID
                                FULL JOIN [EmployeeContactDetails] ON [EmployeeMaster].EmployeeID = EmployeeContactDetails.EmployeeID
                                WHERE EmployeeMaster.EmployeeID = @EmployeeID;";
            var connectionString = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            cmd.Parameters.Add(new SqlParameter("EmployeeID", EmployeeID));
            //cmd.Parameters.Add(new SqlParameter("cocNO", cocNO));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "reportEmployee");           
        }
    }
}
