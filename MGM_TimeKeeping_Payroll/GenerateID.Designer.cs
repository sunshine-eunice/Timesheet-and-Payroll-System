namespace MGM_TimeKeeping_Payroll
{
    partial class GenerateID
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
            this.reportEmployee = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportEmployee
            // 
            this.reportEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportEmployee.LocalReport.ReportEmbeddedResource = "";
            this.reportEmployee.LocalReport.ReportPath = "";
            this.reportEmployee.Location = new System.Drawing.Point(0, 0);
            this.reportEmployee.Name = "reportEmployee";
            this.reportEmployee.Size = new System.Drawing.Size(980, 437);
            this.reportEmployee.TabIndex = 0;
            // 
            // samplereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 437);
            this.Controls.Add(this.reportEmployee);
            this.Name = "samplereport";
            this.Text = "samplereport";
            this.Load += new System.EventHandler(this.samplereport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEmployee;
    }
}