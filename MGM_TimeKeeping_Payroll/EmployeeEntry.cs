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
using System.Data.SqlClient; // CANNNOT ACCESS SQL /ADO.NET WITHOUT THIS 
using System.Reflection;
using System.IO;

namespace MGM_TimeKeeping_Payroll
{
    public partial class EmployeeEntry : Form
<<<<<<< HEAD
    {      
       // public const string EmpID;
        
        public const string con = @"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234";
        public string imagePath;
        public string employID { get; set; }
        private int i;
        private int rowIndex = 0;
        public string getID;
        public string WorkHrType;
        public static string sqlString = "empty";
        ClassUtils utilsClass = new ClassUtils();
        DateTimePicker childbdate;
        SqlConnection conn = new SqlConnection(con);
        DateTime date1;
        string dayOfdate;
        //int record = 0;

=======
    {
<<<<<<< HEAD
       // public const string EmpID;
        public const string con = @"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234";
        public string imagePath;
        public string getID;
        DateTimePicker childbdate;
        SqlConnection conn = new SqlConnection(con);

=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
      //  public const string EmpID;
        public const string con = @"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234";
        public string getID;
        SqlConnection conn = new SqlConnection(con);

<<<<<<< HEAD
=======
=======
        public const string con = @"Data Source=MGMITM02;Initial Catalog=db_Payroll;Persist Security Info=True;User ID=sa; Password=1234";
<<<<<<< HEAD
        SqlConnection conn = new SqlConnection(con);

=======
<<<<<<< HEAD
        SqlConnection conn = new SqlConnection(con);
=======
<<<<<<< HEAD
        SqlConnection conn = new SqlConnection(con);
=======
>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        public EmployeeEntry()
        {
            InitializeComponent();
            AddComboBoxesItems();
            AddNationality();
<<<<<<< HEAD
            selectCivilStat();
            //SelectCmpGrp();
            //SelectCmpBranch();
        }
        DateTime time = DateTime.Today;
        DataTable dtSetAddresses = new DataTable();
        DataTable dtChild = new DataTable();
        DataTable dtEduc = new DataTable();
        DataTable dtSched = new DataTable();
        DataTable dtStandard = new DataTable();
        DataTable tbAddress = new DataTable();
        DataTable nw = new DataTable();
        DataTable pic = new DataTable();
        DataTable dtChild2 = new DataTable();
        DataTable dtEducation = new DataTable();
        DataSet ds = new DataSet("Employees");            
        //public _companygrp CompGrp { get; set; }
     
        //Load Form
        //Loading Values to Datatable 
        DataTable dts = new DataTable();

        private DataTable GetData() {
            return dts;
        }
        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            dgvAddViewing.Visible = false;
            dgvChild1.Visible = false;
            dgvEducation.Visible = false;
            this.dt_ExitDate.Format = DateTimePickerFormat.Custom;
            this.dt_ExitDate.CustomFormat = " ";
      //      ((Control)this.tabEmployees).Enabled = false; //disables all controls before adding
            ViewModeEmployee();
            groupBox9.Enabled = false;
            Datepickers();
            cb_bank.Enabled = false;
            AddColumnstoDgvAddress();           
            dgvAddress_UserAddedRow();
            AddnewRow();
            AddColumnstoDgvChild();
            addallColumnstoRows_dgvChild();
            AddColumns0fEducBckground();
            AddRowsOfEducBckgrnd();
            AddnewRowEduc();                       
            //AddRowstoSchedule();
            //AddValuetoWorkingDays();
            this.dgvSchedule.Columns[0].Visible = false;
            this.dgvEduc.Columns[0].Visible = false;
            CBHours();
            WorkHrType = "S";   
        }
        //Comboboxes
        private void CBHours() {
            for (DateTime tm = time.AddHours(8); tm < time.AddHours(22); tm = tm.AddMinutes(30))
            {
                cbStartTime.Items.Add(tm.ToShortTimeString());
                cbEndTime.Items.Add(tm.ToShortTimeString());
            }        
=======
<<<<<<< HEAD
            selectCivilStat();
        //    SelectCmpGrp();
            //SelectCmpBranch();
        }
        DataTable dtSetAddresses = new DataTable();
        DataTable dtChild = new DataTable();
        DataTable dtEduc = new DataTable();
        DataTable dtSched = new DataTable();
        //public _companygrp CompGrp { get; set; }
     
        //Load Form
        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            this.dt_ExitDate.Format = DateTimePickerFormat.Custom;
            this.dt_ExitDate.CustomFormat = " ";
      //      ((Control)this.tabEmployees).Enabled = false; //disables all controls before adding
            ViewModeEmployee();
            groupBox9.Enabled = false;
            Datepickers();
            cb_bank.Enabled = false;
            tb_company.Text = "MGM";
            AddColumnstoDgvAddress();           
            dgvAddress_UserAddedRow();
            AddnewRow();
            AddColumnstoDgvChild();
            addallColumnstoRows_dgvChild();
            AddColumns0fEducBckground();
            AddRowsOfEducBckgrnd();
            AddnewRowEduc();
            AddColSchedule();
            AddRowstoSchedule();
            AddValuetoWorkingDays();
            this.dgvSchedule.Columns[0].Visible = false;
            this.dgvEduc.Columns[0].Visible = false;
        //
        }     
        #region DatePickers Settings
        private void Datepickers()
        {
           dt_bdate.Format = DateTimePickerFormat.Custom;
            dt_datejoined.Format = DateTimePickerFormat.Custom;
         //   dtEffectivedate.Format = DateTimePickerFormat.Custom;
            dt_ExitDate.Format = DateTimePickerFormat.Custom;
            dt_EffectiveDate.Format = DateTimePickerFormat.Custom;           
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
         //   dtEffectivedate.CustomFormat = "MM/dd/yyyy";
            dt_EffectiveDate.CustomFormat = "MM/dd/yyyy";
            dt_ExitDate.CustomFormat = "MM/dd/yyyy";
=======
<<<<<<< HEAD
            selectCivilStat();
        //    SelectCmpGrp();
            //SelectCmpBranch();
        }
        DataTable dtSetAddresses = new DataTable();
=======
<<<<<<< HEAD
            selectCivilStat();
        //    SelectCmpGrp();
            //SelectCmpBranch();
        }
        DataTable dtSetAddresses = new DataTable();
=======
<<<<<<< HEAD
            selectCivilStat();
            SelectCmpGrp();
            SelectCmpBranch();
=======
<<<<<<< HEAD
            selectCivilStat();
=======
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a

>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
        }

        //public _companygrp CompGrp { get; set; }
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456

        //public _companygrp CompGrp { get; set; }
        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            ((Control)this.tabEmployees).Enabled = false; //disables all controls before adding
            Datepickers();
            cb_bank.Enabled = false;
            tb_company.Text = "MGM";
<<<<<<< HEAD
            AddColumnstoDgvAddress();           
            dgvAddress_UserAddedRow();
            AddnewRow();       
            
=======
            InitDgvAddressValue();
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /* tb_age.Clear();
            DateTime today = DateTime.Today;
            DateTime byear = dt_bdate.Value.Date;
            int c = ComputeAge(today.Year, byear.Year);
            tb_age.Text += c; */
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        }
        enum Days
        {
            Mon, Tue, Wed, Thu, Fri
        };     
        #region DatePickers Settings
      
        private void Datepickers()
        {
<<<<<<< HEAD
           dt_bdate.Format = DateTimePickerFormat.Custom;
            dt_datejoined.Format = DateTimePickerFormat.Custom;
         //   dtEffectivedate.Format = DateTimePickerFormat.Custom;
            dt_ExitDate.Format = DateTimePickerFormat.Custom;
            dt_EffectiveDate.Format = DateTimePickerFormat.Custom;           
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
         //   dtEffectivedate.CustomFormat = "MM/dd/yyyy";
            dt_EffectiveDate.CustomFormat = "MM/dd/yyyy";
            dt_ExitDate.CustomFormat = "MM/dd/yyyy";
=======
<<<<<<< HEAD
           dt_bdate.Format = DateTimePickerFormat.Custom;
            dt_datejoined.Format = DateTimePickerFormat.Custom;
         //   dtEffectivedate.Format = DateTimePickerFormat.Custom;
            dt_ExitDate.Format = DateTimePickerFormat.Custom;
            dt_EffectiveDate.Format = DateTimePickerFormat.Custom;           
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
         //   dtEffectivedate.CustomFormat = "MM/dd/yyyy";
            dt_EffectiveDate.CustomFormat = "MM/dd/yyyy";
            dt_ExitDate.CustomFormat = "MM/dd/yyyy";
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
           dt_bdate.Format = DateTimePickerFormat.Custom;
            dt_datejoined.Format = DateTimePickerFormat.Custom;
         //   dtEffectivedate.Format = DateTimePickerFormat.Custom;
            dt_ExitDate.Format = DateTimePickerFormat.Custom;
            dt_EffectiveDate.Format = DateTimePickerFormat.Custom;           
<<<<<<< HEAD
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
         //   dtEffectivedate.CustomFormat = "MM/dd/yyyy";
            dt_EffectiveDate.CustomFormat = "MM/dd/yyyy";
            dt_ExitDate.CustomFormat = "MM/dd/yyyy";
=======
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
         //   dtEffectivedate.CustomFormat = "MM/dd/yyyy";
            dt_EffectiveDate.CustomFormat = "MM/dd/yyyy";
            dt_ExitDate.CustomFormat = "MM/dd/yyyy";
=======
<<<<<<< HEAD
           dt_bdate.Format = DateTimePickerFormat.Custom;
=======
<<<<<<< HEAD
           dt_bdate.Format = DateTimePickerFormat.Custom;
=======
          /*  dt_bdate.Format = DateTimePickerFormat.Custom;
>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
            dt_datejoined.Format = DateTimePickerFormat.Custom;
         //   dtEffectivedate.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
           /* dategrad.Format = DateTimePickerFormat.Custom;
            dategrad.CustomFormat = "MM/dd/yyyy"; */
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
         //   dtEffectivedate.CustomFormat = "MM/dd/yyyy";
            dateTimePicker4.CustomFormat = "MM/dd/yyyy";
=======
            dateTimePicker3.CustomFormat = "MM/dd/yyyy";
            dateTimePicker4.CustomFormat = "MM/dd/yyyy"; */
>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        }
        #endregion DatePicker Settings
        #region ComputeAge
        public int ComputeAge(int present_yr, int birth_yr)
        {
            int n = present_yr - birth_yr;
            return n;
        }
        #endregion ComputeAge
<<<<<<< HEAD
        
        private void AddColumnstoDgvAddress() {
            foreach (DataGridViewColumn col in dgvAddress.Columns) {
                dtSetAddresses.Columns.Add(col.Name);
                col.DataPropertyName = col.Name;
            }
        }
   
        private void dgvAddress_UserAddedRow()
        {
            try
            {
                DataRow addAddress = null;
                foreach (DataGridViewRow row in dgvAddress.Rows)
                {
                    addAddress = dtSetAddresses.NewRow();
                    addAddress["EmployeeID"] = row.Cells["EmployeeID"].Value;
                    addAddress["AddressType"] = row.Cells["AddressType"].Value;
                    addAddress["UnitNoBldgName"] = row.Cells["UnitNoBldgName"].Value;
                    addAddress["LotBlkNos"] = row.Cells["LotBlkNos"].Value;
                    addAddress["Street"] = row.Cells["Street"].Value;
                    addAddress["subdivision"] = row.Cells["subdivision"].Value;
                    addAddress["BrgyDistr"] = row.Cells["BrgyDistr"].Value;
                    addAddress["CityMunicipal"] = row.Cells["CityMunicipal"].Value;
                    addAddress["Province"] = row.Cells["Province"].Value;
                    addAddress["Country"] = row.Cells["Country"].Value;
                    addAddress["Zipcode"] = row.Cells["Zipcode"].Value;
                    dtSetAddresses.Rows.Add(addAddress);
                }
                dgvAddress.DataSource = dtSetAddresses;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddnewRow() {
            DataRow dr = dtSetAddresses.Rows[0];
            dr[1] = "Current";

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        #region dgvAddress
        private void AddColumnstoDgvAddress() {
            foreach (DataGridViewColumn col in dgvAddress.Columns) {
                dtSetAddresses.Columns.Add(col.Name);
                col.DataPropertyName = col.Name;
            }
            dgvAddress.Columns[0].Visible = false;
        }  
   
        private void dgvAddress_UserAddedRow()
<<<<<<< HEAD
=======
=======
            dtSetAddresses.Rows.Add("","Permanent");
        }
        
=======
        private void AddDgvAddressColumns() {
            foreach (DataGridViewColumn col in dgvAddress.Columns) {
                dtSetAddresses.Columns.Add(col.Name);
            }
        }
        private void InitDgvAddressValue()
        {
            dgvAddress.Rows.Add(1);
            this.dgvAddress.Rows[0].Cells[0].Value = "Current";
            this.dgvAddress.Rows[1].Cells[0].Value = "Permanent";
        }
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
        private void btn_Cancel_Click(object sender, EventArgs e)
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        {
            try
            {
                DataRow addAddress = null;
                foreach (DataGridViewRow row in dgvAddress.Rows)
                {
                    addAddress = dtSetAddresses.NewRow();
                    addAddress["EmployeeID"] = row.Cells["EmployeeID"].Value;
                    addAddress["AddressType"] = row.Cells["AddressType"].Value;
                    addAddress["UnitNoBldgName"] = row.Cells["UnitNoBldgName"].Value;
                    addAddress["LotBlkNos"] = row.Cells["LotBlkNos"].Value;
                    addAddress["Street"] = row.Cells["Street"].Value;
                    addAddress["subdivision"] = row.Cells["subdivision"].Value;
                    addAddress["BrgyDistr"] = row.Cells["BrgyDistr"].Value;
                    addAddress["CityMunicipal"] = row.Cells["CityMunicipal"].Value;
                    addAddress["Province"] = row.Cells["Province"].Value;
                    addAddress["Country"] = row.Cells["Country"].Value;
                    addAddress["Zipcode"] = row.Cells["Zipcode"].Value;
                    dtSetAddresses.Rows.Add(addAddress);
                }
                dgvAddress.DataSource = dtSetAddresses;
            }
<<<<<<< HEAD
            catch (SqlException ex)
=======
            catch (Exception ex)
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void AddnewRow() {
            DataRow dr = dtSetAddresses.Rows[0];
            dr[1] = "Current";
            dtSetAddresses.Rows.Add("","Permanent");
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        #endregion dgvAddress
        #region dgvEducBackground

        private void AddColumns0fEducBckground() {
            foreach (DataGridViewColumn col2 in dgvEduc.Columns) {
                dtEduc.Columns.Add(col2.Name);
                col2.DataPropertyName = col2.Name;
            }
            
        }
        private void AddRowsOfEducBckgrnd() {
<<<<<<< HEAD
            try
            {
                DataRow addEduc = null;
                foreach (DataGridViewRow row in dgvEduc.Rows)
                {
                    addEduc = dtEduc.NewRow();
                    addEduc["EmployeeID4"] = row.Cells["EmployeeID4"].Value;
                    addEduc["EducationalLevel"] = row.Cells["EducationalLevel"].Value;
                    addEduc["schoolName"] = row.Cells["schoolName"].Value;
                    addEduc["schoolAdd"] = row.Cells["schoolAdd"].Value;
                    addEduc["yeargraduated"] = row.Cells["yeargraduated"].Value;
                    addEduc["Degree"] = row.Cells["Degree"].Value;
                    addEduc["Course"] = row.Cells["Course"].Value;
                    dtEduc.Rows.Add(addEduc);
                }
                dgvEduc.DataSource = dtEduc;
            }
            catch (SqlException ex) {
=======
            try
            {
                DataRow addEduc = null;
                foreach (DataGridViewRow row in dgvEduc.Rows)
                {
                    addEduc = dtEduc.NewRow();
                    addEduc["EmployeeID4"] = row.Cells["EmployeeID4"].Value;
                    addEduc["EducationalLevel"] = row.Cells["EducationalLevel"].Value;
                    addEduc["schoolName"] = row.Cells["schoolName"].Value;
                    addEduc["schoolAdd"] = row.Cells["schoolAdd"].Value;
                    addEduc["yeargraduated"] = row.Cells["yeargraduated"].Value;
                    addEduc["Degree"] = row.Cells["Degree"].Value;
                    addEduc["Course"] = row.Cells["Course"].Value;
                    dtEduc.Rows.Add(addEduc);
                }
                dgvEduc.DataSource = dtEduc;
=======
<<<<<<< HEAD
        //Saving to SQL tables
        private void btn_Save_Click(object sender, EventArgs e) 
=======
        private void btn_Save_Click(object sender, EventArgs e)
<<<<<<< HEAD
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
        {
            IncrementIDSeries();
           //AddPicture();
           AddEmployeeMaster();
           //AddEmpParents();
           //AddSpouseDetails();
<<<<<<< HEAD
           PassDTAddresstoSQL();
           AddEmpContactDetails();
            MessageBox.Show("Employee Account Saved!");
=======
            MessageBox.Show("Employee Account Saved!");
=======
<<<<<<< HEAD
        {
            IncrementIDSeries();
            AddPicture();
          //  AddEmployeeMaster();
           // AddEmpParents();
            //AddSpouseDetails();
            MessageBox.Show("Employee Account Saved!");
=======
<<<<<<< HEAD
        {
            AddEmployeeMaster();
           // AddEmpParents();
            //AddSpouseDetails();
            MessageBox.Show("Employee Account Saved!");
=======
<<<<<<< HEAD
        {
            AddEmployeeMaster();      
=======
        {           
            SqlConnection conn = new SqlConnection(con);     
            try
            {
                conn.Open();
                SqlCommand InsertEmployeeMasteer = new SqlCommand("SPInsertMasterEmployee", conn);
                InsertEmployeeMasteer.CommandType = CommandType.StoredProcedure;
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpID", tb_EmployeeID.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpFName", tb_FName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpMName", tb_MName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpLName", tb_LName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSuffix", tb_Suffix.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@birthdate", dt_bdate.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@CivilStatus", cb_CivilStat.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@Nationality", cb_Nationality.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpTIN", tb_TIN.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSSS", tb_SSS.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpPhilhealthID", tb_PHealth.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthINSCd", cb_INScode.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthINSName", tb_INSName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthInsID", tb_insID.Text));
                SqlCommand InsertEmAdd = new SqlCommand("SPInsertEmployeeAddress", conn);
                InsertEmAdd.Parameters.Add(new SqlParameter("@EmployeeID", ""));
                InsertEmAdd.Parameters.Add(new SqlParameter("AddressType", tb_EmployeeID.Text));
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
            }
            catch (Exception ex) {
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                MessageBox.Show(ex.Message);
            }
        }
        private void AddnewRowEduc()   {
            dgvEduc.Rows[0].Cells[1].Value = "Elementary";
            dtEduc.Rows.Add("","High School");
            dtEduc.Rows.Add("","College");
            dtEduc.Rows.Add("", "Graduate School");
<<<<<<< HEAD
            //dgvEduc.Rows.Add("","High ");
=======
         //   dgvEduc.Rows.Add("","High ");
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            //dgvEduc.Rows[1].Cells[1].Value = "High School";
            //dgvEduc.Rows[2].Cells[1].Value = "College";
            //dgvEduc.Rows[3].Cells[1].Value = "Graduate School";
        }
        #endregion dgvEducBackground
        #region dgvChildren
       private void chb_withChild_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_withChild.Checked == true)
<<<<<<< HEAD
            {
                dgvChild.Enabled = true;
            }
        } 

        private void AddColumnstoDgvChild()
        {
            foreach (DataGridViewColumn col1 in dgvChild.Columns)
            {
                dtChild.Columns.Add(col1.Name);
                col1.DataPropertyName = col1.Name;
            }
        }
        private void addallColumnstoRows_dgvChild() {
            try
            {
                DataRow addChild = null;
                foreach (DataGridViewRow row in dgvChild.Rows)
                {
                    addChild = dtChild.NewRow();
                    addChild["EmployeeID1"] = row.Cells["EmployeeID1"].Value;
                    addChild["childLname"] = row.Cells["childLname"].Value;
                    addChild["childFName"] = row.Cells["childFName"].Value;
                    addChild["childMName"] = row.Cells["childMName"].Value;
                    addChild["childSuffix"] = row.Cells["childSuffix"].Value;
                    addChild["childbday"] = row.Cells["childbday"].Value;
                    dtChild.Rows.Add(addChild);
                }
                dgvChild.DataSource = dtChild;
            }

            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
=======
            {
<<<<<<< HEAD
                dgvChild.Enabled = true;
            }
        } 

        private void AddColumnstoDgvChild()
        {
            foreach (DataGridViewColumn col1 in dgvChild.Columns)
            {
                dtChild.Columns.Add(col1.Name);
                col1.DataPropertyName = col1.Name;
            }
        }
        private void addallColumnstoRows_dgvChild() {
            try
            {
                DataRow addChild = null;
                foreach (DataGridViewRow row in dgvChild.Rows)
                {
                    addChild = dtChild.NewRow();
                    addChild["EmployeeID1"] = row.Cells["EmployeeID1"].Value;
                    addChild["childLname"] = row.Cells["childLname"].Value;
                    addChild["childFName"] = row.Cells["childFName"].Value;
                    addChild["childMName"] = row.Cells["childMName"].Value;
                    addChild["childSuffix"] = row.Cells["childSuffix"].Value;
                    addChild["childbday"] = row.Cells["childbday"].Value;
                    dtChild.Rows.Add(addChild);
                }
                dgvChild.DataSource = dtChild;
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                childbdate = new DateTimePicker();
                dgvChild.Controls.Add(childbdate);
                childbdate.Visible = false;
                childbdate.Format = DateTimePickerFormat.Short;
                childbdate.TextChanged += new EventHandler(childbdates_OntextChange);
                childbdate.Visible = true;
                Rectangle chRectangle = dgvChild.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                childbdate.Size = new Size(chRectangle.Width, chRectangle.Height);
                childbdate.Location = new Point(chRectangle.X, chRectangle.Y);
                childbdate.CloseUp +=new EventHandler(childbdate_CloseUp);
            }
        }
        private void childbdate_CloseUp(object sender, EventArgs e) { 
                childbdate.Visible = false;
        }

        private void childbdates_OntextChange(object sender, EventArgs e) {
                dgvChild.CurrentCell.Value = childbdate.Text.ToString();
        }

        #endregion dgvChildren
        #region dgvSchedule
        private void AddColSchedule() {
            foreach (DataGridViewColumn col3 in dgvSchedule.Columns) 
            {
                dtSched.Columns.Add(col3.Name);
                col3.DataPropertyName = col3.Name;
            }
            
        }
        private void AddRowstoSchedule() {
            try
            {
                DataRow addRows = null;
                foreach (DataGridViewRow row1 in dgvSchedule.Rows) {
                    addRows = dtSched.NewRow();
                    addRows["EmployeeID3"] = row1.Cells["EmployeeID3"].Value;
<<<<<<< HEAD
                    addRows["Date"] = row1.Cells["Date"].Value;
=======
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                    addRows["WorkingDay"] = row1.Cells["WorkingDay"].Value;
                    addRows["WrkHrStart"] = row1.Cells["WrkHrStart"].Value;
                    addRows["WrkHrEnd"] = row1.Cells["WrkHrEnd"].Value;
                    dtSched.Rows.Add(addRows);
                }
                dgvSchedule.DataSource = dtSched;
            }
<<<<<<< HEAD
            catch (SqlException ex)
=======
            catch (Exception ex)
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            {
                MessageBox.Show(ex.Message);
            }
        }
<<<<<<< HEAD
=======
        private void AddValuetoWorkingDays() {
            dgvSchedule.Rows[0].Cells[1].Value = "Monday";
            dtSched.Rows.Add("","Tuesday");
            dtSched.Rows.Add("", "Wednesday");
            dtSched.Rows.Add("", "Thursday");
            dtSched.Rows.Add("", "Friday");
            dtSched.Rows.Add("", "Saturday");
            dtSched.Rows.Add("", "Sunday");
        }
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        #endregion dgvSchedule
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        //Saving to SQL tables
        private void btn_Save_Click(object sender, EventArgs e) 
        {
<<<<<<< HEAD
           IncrementIDSeries();      
=======
            IncrementIDSeries();      
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
           AddEmployeeMaster();
           AddPicture();
           AddEmpParents();
           AddSpouseDetails();
           PassDTAddresstoSQL();
           AddEmpContactDetails();
           PassDTChildtoSQL();
           PassDTEducBackgroundtoSQL();
<<<<<<< HEAD
           AddEmploymentInfo();
           writeStdardSchedMaster();
           regularscheddetail();
           writeSchedDet();
           MessageBox.Show("Employee Account Saved!");
           ViewModeEmployee();
=======

           MessageBox.Show("Employee Account Saved!");
=======
                conn.Close();
            }           
>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        }
        private void cb_formpayment_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_formpayment.Text == "Paycard")
            {
                cb_bank.Enabled = true;
            }
            else
            {
                cb_bank.Enabled = false;
            }
        }
        private void cb_1pay_SelectedValueChanged(object sender, EventArgs e)
        {
            // if (cb_1pay.Text == "")
        }
        #region Employee Entry Comboboxes
        private void AddComboBoxesItems()
        {
            #region Personal Info: Sex
            //Gender
            cb_sex.Items.Add(new ComboBoxItem("0","Male"));
            cb_sex.Items.Add(new ComboBoxItem("1", "Female"));

            //Civil Status
         /*   cb_CivilStat.Items.Add(new ComboBoxItem("0","Single"));
            cb_CivilStat.Items.Add(new ComboBoxItem("1", "Married"));
            cb_CivilStat.Items.Add(new ComboBoxItem("2", "Widowed"));
            cb_CivilStat.Items.Add(new ComboBoxItem("3", "Annulled"));

            //Highes Educ Level
        /*    cb_higheduclvl.Items.Add(new ComboBoxItem("0","High School"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("1", "Bachelor Degree"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("2","Vocational"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("3","Master's Degree"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("4","Doctorate Degree")); */
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            #endregion Personal Info
            #region Employment Info

            /*//Company Grps
            cb_grpofcom.Items.Add(new ComboBoxItem("0", "Foods"));
            cb_grpofcom.Items.Add(new ComboBoxItem("1", "Blendwell"));
            cb_grpofcom.Items.Add(new ComboBoxItem("2", "Premium Beverages"));
            */
            //Employee Status
            cb_EStatus.Items.Add(new ComboBoxItem("0","Casual"));
            cb_EStatus.Items.Add(new ComboBoxItem("1", "Probationary"));
            cb_EStatus.Items.Add(new ComboBoxItem("2","Regular"));
            cb_EStatus.Items.Add(new ComboBoxItem("3", "Permanent"));
            cb_EStatus.Items.Add(new ComboBoxItem("4", "Resigned"));
            cb_EStatus.Items.Add(new ComboBoxItem("5", "Terminated"));
            cb_EStatus.Items.Add(new ComboBoxItem("6", "Regular"));
            cb_EStatus.Items.Add(new ComboBoxItem("7", "Retired"));

       /*     //Office Branch
            cb_officebranch.Items.Add(new ComboBoxItem("0", "CAV"));
            cb_officebranch.Items.Add(new ComboBoxItem("1", "MAND")); */

            //Department
            cb_dept.Items.Add(new ComboBoxItem("0", "Accounting"));
            cb_dept.Items.Add(new ComboBoxItem("1", "General Office/SOP"));
            cb_dept.Items.Add(new ComboBoxItem("2", "IT"));
            cb_dept.Items.Add(new ComboBoxItem("3", "Sales"));
            cb_dept.Items.Add(new ComboBoxItem("4", "Purchasing"));
            cb_dept.Items.Add(new ComboBoxItem("5", "Finance"));
            cb_dept.Items.Add(new ComboBoxItem("6", "Human Resources"));
            cb_dept.Items.Add(new ComboBoxItem("7", "Credits and Collection"));
            cb_dept.Items.Add(new ComboBoxItem("8", "Transportation"));
            cb_dept.Items.Add(new ComboBoxItem("9", "Production Planning Inventory Control"));
            cb_dept.Items.Add(new ComboBoxItem("10","Arts"));
            cb_dept.Items.Add(new ComboBoxItem("11","Research and Development"));
            cb_dept.Items.Add(new ComboBoxItem("12", "Packaging"));
            cb_dept.Items.Add(new ComboBoxItem("13", "Ingredients"));

            //Form of Payments
            cb_formpayment.Items.Add(new ComboBoxItem("0","Paycard"));
            cb_formpayment.Items.Add(new ComboBoxItem("1","Cash"));
            cb_formpayment.Items.Add(new ComboBoxItem("2","Paypal"));

            //Payment Terms
            cb_paymentterms.Items.Add(new ComboBoxItem("0", "Daily"));
            cb_paymentterms.Items.Add(new ComboBoxItem("1", "Monthly"));

            //1st payment
            cb_1pay.Items.Add(new ComboBoxItem("0","5"));
            cb_1pay.Items.Add(new ComboBoxItem("1","10"));
            cb_1pay.Items.Add(new ComboBoxItem("2","15"));

            //2nd payment
            cb_2pay.Items.Add(new ComboBoxItem("0","20"));
            cb_2pay.Items.Add(new ComboBoxItem("1","25"));
            cb_2pay.Items.Add(new ComboBoxItem("2","30"));

            //Banks
            cb_bank.Items.Add(new ComboBoxItem("0","BDO Unibank"));
            cb_bank.Items.Add(new ComboBoxItem("1", "Metrobank"));
            cb_bank.Items.Add(new ComboBoxItem("2", "BPI"));
            cb_bank.Items.Add(new ComboBoxItem("3", "Land Bank"));
            cb_bank.Items.Add(new ComboBoxItem("4", "PNB"));
            cb_bank.Items.Add(new ComboBoxItem("5", "Union Bank"));
            cb_bank.Items.Add(new ComboBoxItem("6", "Security Bank"));
            cb_bank.Items.Add(new ComboBoxItem("7", "RCBC"));
            #endregion Employment Info
        }
<<<<<<< HEAD
        #endregion Employee Entry Comboboxes                        
        #region SQLaddingofEmployeeTables
=======
<<<<<<< HEAD
        #endregion Employee Entry Comboboxes                        
        #region SQLaddingofEmployeeTables
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD

>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
        #endregion Employee Entry Comboboxes                        

>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                PicBox_Pic.Image = new Bitmap(open.FileName);
                imagePath = open.FileName;
            } 
        }
       
        private void AddEmployeeMaster() {
            //string employeeID;
<<<<<<< HEAD
=======
=======
                PicBox_Pic.Image = new Bitmap(open.FileName);              
            } 
        }
<<<<<<< HEAD
        private void AddEmployeeMaster() {
            //string employeeID;
=======
<<<<<<< HEAD
        private void AddEmployeeMaster() {
            //string employeeID;
=======

        private void AddEmployeeMaster() {

>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            int active;
            if (chb_withChild.Checked)
            {
                active = 1;
            }
            else {
                active = 0;
            }
            try
            {
<<<<<<< HEAD
                //SqlConnection AHAJ = 
=======
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                conn.Open();
                SqlCommand InsertEmployeeMasteer = new SqlCommand("SPInsertMasterEmployee", conn);
                InsertEmployeeMasteer.CommandType = CommandType.StoredProcedure;
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpID", tb_EmployeeID.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpFName", tb_FName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpMName", tb_MName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpLName", tb_LName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSuffix", tb_Suffix.Text));
<<<<<<< HEAD
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@birthdate", tbBdate.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@birthplace", tbBPlace.Text));
=======
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@birthdate", dt_bdate.Text));
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@CivilStatus", cb_CivilStat.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@Nationality", cb_Nationality.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@sex", cb_sex.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpTIN", tb_TIN.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSSS", tb_SSS.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthInsType", "H"));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@withchild", active));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpPagibigID", tb_pagibig.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpPhilhealthID", tb_PHealth.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthINSCd", cb_INScode.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthINSName", tb_INSName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthInsID", tb_insID.Text));
                InsertEmployeeMasteer.ExecuteNonQuery();
            }   
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
        
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            finally
            {            
                conn.Close();
            }  
<<<<<<< HEAD
        }    // OK

        private void AddEmpParents() {    
=======
<<<<<<< HEAD
        }    // OK
        private void AddEmpParents() {    
=======
<<<<<<< HEAD
        }    // OK
        private void AddEmpParents() {    

=======
        }   
<<<<<<< HEAD
        private void AddEmpParents() {    

=======
    
        private void AddEmpParents() {
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            try
            {
                conn.Open();
                SqlCommand AddParents = new SqlCommand("SPInsertEmpParents", conn);
                AddParents.CommandType = CommandType.StoredProcedure;
                AddParents.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherLName", tb_FatherLName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherMName", tb_FatherMName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherFName", tb_FatherFName.Text));
<<<<<<< HEAD
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherSuffix", tb_FatherFName.Text));
=======
<<<<<<< HEAD
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherSuffix", tb_FatherFName.Text));
=======
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                AddParents.Parameters.Add(new SqlParameter("@EmpMotherMaidLName", tb_MotherMdLName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpMotherMaidMName", tb_MotherMdMName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpMotherFName", tb_MotherFName.Text));
                AddParents.ExecuteNonQuery();
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
        private void AddNationality() {
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            try
            {
                conn.Open();
                SqlCommand ChooseNatl = new SqlCommand("SelectNationality", conn);
                ChooseNatl.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseNatl);
                ChooseNatl.ExecuteNonQuery();
                DataTable dtNatlity = new DataTable();
                testcon.Fill(dtNatlity);
                cb_Nationality.DataSource = dtNatlity;
                cb_Nationality.DisplayMember = "Nationality";
                cb_Nationality.ValueMember = "Nationality";
            }
            finally
            {
                conn.Close();
            }
    }
        private void AddSpouseDetails() {
            try
            {
                conn.Open();
                SqlCommand AddSpouse = new SqlCommand("SPInsertEmpSpouse", conn);
                AddSpouse.CommandType = CommandType.StoredProcedure;
                AddSpouse.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@spouseTIN", tb_spouseTIN.Text ));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseEmpTIN", tb_SpouseEmpTIN.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseLName", tb_SpouseLName.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseMName", tb_SpouseMName.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseFName", tb_SpouseFName.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseSuffix", tb_SpouseSuffix.Text));
                AddSpouse.ExecuteNonQuery();
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
<<<<<<< HEAD

=======
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        private void selectCompany() {
            try
            {
                conn.Open();
<<<<<<< HEAD
                string query = @"SELECT CmpCode FROM dbo.Company WHERE CmpCode= 'MGM'";
=======
<<<<<<< HEAD
                string query = @"SELECT CmpCode FROM dbo.Company WHERE CmpCode= ""MGM""";
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
                SqlCommand cmdCompany = new SqlCommand(query, conn);
                SqlDataReader reader = cmdCompany.ExecuteReader();

                while (reader.Read()) {
                    tb_company.Text = (reader["CmpCode"].ToString());
                }

                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }   // OK
        private void selectCivilStat() {
            try
            {
                conn.Open();
                string stat = "SELECT CivilStatus FROM dbo.CivilStatus WITH(INDEX(byCStatNo))";
                SqlCommand ChooseStatus = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseStatus);
                ChooseStatus.ExecuteNonQuery();
                DataTable dtCStatus = new DataTable();
                testcon.Fill(dtCStatus);
                cb_CivilStat.DataSource = dtCStatus;
                cb_CivilStat.DisplayMember = "CivilStatus";
                cb_CivilStat.ValueMember = "CivilStatus";
            }
            finally
            {
                conn.Close();
            }
        }   // OK
        private void IncrementIDSeries() {        
            try
            {
                conn.Open();
                SqlCommand IDSeries = new SqlCommand("AutoIncrementIDs", conn);
                IDSeries.CommandType = CommandType.StoredProcedure;
                IDSeries.Parameters.Add(new SqlParameter("@CmpCode", tb_company.Text));
                IDSeries.Parameters.Add(new SqlParameter("@CmpGrpCd", cb_grpofcom.Text));
                IDSeries.Parameters.Add(new SqlParameter("@CmpBranchcode", cb_officebranch.Text));
                IDSeries.Parameters.Add("@retID", SqlDbType.VarChar, 17).Direction = ParameterDirection.Output;
                IDSeries.ExecuteNonQuery();
                getID = (string)IDSeries.Parameters["@retID"].Value;
                tb_EmployeeID.Text = getID;            
            }
            finally
            {
                conn.Close();
            }  
        }  // OK
        private void SelectCmpGrp() {
            try
            {
                conn.Open();
                string stat = "SELECT CmpGrpCd, CmpGrpName FROM dbo.CompanyGroup";
                SqlCommand ChooseCmpGrp = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpGrp);
                ChooseCmpGrp.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
                
                testcon.Fill(dtCmpGrp);
                DataRow insertRow = dtCmpGrp.NewRow();
                cb_grpofcom.SelectedIndex = -1;
                cb_grpofcom.DisplayMember = "CmpGrpCd";
                cb_grpofcom.ValueMember = "CmpGrpCd";
                cb_grpofcom.DataSource = dtCmpGrp;
            }
            finally
            {
                conn.Close();
            }
        } // OK
        private void AddPicture() {
            try
            {              
                byte[] photo = GetPhoto(imagePath);
                conn.Open();
                SqlCommand AddPic = new SqlCommand("SPInsertEmployeePic", conn);
                AddPic.CommandType = CommandType.StoredProcedure;
                AddPic.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddPic.Parameters.Add(new SqlParameter("@picture", photo));
                AddPic.ExecuteNonQuery();
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
        public static byte[] GetPhoto(string filepath)
        {
            FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return photo;
        }

        private void SelectCmpBranch()
        {
            try
            {
                conn.Open();
                string query = "SELECT CmpBranchcode, CompBrName FROM dbo.CompanyBranches";
                SqlCommand ChooseCmpBr = new SqlCommand(query, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpBr);
                ChooseCmpBr.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
                testcon.Fill(dtCmpGrp);
                cb_officebranch.DataSource = dtCmpGrp;
                cb_officebranch.DisplayMember = "CmpBranchcode";
                cb_officebranch.ValueMember = "CmpBranchcode";
            }
            finally
            {
                conn.Close();
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ClearVal();
            this.Refresh();
            PicBox_Pic.Image = null;
            selectCompany();
            ((Control)this.groupie).Enabled = true;          
            //tb_EmployeeID.Text += "Processing...";
            tb_EmployeeID.Text += tb_company.Text;
        }

        private void ClearVal() {
            PsonalInfo.Enabled = true;
            CntactInfo.Enabled = true;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
=======
            ((Control)this.btnBottom).Enabled = true;          
           // tb_EmployeeID.Text += "Processing...";
            tb_EmployeeID.Text += tb_company.Text;
        }

>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        private void cb_grpofcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_EmployeeID.Text = "";
            tb_EmployeeID.Text = tb_company.Text + "-" + cb_grpofcom.Text;
        }

        private void cb_grpofcom_Click(object sender, EventArgs e)
        {
            SelectCmpGrp();
        }

        private void cb_officebranch_Click(object sender, EventArgs e)
        {
            SelectCmpBranch();
        }

        private void cb_officebranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_EmployeeID.Text = "";
            tb_EmployeeID.Text = tb_company.Text + "-" + cb_grpofcom.Text + "-" + cb_officebranch.Text;
        }

        private void GetID() {
            try
            {
                conn.Open();             
            }
<<<<<<< HEAD
            finally {
                conn.Close();
=======
            finally { 
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
            }
        }
        private void AddEmpContactDetails() {
            try
            {
                conn.Open();
                SqlCommand addContactDetails = new SqlCommand("SPInsertEmployeeContactDetails", conn);
                addContactDetails.CommandType = CommandType.StoredProcedure;
                addContactDetails.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@PTelNo", tb_Ptel.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@PCellNo", tb_Pcel.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@PEmailAdd", tb_PEmail.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@CtactPEgency", tb_ctEmergency.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@CtactPAdd", tbCtPersonAdd.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@CtPsonNo", tb_CtPrsonNo.Text ));
                addContactDetails.Parameters.Add(new SqlParameter("@BTelNo", tb_Btel.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@BCellNo", tb_BCell.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@BEmailAdd", tb_BEmail.Text));
                addContactDetails.ExecuteNonQuery();
            }
            finally {
                conn.Close();
            }
        }
        private void PassDTAddresstoSQL()
        {
            dgvAddress.Rows[0].Cells[0].Value = tb_EmployeeID.Text;
            dgvAddress.Rows[1].Cells[0].Value = tb_EmployeeID.Text;

            try
            {
                conn.Open();
                SqlCommand addAddress = new SqlCommand("InsertEmpAddress", conn);
                addAddress.CommandType = CommandType.StoredProcedure;
                addAddress.Parameters.Add(new SqlParameter("@EmpAddresses", dtSetAddresses));
                addAddress.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        } // OK

        private void PassDTChildtoSQL() { 
            for (int i = 0; i < dgvChild.Rows.Count; ++i) {
                dgvChild.Rows[i].Cells[0].Value = tb_EmployeeID.Text;        
            }
            try
            {
                conn.Open();
                SqlCommand addChildDet = new SqlCommand("InsertEmpChildren", conn);
                addChildDet.CommandType = CommandType.StoredProcedure;
                addChildDet.Parameters.Add(new SqlParameter("@EmpChildren", dtChild));
                addChildDet.ExecuteNonQuery();
            }
            finally {
                conn.Close();
            }
        }
        private void PassDTEducBackgroundtoSQL()
        {
            for (int i = 0; i < dgvEduc.Rows.Count; ++i)
            {
                dgvEduc.Rows[i].Cells[0].Value = tb_EmployeeID.Text;
            }
            try
            {
                conn.Open();
                SqlCommand addEducDet = new SqlCommand("InsertEmpEducBckgrnd", conn);
                addEducDet.CommandType = CommandType.StoredProcedure;
                addEducDet.Parameters.Add(new SqlParameter("@EmpEducBckg", dtEduc));
                addEducDet.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
          //      string query = "INSERT INTO Departments(DeptCd,DeptName,DeptHead) VALUES(@DeptCd,@DeptName,@DeptHead)";
            }
        }
<<<<<<< HEAD
        private void AddEmploymentInfo() {
            try
            {
                conn.Open();
                SqlCommand addEmpdetails = new SqlCommand("SPInsertEmpInfo", conn);
                addEmpdetails.CommandType = CommandType.StoredProcedure;
                addEmpdetails.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@CompanyCode", tb_company.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@GrpofComp", cb_grpofcom.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@CmpBranch", cb_officebranch.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@EmployeeStatus", cb_EStatus.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@DeptCd", cb_dept.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@HiringDate", tbHiredDate.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@EffectiveDate", tbEffectiveDate.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@ExitDate", tbExitDate.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@Position", tb_position.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@Supervisor", cb_supervisor.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@FormofPayment", cb_paymentterms.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@Bank", cb_bank.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@BankAcctNo", tb_bankAcctNo.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@PaymentTerms", cb_paymentterms.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@firstpayday",cb_1pay.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@secondpayday", cb_2pay.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@salaryamt", tb_salary.Text));
                addEmpdetails.Parameters.Add(new SqlParameter("@currency", cbCurrency.Text));
                addEmpdetails.ExecuteNonQuery();
            }
            finally {
                conn.Close();
            }
        }
        private void writeStdardSchedMaster() {
            try
            {
                conn.Open();
                string query = "INSERT INTO EmployeeSchedMaster(EmployeeID,EmployeeTSID,FlexiorStdard) VALUES(@EmployeeID,@EmployeeTSIDs,@FlexiorStdard)";
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                ins.Parameters.Add(new SqlParameter("@EmployeeTSIDs", tb_TSid.Text));
                ins.Parameters.Add(new SqlParameter("@FlexiorStdard", WorkHrType));
                ins.ExecuteNonQuery();
            }
            finally {
                conn.Close();
            }
        }
        private void writeSchedDet()
        {
            try
            {
                conn.Open();
                SqlCommand ins = new SqlCommand("InsertEmpSched", conn);
                ins.CommandType = CommandType.StoredProcedure;
                ins.Parameters.Add(new SqlParameter("@EmpSchedule", dtStandard));
                ins.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion SQLaddingofEmployeeTables
    
=======
        #endregion SQLaddingofEmployeeTables
        #region printingOfID
        private void btnPrint_Click(object sender, EventArgs e)
        {
            GenerateID form = new GenerateID();
            form.EmployeeID = tb_EmployeeID.Text;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
        #endregion printingOfID
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
        private void dt_ExitDate_ValueChanged(object sender, EventArgs e)
        {
            tbExitDate.Text = dt_ExitDate.Value.Date.ToShortDateString();
        }

        private void dt_datejoined_ValueChanged(object sender, EventArgs e)
        {
            tbHiredDate.Text = dt_datejoined.Value.Date.ToShortDateString();
        }

        private void dt_EffectiveDate_ValueChanged(object sender, EventArgs e)
        {
            tbEffectiveDate.Text = dt_EffectiveDate.Value.Date.ToShortDateString();
        }

        private void chbStandrdorFlex_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStandrdorFlex.Checked == true)
            {
                groupBox9.Enabled = true;
<<<<<<< HEAD
                groupBox8.Enabled = false;
                WorkHrType = "F";
                AddColSchedule();
                AddRowstoSchedule();
            }
            else {
                groupBox9.Enabled = false;
                groupBox8.Enabled = true;
                WorkHrType = "S";
            }
        }
        private void regularscheddetail()
        {
            dtStandard.Clear();
            dtStandard.Columns.Add("EmployeeTSID", typeof(Int32));
            dtStandard.Columns.Add("DateEntry", typeof(DateTime));
            dtStandard.Columns.Add("workingdays", typeof(String));
            dtStandard.Columns.Add("startWorkhr", typeof(TimeSpan));
            dtStandard.Columns.Add("endWorkhr", typeof(TimeSpan));

            if (chbMontoFri.Checked == true)
            {
               // writeStdardSchedMaster();
                var noOfWkDays = Enum.GetNames(typeof(Days)).Length;
                if (chbMontoFri.Checked == true)
                {
                //    for (int i = 0; i <= noOfWkDays; i++)
                  //  {
                        //      dtStandard.Rows.Add(tb_EmployeeID.Text,Enum.GetNames(typeof(Days)),cbStartTime.Text,cbEndTime.Text);
                        //   }
                        //}  */
                        DataRow newrow = null;
                        foreach (Days _days in Enum.GetValues(typeof(Days))) {            
                        //_days.ToString();
                        newrow = dtStandard.NewRow();
                        DateTime dStart01 = DateTime.Parse(cbStartTime.Text);
                        DateTime dStart02 = DateTime.Parse(cbEndTime.Text);
                        TimeSpan dStart1 = dStart01.TimeOfDay;
                        TimeSpan dStart2 = dStart02.TimeOfDay;
                        int TSid = Int32.Parse(tb_TSid.Text);
                        newrow["EmployeeTSID"] = TSid;// TSID;
                        newrow["DateEntry"] = DBNull.Value;
                        newrow["workingdays"] = _days.ToString();
                        newrow["startWorkhr"] = dStart1;//timeStrt;
                        newrow["endWorkhr"] = dStart2;//timeEnd;
                        dtStandard.Rows.Add(newrow);
                        // dtStandard.Rows.Add(tb_EmployeeID.Text,workingDay,cbStartTime.Text,cbEndTime.Text);
                    }
                }
            }
        }     
       

        private void chbMontoFri_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMontoFri.Checked == true) {
                chbMon.Checked      = true;
                chbTue.Checked      = true;
                chbWed.Checked      = true;
                chbThurs.Checked    = true;
                chbFri.Checked      = true;
                chbSat.Enabled      = false;
                chbSun.Enabled      = false;
            }
            else if (chbMontoFri.Checked == false) {
                chbMon.Checked      = false;
                chbTue.Checked      = false;
                chbWed.Checked      = false;
                chbThurs.Checked    = false;
                chbFri.Checked      = false;
                chbSat.Enabled      = true;
                chbSun.Enabled      = true;
            }
        }    

        private void addinitDate_Click(object sender, EventArgs e)
        {
            addInitDate.Visible = false;
            tbDate.Text = "";
           // tbDate.Text = schedCaL.SelectionEnd.ToShortDateString();
            date1 = schedCaL.SelectionEnd;
            dayOfdate = date1.DayOfWeek.ToString();
            dgvSchedule.Rows[0].Cells[1].Value = date1.ToShortDateString();
            dgvSchedule.Rows[0].Cells[2].Value = dayOfdate;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            date1 = schedCaL.SelectionEnd;
            string selectedDate = date1.ToShortDateString();
            dayOfdate = date1.DayOfWeek.ToString();
            dtSched.Rows.Add("",selectedDate, dayOfdate);
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            tbDate.Text = "";
        }

        private void dt_bdate_ValueChanged(object sender, EventArgs e)
        {
            tbBdate.Text = dt_bdate.Value.Date.ToShortDateString();
        }

       
        #region Navigation Buttons
        private void btnTop_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            nw.Rows.Clear();
            nw.Columns.Clear();
            string qq = @"SELECT * FROM dbo.EmployeeMaster";
            SqlCommand nextRec = new SqlCommand(qq, conn);
           // SqlCommand prevRec = new SqlCommand(qq, conn);          
            //nextRec.CommandType = CommandType.StoredProcedure;                        
            ShowDTable();
            try
            {
                conn.Open();
                nw.Load(nextRec.ExecuteReader());
                i = rowIndex;
                    DateTime bdays = Convert.ToDateTime(nw.Rows[0].Table.Rows[0]["birthdate"].ToString()).Date;
                    string brthday = bdays.ToShortDateString();
                    tb_EmployeeID.Text = (nw.Rows[0].Table.Rows[0]["EmployeeID"].ToString());
                    tb_LName.Text = (nw.Rows[0].Table.Rows[0]["EmpLName"].ToString());
                    tb_FName.Text = (nw.Rows[0].Table.Rows[0]["EmpFName"].ToString());
                    tb_MName.Text = (nw.Rows[0].Table.Rows[0]["EmpMName"].ToString());
                    tb_Suffix.Text = (nw.Rows[0].Table.Rows[0]["EmpSuffix"].ToString());
                    tbBdate.Text = brthday;
                    tbBPlace.Text = (nw.Rows[0].Table.Rows[0]["birthplace"].ToString());
                    cb_sex.Text = (nw.Rows[0].Table.Rows[0]["sex"].ToString());
                    cb_Nationality.Text = (nw.Rows[0].Table.Rows[0]["Nationality"].ToString());
                    cb_CivilStat.Text = (nw.Rows[0].Table.Rows[0]["CivilStatus"].ToString());
                    tb_SSS.Text = (nw.Rows[0].Table.Rows[0]["EmpSSS"].ToString());
                    tb_TIN.Text = (nw.Rows[0].Table.Rows[0]["EmpTIN"].ToString());
                    tb_pagibig.Text = (nw.Rows[0].Table.Rows[0]["EmpPagibigID"].ToString());
                    tb_PHealth.Text = (nw.Rows[0].Table.Rows[0]["EmpPhilhealthID"].ToString());
                    cb_INScode.Text = (nw.Rows[0].Table.Rows[0]["HealthINSCd"].ToString());
                    tb_INSName.Text = (nw.Rows[0].Table.Rows[0]["HealthINSName"].ToString());
                    tb_insID.Text = (nw.Rows[0].Table.Rows[0]["HealthInsID"].ToString());
                    string child = nw.Rows[0].Table.Rows[0]["withchild"].ToString();
                    if (child == "True")
                    {
                        chb_withChild.Checked = true;
                    }
                    else
                    {
                        chb_withChild.Checked = false;
                    }                   
                   // DisplayAddressNext();
            }
            finally
            {
                utilsClass.Disposing(nw,nextRec,conn);
                //conn.Close();
                DisplayAddress();
                DisplayPic();
                DisplayingContactDetils();
                DisplayEmpInfo();
                DisplaySpouseandParent();
                DisplayChild();
                DisplayEducBck();
            }            
        }
        private void btnBottom_Click(object sender, EventArgs e)
        {
            nw.Rows.Clear();
            nw.Columns.Clear();
            String qq = @"SELECT * FROM dbo.EmployeeMaster ORDER BY EmployeeID DESC";
            SqlCommand lastRec = new SqlCommand(qq, conn);
            //nextRec.CommandType = CommandType.StoredProcedure;
            ShowDTable();
            try
            {
                conn.Open();
                nw.Load(lastRec.ExecuteReader());
                //DataRow last = nw.Rows[nw.Rows.Count-1];
                i = rowIndex;
                DateTime bdays = Convert.ToDateTime(nw.Rows[0].Table.Rows[0]["birthdate"].ToString()).Date;
                string brthday = bdays.ToShortDateString();
                tb_EmployeeID.Text = (nw.Rows[0].Table.Rows[0]["EmployeeID"].ToString());
                tb_LName.Text = (nw.Rows[0].Table.Rows[0]["EmpLName"].ToString());
                tb_FName.Text = (nw.Rows[0].Table.Rows[0]["EmpFName"].ToString());
                tb_MName.Text = (nw.Rows[0].Table.Rows[0]["EmpMName"].ToString());
                tb_Suffix.Text = (nw.Rows[0].Table.Rows[0]["EmpSuffix"].ToString());
                tbBdate.Text = brthday;
                tbBPlace.Text = (nw.Rows[0].Table.Rows[0]["birthplace"].ToString());
                cb_sex.Text = (nw.Rows[0].Table.Rows[0]["sex"].ToString());
                cb_Nationality.Text = (nw.Rows[0].Table.Rows[0]["Nationality"].ToString());
                cb_CivilStat.Text = (nw.Rows[0].Table.Rows[0]["CivilStatus"].ToString());
                tb_SSS.Text = (nw.Rows[0].Table.Rows[0]["EmpSSS"].ToString());
                tb_TIN.Text = (nw.Rows[0].Table.Rows[0]["EmpTIN"].ToString());
                tb_pagibig.Text = (nw.Rows[0].Table.Rows[0]["EmpPagibigID"].ToString());
                tb_PHealth.Text = (nw.Rows[0].Table.Rows[0]["EmpPhilhealthID"].ToString());
                cb_INScode.Text = (nw.Rows[0].Table.Rows[0]["HealthINSCd"].ToString());
                tb_INSName.Text = (nw.Rows[0].Table.Rows[0]["HealthINSName"].ToString());
                tb_insID.Text = (nw.Rows[0].Table.Rows[0]["HealthInsID"].ToString());
                string child = nw.Rows[0].Table.Rows[0]["withchild"].ToString();
                if (child == "True")
                {
                    chb_withChild.Checked = true;
                }
                else
                {
                    chb_withChild.Checked = false;
                }
            }
            finally
            {
                utilsClass.Disposing(nw,lastRec,conn);
                //lastRec.Dispose();
                //conn.Close();
                DisplayAddress();
                DisplayPic();
                DisplayingContactDetils();
                DisplayEmpInfo();
                DisplaySpouseandParent();
                DisplayChild();
                DisplayEducBck();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {         
            nw.Rows.Clear();
            nw.Columns.Clear();
            string qq = @"SELECT * FROM dbo.EmployeeMaster";
            //SqlCommand nextRec = new SqlCommand("GetNextEmployee", conn);           
            //nextRec.CommandType = CommandType.StoredProcedure;
            SqlCommand nextRec = new SqlCommand(qq, conn);
            try
            {
                conn.Open();
                nw.Load(nextRec.ExecuteReader());
                // int dd = nw.Rows[0].Table.Rows.Count;
                int a = nw.Rows.IndexOf(nw.Rows[0]);
                if (a <= nw.Rows[0].Table.Rows.Count)
                {
                    i++;
                    DateTime bdays = Convert.ToDateTime(nw.Rows[0].Table.Rows[i]["birthdate"].ToString()).Date;
                    string brthday = bdays.ToShortDateString();
                    tb_EmployeeID.Text = (nw.Rows[0].Table.Rows[i]["EmployeeID"].ToString());
                    tb_LName.Text = (nw.Rows[0].Table.Rows[i]["EmpLName"].ToString());
                    tb_FName.Text = (nw.Rows[0].Table.Rows[i]["EmpFName"].ToString());
                    tb_MName.Text = (nw.Rows[0].Table.Rows[i]["EmpMName"].ToString());
                    tb_Suffix.Text = (nw.Rows[0].Table.Rows[i]["EmpSuffix"].ToString());
                    tbBdate.Text = brthday;
                    tbBPlace.Text = (nw.Rows[0].Table.Rows[i]["birthplace"].ToString());
                    cb_sex.Text = (nw.Rows[0].Table.Rows[i]["sex"].ToString());
                    cb_Nationality.Text = (nw.Rows[0].Table.Rows[i]["Nationality"].ToString());
                    cb_CivilStat.Text = (nw.Rows[0].Table.Rows[i]["CivilStatus"].ToString());
                    tb_SSS.Text = (nw.Rows[0].Table.Rows[i]["EmpSSS"].ToString());
                    tb_TIN.Text = (nw.Rows[0].Table.Rows[i]["EmpTIN"].ToString());
                    tb_pagibig.Text = (nw.Rows[0].Table.Rows[i]["EmpPagibigID"].ToString());
                    tb_PHealth.Text = (nw.Rows[0].Table.Rows[i]["EmpPhilhealthID"].ToString());
                    cb_INScode.Text = (nw.Rows[0].Table.Rows[i]["HealthINSCd"].ToString());
                    tb_INSName.Text = (nw.Rows[0].Table.Rows[i]["HealthINSName"].ToString());
                    tb_insID.Text = (nw.Rows[0].Table.Rows[i]["HealthInsID"].ToString());
                    string child = (nw.Rows[0].Table.Rows[i]["withchild"].ToString());
                    if (child == "True")
                    {
                        chb_withChild.Checked = true;
                    }
                    else
                    {
                        chb_withChild.Checked = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Last Record Encountered!");
            }
            finally
            {
                utilsClass.Disposing(nw,nextRec,conn);
                //conn.Close();
                DisplayAddress();
                DisplayPic();
                DisplayingContactDetils();
                DisplayEmpInfo();
                DisplaySpouseandParent();
                DisplayChild();
                DisplayEducBck();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            nw.Rows.Clear();
            nw.Columns.Clear();
            string qq = @"SELECT * FROM dbo.EmployeeMaster";
            //SqlCommand nextRec = new SqlCommand("GetNextEmployee", conn);           
            //nextRec.CommandType = CommandType.StoredProcedure;
            SqlCommand prevRec = new SqlCommand(qq, conn);
            try
            {
                conn.Open();
                nw.Load(prevRec.ExecuteReader());
                int ia = nw.Rows.IndexOf(nw.Rows[0]);
                if (ia < nw.Rows[0].Table.Rows.Count - 1)
                {
                    i--;
                    DateTime bdays = Convert.ToDateTime(nw.Rows[0].Table.Rows[i]["birthdate"].ToString()).Date;
                    string brthday = bdays.ToShortDateString();
                    tb_EmployeeID.Text = (nw.Rows[0].Table.Rows[i]["EmployeeID"].ToString());
                    tb_LName.Text = (nw.Rows[0].Table.Rows[i]["EmpLName"].ToString());
                    tb_FName.Text = (nw.Rows[0].Table.Rows[i]["EmpFName"].ToString());
                    tb_MName.Text = (nw.Rows[0].Table.Rows[i]["EmpMName"].ToString());
                    tb_Suffix.Text = (nw.Rows[0].Table.Rows[i]["EmpSuffix"].ToString());
                    tbBdate.Text = brthday;
                    tbBPlace.Text = (nw.Rows[0].Table.Rows[i]["birthplace"].ToString());
                    cb_sex.Text = (nw.Rows[0].Table.Rows[i]["sex"].ToString());
                    cb_Nationality.Text = (nw.Rows[0].Table.Rows[i]["Nationality"].ToString());
                    cb_CivilStat.Text = (nw.Rows[0].Table.Rows[i]["CivilStatus"].ToString());
                    tb_SSS.Text = (nw.Rows[0].Table.Rows[i]["EmpSSS"].ToString());
                    tb_TIN.Text = (nw.Rows[0].Table.Rows[i]["EmpTIN"].ToString());
                    tb_pagibig.Text = (nw.Rows[0].Table.Rows[i]["EmpPagibigID"].ToString());
                    tb_PHealth.Text = (nw.Rows[0].Table.Rows[i]["EmpPhilhealthID"].ToString());
                    cb_INScode.Text = (nw.Rows[0].Table.Rows[i]["HealthINSCd"].ToString());
                    tb_INSName.Text = (nw.Rows[0].Table.Rows[i]["HealthINSName"].ToString());
                    tb_insID.Text = (nw.Rows[0].Table.Rows[i]["HealthInsID"].ToString());
                    string child = (nw.Rows[0].Table.Rows[i]["withchild"].ToString());
                    if (child == "True")
                    {
                        chb_withChild.Checked = true;
                    }
                    else
                    {
                        chb_withChild.Checked = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("First Record Encountered!");
            }
            //}
            finally
            {
                utilsClass.Disposing(nw,prevRec,conn);
                //conn.Close();
                DisplayAddress();
                DisplayPic();
                DisplayingContactDetils();
                DisplayEmpInfo();
                DisplaySpouseandParent();
                DisplayChild();
                DisplayEducBck();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GenerateID form = new GenerateID();
            form.EmployeeID = tb_EmployeeID.Text;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
        #endregion Navigation Buttons
        #region ViewingMode

        private void ViewModeEmployee()
        {
            //  string queryEmp = "SELECT * FROM dbo.Employees";
            PsonalInfo.Enabled = false;
            CntactInfo.Enabled = false;
            SqlCommand viewing = new SqlCommand("GetNextEmployee", conn);
            viewing.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();

                using (SqlDataReader view = viewing.ExecuteReader())
                {
                    
                    while (view.Read())
                    {
                      //  dts.Load(view);
                        //DataRow[] result1 = dts.Select("EmployeeID = '" + tb_EmployeeID.Text + "'");
                        /* string bdates = (view["birthdate"].ToString());
                         DateTime bdays = DateTime.Parse(bdates);
                         string brthday = bdays.ToShortDateString(); */
                        DateTime bdays = Convert.ToDateTime(view["birthdate"].ToString()).Date;
                        string brthday = bdays.ToShortDateString();
                        tb_EmployeeID.Text = (view["EmployeeID"].ToString());
                        tb_LName.Text = (view["EmpLName"].ToString());
                        tb_FName.Text = (view["EmpFName"].ToString());
                        tb_MName.Text = (view["EmpMName"].ToString());
                        tb_Suffix.Text = (view["EmpSuffix"].ToString());
                        tbBdate.Text = brthday;
                        tbBPlace.Text = (view["birthplace"].ToString());
                        cb_sex.Text = (view["sex"].ToString());
                        cb_Nationality.Text = (view["Nationality"].ToString());
                        cb_CivilStat.Text = (view["CivilStatus"].ToString());
                        tb_SSS.Text = (view["EmpSSS"].ToString());
                        tb_TIN.Text = (view["EmpTIN"].ToString());
                        tb_pagibig.Text = (view["EmpPagibigID"].ToString());
                        tb_PHealth.Text = (view["EmpPhilhealthID"].ToString());
                        cb_INScode.Text = (view["HealthINSCd"].ToString());
                        tb_INSName.Text = (view["HealthINSName"].ToString());
                        tb_insID.Text = (view["HealthInsID"].ToString());
                        string child = (view["withchild"].ToString());
                        if (child == "True")
                        {
                            chb_withChild.Checked = true;
                        }
                        else
                        {
                            chb_withChild.Checked = false;
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
                DisplayAddress();
                DisplayPic();
                DisplayingContactDetils();
                DisplayEmpInfo();
                DisplaySpouseandParent();
                DisplayChild();
                DisplayEducBck();
            }
        }

        private void DisplayAddress() {
                string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
                var conn = new SqlConnection(constr);
                tbAddress.Clear();
                dgvAddress.Visible = false;
                dgvAddViewing.Visible = true;
                String query = @"SELECT EmployeeID, AddressType, UnitNoBldgName, LotBlkNos,Street,subdivision,BrgyDistr,CityMunicipal,Province,Country,Zipcode FROM dbo.EmployeeAddress WHERE EmployeeID = @EmployeeID";
                SqlCommand nt = new SqlCommand(query, conn);
                SqlParameter par = new SqlParameter();
                par.ParameterName = "@EmployeeID";
                par.Value = tb_EmployeeID.Text;
                nt.Parameters.Add(par);
                try
                {
                    conn.Open();                   
                    tbAddress.Load(nt.ExecuteReader());
                    dgvAddViewing.DataSource = tbAddress;
                    dgvAddViewing.Columns[0].Visible = false;
                }
                catch(SqlException e){
                    MessageBox.Show(e.Message);
                }
                finally {
                    utilsClass.Disposing(tbAddress, nt, conn);
                   // conn.Close();
                }
        }

        private void DisplayPic() {
            var constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(@constr);
            PicBox_Pic.Image = null;
            string query = @"SELECT picture FROM dbo.EmployeePictures WHERE EmployeeID = '"+tb_EmployeeID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = 0;
             //Int32 ordinal = 0;
            //byte[] outbyte = new byte[100];
            try {
                conn.Open();
                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "picture");
                count = ds.Tables["picture"].Rows.Count;
                
                if (count > 0)
                {
                    var data = (Byte[])(ds.Tables["picture"].Rows[count - 1]["picture"]);
                    {
                        var stream = new MemoryStream(data);
                        PicBox_Pic.Image = Image.FromStream(stream);
                    }
                }
                else {
                    PicBox_Pic.Image = null;
                }
            }
            catch (SqlException e) {
                MessageBox.Show(e.Message +" "+ e.StackTrace);
            }
             
            finally {
                conn.Close();
            }
        }

        private void DisplayingContactDetils() {
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            string que = @"SELECT * FROM dbo.EmployeeContactDetails WHERE EmployeeID = '"+tb_EmployeeID.Text+"'";
            SqlCommand cmd = new SqlCommand(que, conn);
            try {
                conn.Open();
                using (SqlDataReader see = cmd.ExecuteReader()) {
                    while (see.Read()) {
                        tb_Ptel.Text = (see["PTelNo"].ToString());
                        tb_Pcel.Text = (see["PCellNo"].ToString());
                        tb_PEmail.Text = (see["PEmailAdd"].ToString());
                        tb_ctEmergency.Text = (see["CtactPEgency"].ToString());
                        tbCtPersonAdd.Text = (see["CtactPAdd"].ToString());
                        tb_CtPrsonNo.Text = (see["CtPsonNo"].ToString());
                        tb_Btel.Text = (see["BTelNo"].ToString());
                        tb_BCell.Text = (see["BCellNo"].ToString());
                        tb_BEmail.Text = (see["BEmailAdd"].ToString());
                    }
                }
            }
            catch (SqlException e) {
                MessageBox.Show(e.Message+" "+e.StackTrace);
            }
            finally {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void DisplayEmpInfo() {
            var constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            string qq = @"SELECT * FROM dbo.EmployeeEmploymentInfo WHERE EmployeeID = '"+tb_EmployeeID.Text+"'";
            SqlCommand cmd = new SqlCommand(qq, conn);
            try {
                conn.Open();
                using (SqlDataReader view = cmd.ExecuteReader()){
                    while(view.Read()) {
                        tb_company.Text = (view["CompanyCode"].ToString());
                        cb_EStatus.Text = (view["EmployeeStatus"].ToString());
                        tbHiredDate.Text = (view["HiringDate"].ToString());
                        tbEffectiveDate.Text = (view["EffectiveDate"].ToString());
                        tbExitDate.Text = (view["ExitDate"].ToString());
                        cb_dept.Text = (view["DeptCd"].ToString());
                        tb_position.Text = (view["Position"].ToString());
                        cb_grpofcom.Text = (view["GrpofComp"].ToString());
                        cb_officebranch.Text = (view["CmpBranch"].ToString());
                        cb_supervisor.Text = (view["Supervisor"].ToString());
                        cb_formpayment.Text = (view["FormofPayment"].ToString());
                        cb_bank.Text = (view["Bank"].ToString());
                        tb_bankAcctNo.Text = (view["BankAcctNo"].ToString());
                        cb_paymentterms.Text = (view["PaymentTerms"].ToString());
                        cb_1pay.Text = (view["firstpayday"].ToString());
                        cb_2pay.Text = (view["secondpayday"].ToString());
                        tb_salary.Text = (view["salaryamt"].ToString());
                        cbCurrency.Text = (view["currency"].ToString());
                    }                
                }
            }
            catch(SqlException e){
                MessageBox.Show(e.Message);
            }
            finally {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void DisplaySpouseandParent() {
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            string qq = @"SELECT EmployeeMaster.EmployeeID, EmployeeParents.EmpFatherFName, EmployeeParents.EmpFatherLName, EmployeeParents.EmpFatherMName, EmployeeParents.EmpFatherSuffix,
	                    EmployeeParents.EmpMotherFName, EmployeeParents.EmpMotherMaidMName, EmployeeParents.EmpMotherMaidLName,
	                    EmployeeSpouse.SpouseLname, EmployeeSpouse.SpouseFname, EmployeeSpouse.SpouseMname, EmployeeSpouse.SpouseSuffix, EmployeeSpouse.spouseTIN, EmployeeSpouse.SpouseEmpTIN FROM dbo.EmployeeMaster
	                    LEFT OUTER JOIN dbo.EmployeeParents ON EmployeeMaster.EmployeeID = EmployeeParents.EmployeeID
	                    LEFT OUTER JOIN dbo.EmployeeSpouse ON EmployeeMaster.EmployeeID = EmployeeSpouse.EmployeeID
                        WHERE EmployeeMaster.EmployeeID = '"+tb_EmployeeID.Text+"'";
            SqlCommand cmd = new SqlCommand(qq, conn);
            try {
                conn.Open();
                using(SqlDataReader view = cmd.ExecuteReader()) {
                    while(view.Read()) {
                        tb_FatherLName.Text = view["EmpFatherLName"].ToString();
                        tb_FatherFName.Text = view["EmpFatherFName"].ToString();
                        tb_FatherMName.Text = view["EmpFatherMName"].ToString();
                        tb_FatherSuffix.Text = view["EmpFatherSuffix"].ToString();
                        tb_MotherFName.Text = view["EmpMotherFName"].ToString();
                        tb_MotherMdMName.Text = view["EmpMotherMaidMName"].ToString();
                        tb_MotherMdLName.Text = view["EmpMotherMaidLName"].ToString();
                        tb_SpouseLName.Text = view["SpouseLname"].ToString();
                        tb_SpouseFName.Text = view["SpouseFname"].ToString();
                        tb_SpouseMName.Text = view["SpouseMname"].ToString();
                        tb_SpouseSuffix.Text = view["SpouseSuffix"].ToString();
                        tb_spouseTIN.Text = view["spouseTIN"].ToString();
                        tb_SpouseEmpTIN.Text = view["SpouseEmpTIN"].ToString();                  
                  }
                }
            }
            catch (SqlException e){
                MessageBox.Show(e.Message+" "+e.StackTrace);
            }
            finally {
                cmd.Dispose();
                conn.Close();
            }
        }
        private void DisplayChild() {
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            dtChild2.Clear();
            dgvChild.Visible = false;
            dgvChild1.Visible = true;
            string qq = @"SELECT childLname, childFName, childMName, childSuffix, childbday FROM dbo.EmployeeChildren WHERE EmployeeID = '"+tb_EmployeeID.Text+"'";
            SqlCommand cmd = new SqlCommand(qq, conn);           
            try {
                conn.Open();          
                dtChild2.Load(cmd.ExecuteReader());
                dgvChild1.DataSource = dtChild2;
                //dgvChild1.Columns[0].Visible = false;                                       
                }   
         
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally {
                cmd.Dispose();
                conn.Close();
            }
        }
        private void DisplayEducBck() {
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            dtEducation.Clear();
            dgvEduc.Visible = false;
            dgvEducation.Visible = true;
            string que = @"SELECT * FROM dbo.EmployeeEducBckgrnd WHERE EmployeeID = '"+tb_EmployeeID.Text+"'";
            SqlCommand cmd = new SqlCommand(que, conn);            
            try {
                conn.Open();
                dtEducation.Load(cmd.ExecuteReader());
                dgvEducation.DataSource = dtEducation;
                dgvEducation.Columns[0].Visible = false;
            }
            catch(SqlException e) {
                MessageBox.Show(e.Message +" "+ e.StackTrace);
            }
            finally {
                cmd.Dispose();
                conn.Close();
            }
        }

        #endregion ViewingMode

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // var forms = new EmployeeEntry();
            var form = new SearchEmployee();         
            //Hide();
            this.Opacity = 0;
            form.StartPosition = FormStartPosition.CenterParent; 
            form.ShowDialog();
            this.Opacity = 1;         
        }
        public void SearchResult(string empID) {    
            //process empID
            nw.Rows.Clear();
            nw.Columns.Clear();
            tb_EmployeeID.Text = empID;
            string qq = @"SELECT * FROM dbo.EmployeeMaster WHERE EmployeeID='"+tb_EmployeeID.Text+"'";
            SqlCommand viewing = new SqlCommand(qq, conn);
            try
            {
                conn.Open();
                using (SqlDataReader view = viewing.ExecuteReader())
                {
                    while (view.Read())
                    {
                        /* string bdates = (view["birthdate"].ToString());
                         DateTime bdays = DateTime.Parse(bdates);
                         string brthday = bdays.ToShortDateString(); */
                        DateTime bdays = Convert.ToDateTime(view["birthdate"].ToString()).Date;
                        string brthday = bdays.ToShortDateString();
                        tb_EmployeeID.Text = (view["EmployeeID"].ToString());
                        tb_LName.Text = (view["EmpLName"].ToString());
                        tb_FName.Text = (view["EmpFName"].ToString());
                        tb_MName.Text = (view["EmpMName"].ToString());
                        tb_Suffix.Text = (view["EmpSuffix"].ToString());
                        tbBdate.Text = brthday;
                        tbBPlace.Text = (view["birthplace"].ToString());
                        cb_sex.Text = (view["sex"].ToString());
                        cb_Nationality.Text = (view["Nationality"].ToString());
                        cb_CivilStat.Text = (view["CivilStatus"].ToString());
                        tb_SSS.Text = (view["EmpSSS"].ToString());
                        tb_TIN.Text = (view["EmpTIN"].ToString());
                        tb_pagibig.Text = (view["EmpPagibigID"].ToString());
                        tb_PHealth.Text = (view["EmpPhilhealthID"].ToString());
                        cb_INScode.Text = (view["HealthINSCd"].ToString());
                        tb_INSName.Text = (view["HealthINSName"].ToString());
                        tb_insID.Text = (view["HealthInsID"].ToString());
                        string child = (view["withchild"].ToString());
                        if (child == "True")
                        {
                            chb_withChild.Checked = true;
                        }
                        else
                        {
                            chb_withChild.Checked = false;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
            finally {
                conn.Close();
                DisplayAddress();
                DisplayPic();
                DisplayingContactDetils();
                DisplayEmpInfo();
                DisplaySpouseandParent();
                DisplayChild();
                DisplayEducBck();
            }
        }
        private void findRowIndex() {
            
            System.Text.StringBuilder b = new System.Text.StringBuilder();
            foreach (System.Data.DataRow r in dts.Rows)
            {
                foreach (System.Data.DataColumn c in dts.Columns)
                {
                    b.Append(c.ColumnName.ToString() + ":" + r[c.ColumnName].ToString());
                }
            }
            MessageBox.Show(b.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // dts = ClassUtils.GetData();
            ShowDTable();
        }

        private void SST() {
            string searchstring = tb_EmployeeID.Text;
        }

        //Evaluate Index when search
        private void ShowDTable()
        {
           // int index = 0;
            string constr = ConfigurationManager.ConnectionStrings["connectStr"].ConnectionString;
            var conn = new SqlConnection(constr);
            string qq = "SELECT * FROM EmployeeMaster ORDER BY EmployeeID";
            SqlCommand cmd = new SqlCommand(qq, conn);
          //  cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dss = new SqlDataAdapter(cmd);
    
            try
            {
                conn.Open();
                dss.Fill(dts);

                DataRow[] result = dts.Select("EmployeeID = '"+tb_EmployeeID.Text+"'");
                if (result.Length > 0)
                {
                    rowIndex = dts.Rows.IndexOf(result[0]);// / 4;
                }
                MessageBox.Show(rowIndex.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
=======
            }
            else {
                groupBox9.Enabled = false;
            }
        }
        private void ViewModeEmployee() {
            //string queryEmp = "SELECT * FROM dbo.Employees";
        }
       
=======
<<<<<<< HEAD

                string query = @"SELECT CmpCode FROM dbo.Company WHERE CmpCode= ""MGM""";
                SqlCommand cmdCompany = new SqlCommand(query, conn);
                SqlDataReader reader = cmdCompany.ExecuteReader();

                while (reader.Read()) {
                    tb_company.Text = (reader["CmpCode"].ToString());
                }

                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }   // OK
        private void selectCivilStat() {
            try
            {
                conn.Open();
                string stat = "SELECT CivilStatus FROM dbo.CivilStatus WITH(INDEX(byCStatNo))";
                SqlCommand ChooseStatus = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseStatus);
                ChooseStatus.ExecuteNonQuery();
                DataTable dtCStatus = new DataTable();
                testcon.Fill(dtCStatus);
                cb_CivilStat.DataSource = dtCStatus;
                cb_CivilStat.DisplayMember = "CivilStatus";
                cb_CivilStat.ValueMember = "CivilStatus";
            }
            finally
            {
                conn.Close();
            }
        }   // OK
        private void IncrementIDSeries() {        
            try
            {
                conn.Open();
                SqlCommand IDSeries = new SqlCommand("AutoIncrementIDs", conn);
                IDSeries.CommandType = CommandType.StoredProcedure;
                IDSeries.Parameters.Add(new SqlParameter("@CmpCode", tb_company.Text));
                IDSeries.Parameters.Add(new SqlParameter("@CmpGrpCd", cb_grpofcom.Text));
                IDSeries.Parameters.Add(new SqlParameter("@CmpBranchcode", cb_officebranch.Text));
                IDSeries.Parameters.Add("@retID", SqlDbType.VarChar, 17).Direction = ParameterDirection.Output;
                IDSeries.ExecuteNonQuery();
                getID = (string)IDSeries.Parameters["@retID"].Value;
                tb_EmployeeID.Text = getID;            
            }
            finally
            {
                conn.Close();
            }  
        }  // OK
        private void SelectCmpGrp() {
            try
            {
                conn.Open();
                string stat = "SELECT CmpGrpCd, CmpGrpName FROM dbo.CompanyGroup";
                SqlCommand ChooseCmpGrp = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpGrp);
                ChooseCmpGrp.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
                
                testcon.Fill(dtCmpGrp);
                DataRow insertRow = dtCmpGrp.NewRow();
                cb_grpofcom.SelectedIndex = -1;
                cb_grpofcom.DisplayMember = "CmpGrpCd";
                cb_grpofcom.ValueMember = "CmpGrpCd";
                cb_grpofcom.DataSource = dtCmpGrp;
            }
            finally
            {
                conn.Close();
            }
        } // OK
        private void AddPicture() {
            try
            {
                string picUrl = PicBox_Pic.ImageLocation;
                byte[] photo = GetPhoto(picUrl);
                conn.Open();
                SqlCommand AddPic = new SqlCommand("SPInsertEmployeePic", conn);
                AddPic.CommandType = CommandType.StoredProcedure;
                AddPic.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddPic.Parameters.Add(new SqlParameter("@picture", photo));
                AddPic.ExecuteNonQuery();
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
        public static byte[] GetPhoto(string filepath)
        {
            FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return photo;
        }

        private void SelectCmpBranch()
        {
            try
            {
                conn.Open();
                string query = "SELECT CmpBranchcode, CompBrName FROM dbo.CompanyBranches";
                SqlCommand ChooseCmpBr = new SqlCommand(query, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpBr);
                ChooseCmpBr.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
                testcon.Fill(dtCmpGrp);
                cb_officebranch.DataSource = dtCmpGrp;
                cb_officebranch.DisplayMember = "CmpBranchcode";
                cb_officebranch.ValueMember = "CmpBranchcode";
            }
            finally
            {
                conn.Close();
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((Control)this.tabEmployees).Enabled = true;
            this.btnAdd.Visible = false;
           // tb_EmployeeID.Text += "Processing...";
            tb_EmployeeID.Text += tb_company.Text;
        }

        private void cb_grpofcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_EmployeeID.Text = "";
            tb_EmployeeID.Text = tb_company.Text + "-" + cb_grpofcom.Text;
        }

        private void cb_grpofcom_Click(object sender, EventArgs e)
        {
            SelectCmpGrp();
        }

        private void cb_officebranch_Click(object sender, EventArgs e)
        {
            SelectCmpBranch();
        }

        private void cb_officebranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_EmployeeID.Text = "";
            tb_EmployeeID.Text = tb_company.Text + "-" + cb_grpofcom.Text + "-" + cb_officebranch.Text;
        }

        private void GetID() {
            try
            {
                conn.Open();
               
            }
            finally { 
            }
        }

        private void PassDTAddresstoSQL() {
            dgvAddress.Rows[0].Cells[0].Value = tb_EmployeeID.Text;
            dgvAddress.Rows[1].Cells[0].Value = tb_EmployeeID.Text;

            try
            {
                conn.Open();
                SqlCommand addAddress = new SqlCommand("InsertEmpAddress", conn);
                addAddress.CommandType = CommandType.StoredProcedure;
                addAddress.Parameters.Add(new SqlParameter("@EmpAddresses", dtSetAddresses));
                addAddress.ExecuteNonQuery();
            }
            finally {
                conn.Close();
            }
        } // OK

        private void AddEmpContactDetails() {
            try
            {
                conn.Open();
                SqlCommand addContactDetails = new SqlCommand("SPInsertEmployeeContactDetails", conn);
                addContactDetails.CommandType = CommandType.StoredProcedure;
                addContactDetails.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@PTelNo", tb_Ptel.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@PCellNo", tb_Pcel.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@PEmailAdd", tb_PEmail.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@CtactPEgency", tb_ctEmergency.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@CtPsonNo", tb_CtPrsonNo.Text ));
                addContactDetails.Parameters.Add(new SqlParameter("@BTelNo", tb_Btel.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@BCellNo", tb_BCell.Text));
                addContactDetails.Parameters.Add(new SqlParameter("@BEmailAdd", tb_BEmail.Text));
                addContactDetails.ExecuteNonQuery();
            }
            finally {
                conn.Close();
            }
        }
=======

                string query = @"SELECT CmpCode FROM dbo.Company WHERE CmpCode= ""MGM"" WITH(NOLOCK)";
                SqlCommand cmdCompany = new SqlCommand(query, conn);
                SqlDataReader reader = cmdCompany.ExecuteReader();

                while (reader.Read()) {
                    tb_company.Text = (reader["CmpCode"].ToString());
                }

                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
        private void selectCivilStat() {
            try
            {
                conn.Open();
                string stat = "SELECT CivilStatus FROM dbo.CivilStatus WITH(INDEX(byCStatNo) NOLOCK)";
                SqlCommand ChooseStatus = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseStatus);
                ChooseStatus.ExecuteNonQuery();
                DataTable dtCStatus = new DataTable();
                testcon.Fill(dtCStatus);
                cb_CivilStat.DataSource = dtCStatus;
                cb_CivilStat.DisplayMember = "CivilStatus";
                cb_CivilStat.ValueMember = "CivilStatus";
            }
            finally
            {
                conn.Close();
            }
        }
        private void IncrementIDSeries() {        
            try
            {
                conn.Open();
                SqlCommand IDSeries = new SqlCommand("AutoIncrementIDs", conn);
                IDSeries.CommandType = CommandType.StoredProcedure;
                IDSeries.Parameters.Add(new SqlParameter("@CmpCode", tb_company.Text));
                IDSeries.Parameters.Add(new SqlParameter("@CmpGrpCd", cb_grpofcom.Text));
                IDSeries.Parameters.Add(new SqlParameter("@CmpBranchcode", cb_officebranch.Text));
<<<<<<< HEAD
                IDSeries.Parameters.Add("@retID", SqlDbType.VarChar, 17).Direction = ParameterDirection.Output;
                IDSeries.ExecuteNonQuery();
                getID = (string)IDSeries.Parameters["@retID"].Value;
                tb_EmployeeID.Text = getID;            
=======
                IDSeries.ExecuteNonQuery();
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
            }
            finally
            {
                conn.Close();
            }  
        }
        private void SelectCmpGrp() {
            try
            {
                conn.Open();
<<<<<<< HEAD
                string stat = "SELECT CmpGrpCd, CmpGrpName FROM dbo.CompanyGroup";
=======
                string stat = "SELECT CmpGrpCd, CmpGrpName FROM dbo.CompanyGroup WITH(NOLOCK)";
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
                SqlCommand ChooseCmpGrp = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpGrp);
                ChooseCmpGrp.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
<<<<<<< HEAD
                
                testcon.Fill(dtCmpGrp);
                DataRow insertRow = dtCmpGrp.NewRow();
                cb_grpofcom.SelectedIndex = -1;
                cb_grpofcom.DisplayMember = "CmpGrpCd";
                cb_grpofcom.ValueMember = "CmpGrpCd";
                cb_grpofcom.DataSource = dtCmpGrp;
=======
                testcon.Fill(dtCmpGrp);
                cb_grpofcom.DataSource = dtCmpGrp;
                cb_grpofcom.DisplayMember = "CmpGrpCd";
                cb_grpofcom.ValueMember = "CmpGrpCd";
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
            }
            finally
            {
                conn.Close();
            }
        }
        private void AddPicture() {
            try
            {
                string picUrl = PicBox_Pic.ImageLocation;
                byte[] photo = GetPhoto(picUrl);
                conn.Open();
                SqlCommand AddPic = new SqlCommand("SPInsertEmployeePic", conn);
                AddPic.CommandType = CommandType.StoredProcedure;
                AddPic.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddPic.Parameters.Add(new SqlParameter("@picture", photo));
<<<<<<< HEAD
=======

>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
                AddPic.ExecuteNonQuery();
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
<<<<<<< HEAD
        public static byte[] GetPhoto(string filepath)
        {
=======

        private void SelectCmpBranch()
        {
            try
            {
                conn.Open();
                string query = "SELECT CmpBranchcode, CompBrName FROM dbo.CompanyBranches WITH(NOLOCK)";
                SqlCommand ChooseCmpBr = new SqlCommand(query, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpBr);
                ChooseCmpBr.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
                testcon.Fill(dtCmpGrp);
                cb_officebranch.DataSource = dtCmpGrp;
                cb_officebranch.DisplayMember = "CmpBranchcode";
                cb_officebranch.ValueMember = "CmpBranchcode";
            }
            finally
            {
                conn.Close();
            }
        }
        public static byte[] GetPhoto(string filepath) {
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
            FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();
            return photo;
<<<<<<< HEAD
        }

        private void SelectCmpBranch()
        {
            try
            {
                conn.Open();
                string query = "SELECT CmpBranchcode, CompBrName FROM dbo.CompanyBranches WITH(NOLOCK)";
                SqlCommand ChooseCmpBr = new SqlCommand(query, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseCmpBr);
                ChooseCmpBr.ExecuteNonQuery();
                DataTable dtCmpGrp = new DataTable();
                testcon.Fill(dtCmpGrp);
                cb_officebranch.DataSource = dtCmpGrp;
                cb_officebranch.DisplayMember = "CmpBranchcode";
                cb_officebranch.ValueMember = "CmpBranchcode";
            }
            finally
            {
                conn.Close();
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((Control)this.tabEmployees).Enabled = true;
            this.btnAdd.Visible = false;
           // tb_EmployeeID.Text += "Processing...";
            tb_EmployeeID.Text += tb_company.Text;
        }

        private void cb_grpofcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_EmployeeID.Text = "";
            tb_EmployeeID.Text = tb_company.Text + "-" + cb_grpofcom.Text;
        }

        private void cb_grpofcom_Click(object sender, EventArgs e)
        {
            SelectCmpGrp();
        }

        private void cb_officebranch_Click(object sender, EventArgs e)
        {
            SelectCmpBranch();
        }

        private void cb_officebranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_EmployeeID.Text = "";
            tb_EmployeeID.Text = tb_company.Text + "-" + cb_grpofcom.Text + "-" + cb_officebranch.Text;
        }

        private void GetID() {
            try
            {
                conn.Open();
               
            }

            finally { 
            }
        }
        
        private void dgvAddress_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                DataRow addAddress = null;
                foreach (DataGridViewRow row in dgvAddress.Rows) {
                    addAddress = dtSetAddresses.NewRow();
                    addAddress["AddressType"] = row.Cells["AddressType"].Value;
                    addAddress[""]
                    dtSetAddresses.Rows.Add(addAddress);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
      
      
=======

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((Control)this.tabEmployees).Enabled = true;
            this.btnAdd.Visible = false;
            tb_EmployeeID.Text += "Processing...";
        }
=======
        #endregion Employee Entry Comboboxes                        
<<<<<<< HEAD
    

=======
<<<<<<< HEAD
    

=======
<<<<<<< HEAD
    
=======

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tb_SSSid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void tb__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                PicBox_Pic.Image = new Bitmap(open.FileName);              
            } 
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
        private void AddEmployeeMaster() {
            try
            {
                conn.Open();
                SqlCommand InsertEmployeeMasteer = new SqlCommand("SPInsertMasterEmployee", conn);
                InsertEmployeeMasteer.CommandType = CommandType.StoredProcedure;
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpID", tb_EmployeeID.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpFName", tb_FName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpMName", tb_MName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpLName", tb_LName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSuffix", tb_Suffix.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@birthdate", dt_bdate.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@CivilStatus", cb_CivilStat.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@Nationality", cb_Nationality.Text));
<<<<<<< HEAD
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@sex", cb_sex.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpTIN", tb_TIN.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSSS", tb_SSS.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpPagibigID", tb_pagibig.Text));
=======
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpTIN", tb_TIN.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpSSS", tb_SSS.Text));
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@EmpPhilhealthID", tb_PHealth.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthINSCd", cb_INScode.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthINSName", tb_INSName.Text));
                InsertEmployeeMasteer.Parameters.Add(new SqlParameter("@HealthInsID", tb_insID.Text));

<<<<<<< HEAD
                InsertEmployeeMasteer.ExecuteNonQuery();
            }
            finally
            {            
                conn.Close();
            }  
        }       
        private void AddEmpParents() {
            try
            {
                conn.Open();
                SqlCommand AddParents = new SqlCommand("SPInsertEmpParents", conn);
                AddParents.CommandType = CommandType.StoredProcedure;
                AddParents.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherLName", tb_FatherLName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherMName", tb_FatherMName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpFatherFName", tb_FatherFName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpMotherMaidLName", tb_MotherMdLName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpMotherMaidMName", tb_MotherMdMName.Text));
                AddParents.Parameters.Add(new SqlParameter("@EmpMotherFName", tb_MotherFName.Text));
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
=======
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
            }
            finally
            {
                conn.Close();
<<<<<<< HEAD
            }
=======
            }  
        }

        private void AddEmployeeParents() { 
            
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
        }
        private void AddNationality() {

            try
            {
                conn.Open();
                SqlCommand ChooseNatl = new SqlCommand("SelectNationality", conn);
                ChooseNatl.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseNatl);
                ChooseNatl.ExecuteNonQuery();
<<<<<<< HEAD
                DataTable dtNatlity = new DataTable();
                testcon.Fill(dtNatlity);
                cb_Nationality.DataSource = dtNatlity;
                cb_Nationality.DisplayMember = "Nationality";
                cb_Nationality.ValueMember = "Nationality";
=======
                DataSet dtNatlity = new DataSet();
                testcon.Fill(dtNatlity);
                cb_Nationality.DataSource = dtNatlity.Tables[0];
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
            }
            finally
            {
                conn.Close();
            }
    }
<<<<<<< HEAD
        private void AddSpouseDetails() {
            try
            {
                conn.Open();
                SqlCommand AddSpouse = new SqlCommand("SPInsertEmpSpouse", conn);
                AddSpouse.CommandType = CommandType.StoredProcedure;
                AddSpouse.Parameters.Add(new SqlParameter("@EmployeeID", tb_EmployeeID.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@spouseTIN", tb_spouseTIN.Text ));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseEmpTIN", tb_SpouseEmpTIN.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseLName", tb_SpouseLName.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseMName", tb_SpouseMName.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseFName", tb_SpouseFName.Text));
                AddSpouse.Parameters.Add(new SqlParameter("@SpouseSuffix", tb_SpouseSuffix.Text));
     
                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
        private void selectCompany() {
            try
            {
                conn.Open();

                string query = @"SELECT CmpCode FROM dbo.Company WHERE CmpCode= ""MGM"" WITH(NOLOCK)";
                SqlCommand cmdCompany = new SqlCommand(query, conn);
                SqlDataReader reader = cmdCompany.ExecuteReader();

                while (reader.Read()) {
                    tb_company.Text = (reader["CmpCode"].ToString());
                }

                //  ChoosePic.Parameters.Add(new SqlParameter("@picture", tb_EmployeeID.Text));
            }
            finally
            {
                conn.Close();
            }
        }
        private void selectCivilStat() {
            try
            {
                conn.Open();
                string stat = "SELECT CivilStatus FROM dbo.CivilStatus WITH(INDEX(byCStatNo) NOLOCK)";
                SqlCommand ChooseStatus = new SqlCommand(stat, conn);
                SqlDataAdapter testcon = new SqlDataAdapter(ChooseStatus);
                ChooseStatus.ExecuteNonQuery();
                DataTable dtCStatus = new DataTable();
                testcon.Fill(dtCStatus);
                cb_CivilStat.DataSource = dtCStatus;
                cb_CivilStat.DisplayMember = "CivilStatus";
                cb_CivilStat.ValueMember = "CivilStatus";
            }
            finally
            {
                conn.Close();
            }
=======
=======
        

     

       
>>>>>>> d4de6728625338ac75e2e0219699a2c8800feaa1

        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                PicBox_Pic.Image = new Bitmap(open.FileName);              
            } 
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
        }

>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
       
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
>>>>>>> 97601d51e6adeb8a230356318568d731d2fc7e94
>>>>>>> 4931e3070da34a7dd584433511cdd3dec2f876a3
    }
}