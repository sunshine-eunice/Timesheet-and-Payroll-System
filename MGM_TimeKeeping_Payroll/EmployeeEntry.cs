﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace MGM_TimeKeeping_Payroll
{
    public partial class EmployeeEntry : Form
    {
        public const string con = @"Data Source=MGMITM02;Initial Catalog=Test1;Persist Security Info=True;User ID=sa; Password=1234";
        public EmployeeEntry()
        {
            InitializeComponent();
            AddComboBoxesItems();

        }
        //public _companygrp CompGrp { get; set; }

        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            Datepickers();
            cb_bank.Enabled = false;
            tb_company.Text = "MGM";      
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tb_age.Clear();
            DateTime today = DateTime.Today;
            DateTime byear = dt_bdate.Value.Date;
            int c = ComputeAge(today.Year, byear.Year);
            tb_age.Text += c;
        }
        #region DatePickers Settings
        private void Datepickers()
        {
            dt_bdate.Format = DateTimePickerFormat.Custom;
            dt_datejoined.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dategrad.Format = DateTimePickerFormat.Custom;
            dategrad.CustomFormat = "MM/dd/yyyy";
            dt_bdate.CustomFormat = "MM/dd/yyyy";
            dt_datejoined.CustomFormat = "MM/dd/yyyy";
            dateTimePicker3.CustomFormat = "MM/dd/yyyy";
            dateTimePicker4.CustomFormat = "MM/dd/yyyy";
        }
        #endregion DatePicker Settings
        #region ComputeAge
        public int ComputeAge(int present_yr, int birth_yr)
        {
            int n = present_yr - birth_yr;
            return n;
        }
        #endregion ComputeAge

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {           
            SqlConnection conn = new SqlConnection(con);     
            string query = "INSERT INTO Employee_Profile (company, employee_corp, office_branch, Employee_LName, Employee_MName, Employee_FName, birthdate, date_hired, date_start, date_left, employee_status, employee_SSSID, employee_phlhealthID, employee_tin_ID, employee_hdmfID, gender, Nationality, civilstatus, noofchildren, schoolgraduated, dategraduated, highestEducLvl, employee_SSSID, employee_hdmfID, employee_tin_ID) VALUES (@company, @employee_corp, @office_branch, @Employee_LName, @Employee_MName, @Employee_FName, @birthdate, @date_joined, @date_left, @employee_status, @employee_SSSID, @employee_phlhealthID, @employee_tin_ID, @employee_hdmfID, @gender, @Nationality, @civilstatus, @noofchildren, @schoolgraduated, @dategraduated, @highestEducLvl, @employee_SSSID, @employee_hdmfID, @employee_tin_ID)";
            try
            {
                conn.Open();
                SqlCommand querysave_EmPfile = new SqlCommand(query, conn);
                querysave_EmPfile.Parameters.Add("@company", SqlDbType.VarChar, 3).Value = tb_company.Text;
                querysave_EmPfile.Parameters.Add("@employee_corp", SqlDbType.VarChar, 50).Value = cb_grpofcom.Text;
                querysave_EmPfile.Parameters.Add("@office_branch", SqlDbType.VarChar, 4).Value = cb_officebranch.Text;
                querysave_EmPfile.Parameters.Add("@Employee_LName", SqlDbType.VarChar, 50).Value = tb_LName.Text;
                querysave_EmPfile.Parameters.Add("@Employee_MName", SqlDbType.VarChar, 50).Value = tb_MName.Text;
                querysave_EmPfile.Parameters.Add("@Employee_FName", SqlDbType.VarChar, 4).Value = tb_FName.Text;
                querysave_EmPfile.Parameters.Add("@birthdate", SqlDbType.Date).Value = dt_bdate;
                querysave_EmPfile.Parameters.Add("@date_hired", SqlDbType.Date).Value = dt_bdate;
                querysave_EmPfile.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }           
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
            #region Personal Info
            //Gender
            cb_gender.Items.Add(new ComboBoxItem("0","Male"));
            cb_gender.Items.Add(new ComboBoxItem("1", "Female"));

            //Civil Status
            cb_CivilStat.Items.Add(new ComboBoxItem("0","Single"));
            cb_CivilStat.Items.Add(new ComboBoxItem("1", "Married"));
            cb_CivilStat.Items.Add(new ComboBoxItem("2", "Widowed"));
            cb_CivilStat.Items.Add(new ComboBoxItem("3", "Annulled"));

            //Highes Educ Level
            cb_higheduclvl.Items.Add(new ComboBoxItem("0","High School"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("1", "Bachelor Degree"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("2","Vocational"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("3","Master's Degree"));
            cb_higheduclvl.Items.Add(new ComboBoxItem("4","Doctorate Degree"));
            #endregion Personal Info
            #region Employment Info
            //Company Grps
            cb_grpofcom.Items.Add(new ComboBoxItem("0", "Foods"));
            cb_grpofcom.Items.Add(new ComboBoxItem("1", "Blendwell"));
            cb_grpofcom.Items.Add(new ComboBoxItem("2", "Premium Beverages"));

            //Employee Status
            cb_EStatus.Items.Add(new ComboBoxItem("0","Casual"));
            cb_EStatus.Items.Add(new ComboBoxItem("1", "Probationary"));
            cb_EStatus.Items.Add(new ComboBoxItem("2","Regular"));
            cb_EStatus.Items.Add(new ComboBoxItem("3", "Permanent"));
            cb_EStatus.Items.Add(new ComboBoxItem("4", "Resigned"));
            cb_EStatus.Items.Add(new ComboBoxItem("5", "Terminated"));
            cb_EStatus.Items.Add(new ComboBoxItem("6", "Regular"));
            cb_EStatus.Items.Add(new ComboBoxItem("7", "Retired"));

            //Office Branch
            cb_officebranch.Items.Add(new ComboBoxItem("0", "CAV"));
            cb_officebranch.Items.Add(new ComboBoxItem("1", "MAND"));

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
        #endregion Employee Entry Comboboxes            

    }
}