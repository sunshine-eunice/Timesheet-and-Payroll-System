﻿using System;
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
    public partial class EmployeeEntry : Form
    {
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
        public EmployeeEntry()
        {
            InitializeComponent();
            AddComboBoxesItems();
            AddNationality();
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
        }
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
        {
            this.Close();
        }

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
            }
            finally
            {
                conn.Close();
            }           
>>>>>>> 248da7df2486e9285878699750accbde23eae2a0
>>>>>>> e97b49bfc4155e002f2373e3e2da611d948a1c4a
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
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
>>>>>>> 14ad7b7a91c349b24b4efebdd7ebda92aa325318
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
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
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD

>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
        #endregion Employee Entry Comboboxes                        

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
        
>>>>>>> c7dda9f23b8cb9b4005d6cade16f8ebfc32f0a18
>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
            finally
            {            
                conn.Close();
            }  
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

>>>>>>> 2536f86dc0442618af86a0c7b8e2ad35682d5456
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
        private void selectCompany() {
            try
            {
                conn.Open();
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
    }
}