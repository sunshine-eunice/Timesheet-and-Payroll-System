namespace MGM_TimeKeeping_Payroll
{
    partial class SearchEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.rbEmpID = new System.Windows.Forms.RadioButton();
            this.rbLName = new System.Windows.Forms.RadioButton();
            this.tbSearchbox = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvDispRec = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.EmpCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.rbFName = new System.Windows.Forms.RadioButton();
            this.btnClr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispRec)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(99, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by:";
            // 
            // rbEmpID
            // 
            this.rbEmpID.AutoSize = true;
            this.rbEmpID.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbEmpID.Location = new System.Drawing.Point(177, 10);
            this.rbEmpID.Name = "rbEmpID";
            this.rbEmpID.Size = new System.Drawing.Size(97, 20);
            this.rbEmpID.TabIndex = 1;
            this.rbEmpID.TabStop = true;
            this.rbEmpID.Text = "Employee ID";
            this.rbEmpID.UseVisualStyleBackColor = true;
            // 
            // rbLName
            // 
            this.rbLName.AutoSize = true;
            this.rbLName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbLName.Location = new System.Drawing.Point(280, 10);
            this.rbLName.Name = "rbLName";
            this.rbLName.Size = new System.Drawing.Size(86, 20);
            this.rbLName.TabIndex = 2;
            this.rbLName.TabStop = true;
            this.rbLName.Text = "Last Name";
            this.rbLName.UseVisualStyleBackColor = true;
            // 
            // tbSearchbox
            // 
            this.tbSearchbox.Location = new System.Drawing.Point(34, 35);
            this.tbSearchbox.Name = "tbSearchbox";
            this.tbSearchbox.Size = new System.Drawing.Size(430, 20);
            this.tbSearchbox.TabIndex = 4;
            this.tbSearchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchbox_KeyDown);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(505, 33);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(45, 24);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(48, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvDispRec
            // 
            this.dgvDispRec.AllowUserToAddRows = false;
            this.dgvDispRec.AllowUserToDeleteRows = false;
            this.dgvDispRec.AllowUserToResizeRows = false;
            this.dgvDispRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDispRec.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDispRec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDispRec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDispRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispRec.Location = new System.Drawing.Point(8, 63);
            this.dgvDispRec.Name = "dgvDispRec";
            this.dgvDispRec.ReadOnly = true;
            this.dgvDispRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDispRec.RowHeadersVisible = false;
            this.dgvDispRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDispRec.Size = new System.Drawing.Size(621, 225);
            this.dgvDispRec.TabIndex = 0;
            this.dgvDispRec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDispRec_CellDoubleClick);
            this.dgvDispRec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDispRec_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.EmpCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(637, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "MGMFCC";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "||";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel3.Text = "Search Result : ";
            // 
            // EmpCount
            // 
            this.EmpCount.Name = "EmpCount";
            this.EmpCount.Size = new System.Drawing.Size(64, 17);
            this.EmpCount.Text = "EmpCount";
            // 
            // rbFName
            // 
            this.rbFName.AutoSize = true;
            this.rbFName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbFName.Location = new System.Drawing.Point(368, 10);
            this.rbFName.Name = "rbFName";
            this.rbFName.Size = new System.Drawing.Size(88, 20);
            this.rbFName.TabIndex = 3;
            this.rbFName.TabStop = true;
            this.rbFName.Text = "First Name";
            this.rbFName.UseVisualStyleBackColor = true;
            // 
            // btnClr
            // 
            this.btnClr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClr.BackgroundImage")));
            this.btnClr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClr.Location = new System.Drawing.Point(465, 34);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(25, 21);
            this.btnClr.TabIndex = 8;
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 314);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvDispRec);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbSearchbox);
            this.Controls.Add(this.rbFName);
            this.Controls.Add(this.rbLName);
            this.Controls.Add(this.rbEmpID);
            this.Controls.Add(this.label1);
            this.Name = "SearchEmployee";
            this.Text = "SearchEmployee";
            this.Load += new System.EventHandler(this.SearchEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispRec)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEmpID;
        private System.Windows.Forms.RadioButton rbLName;
        private System.Windows.Forms.TextBox tbSearchbox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvDispRec;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel EmpCount;
        private System.Windows.Forms.RadioButton rbFName;
        private System.Windows.Forms.Button btnClr;
    }
}