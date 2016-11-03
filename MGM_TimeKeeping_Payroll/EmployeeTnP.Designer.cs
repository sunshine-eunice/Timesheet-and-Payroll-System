namespace MGM_TimeKeeping_Payroll
{
    partial class EmployeeTnP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_EmName = new System.Windows.Forms.TextBox();
            this.btn_timesheet = new System.Windows.Forms.Button();
            this.dgv_Timesheet = new System.Windows.Forms.DataGridView();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_workhrs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MinsOfLate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_clrtimesheet = new System.Windows.Forms.Button();
            this.btn_procpayroll = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpick_from = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpick_to = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Timesheet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Name:";
            // 
            // tb_EmName
            // 
            this.tb_EmName.Location = new System.Drawing.Point(128, 166);
            this.tb_EmName.Name = "tb_EmName";
            this.tb_EmName.Size = new System.Drawing.Size(265, 20);
            this.tb_EmName.TabIndex = 8;
            // 
            // btn_timesheet
            // 
            this.btn_timesheet.Location = new System.Drawing.Point(145, 264);
            this.btn_timesheet.Name = "btn_timesheet";
            this.btn_timesheet.Size = new System.Drawing.Size(108, 35);
            this.btn_timesheet.TabIndex = 11;
            this.btn_timesheet.Text = "Upload Timesheet";
            this.btn_timesheet.UseVisualStyleBackColor = true;
            this.btn_timesheet.Click += new System.EventHandler(this.btn_timesheet_Click);
            // 
            // dgv_Timesheet
            // 
            this.dgv_Timesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Timesheet.Location = new System.Drawing.Point(431, 40);
            this.dgv_Timesheet.Name = "dgv_Timesheet";
            this.dgv_Timesheet.Size = new System.Drawing.Size(505, 292);
            this.dgv_Timesheet.TabIndex = 13;
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(129, 210);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(199, 20);
            this.tb_filename.TabIndex = 17;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(334, 210);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(59, 23);
            this.btn_browse.TabIndex = 18;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Work Hours:";
            // 
            // tb_workhrs
            // 
            this.tb_workhrs.Location = new System.Drawing.Point(669, 356);
            this.tb_workhrs.Name = "tb_workhrs";
            this.tb_workhrs.ReadOnly = true;
            this.tb_workhrs.Size = new System.Drawing.Size(267, 20);
            this.tb_workhrs.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Lates:";
            // 
            // tb_MinsOfLate
            // 
            this.tb_MinsOfLate.Location = new System.Drawing.Point(669, 382);
            this.tb_MinsOfLate.Name = "tb_MinsOfLate";
            this.tb_MinsOfLate.ReadOnly = true;
            this.tb_MinsOfLate.Size = new System.Drawing.Size(267, 20);
            this.tb_MinsOfLate.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Undertime:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(669, 408);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(267, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total Overtime:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(669, 434);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(267, 20);
            this.textBox4.TabIndex = 26;
            // 
            // btn_clrtimesheet
            // 
            this.btn_clrtimesheet.Location = new System.Drawing.Point(259, 264);
            this.btn_clrtimesheet.Name = "btn_clrtimesheet";
            this.btn_clrtimesheet.Size = new System.Drawing.Size(108, 35);
            this.btn_clrtimesheet.TabIndex = 27;
            this.btn_clrtimesheet.Text = "Clear Timesheet";
            this.btn_clrtimesheet.UseVisualStyleBackColor = true;
            this.btn_clrtimesheet.Click += new System.EventHandler(this.btn_clrtimesheet_Click);
            // 
            // btn_procpayroll
            // 
            this.btn_procpayroll.Location = new System.Drawing.Point(790, 481);
            this.btn_procpayroll.Name = "btn_procpayroll";
            this.btn_procpayroll.Size = new System.Drawing.Size(146, 35);
            this.btn_procpayroll.TabIndex = 28;
            this.btn_procpayroll.Text = "Proceed to Payroll >>";
            this.btn_procpayroll.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cut-off Period:";
            // 
            // dtpick_from
            // 
            this.dtpick_from.Location = new System.Drawing.Point(129, 40);
            this.dtpick_from.Name = "dtpick_from";
            this.dtpick_from.Size = new System.Drawing.Size(148, 20);
            this.dtpick_from.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "to:";
            // 
            // dtpick_to
            // 
            this.dtpick_to.Location = new System.Drawing.Point(129, 66);
            this.dtpick_to.Name = "dtpick_to";
            this.dtpick_to.Size = new System.Drawing.Size(148, 20);
            this.dtpick_to.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "File Path:";
            // 
            // EmployeeTnP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 547);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpick_to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpick_from);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_procpayroll);
            this.Controls.Add(this.btn_clrtimesheet);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_MinsOfLate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_workhrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.dgv_Timesheet);
            this.Controls.Add(this.btn_timesheet);
            this.Controls.Add(this.tb_EmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeTnP";
            this.Text = "MGM Foods & Commodities Corp. Timesheet and Payroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Timesheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_EmName;
        private System.Windows.Forms.Button btn_timesheet;
        private System.Windows.Forms.DataGridView dgv_Timesheet;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_workhrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MinsOfLate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_clrtimesheet;
        private System.Windows.Forms.Button btn_procpayroll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpick_from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpick_to;
        private System.Windows.Forms.Label label9;
    }
}

