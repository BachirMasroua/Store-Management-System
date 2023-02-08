namespace Store_Management_System
{
    partial class SalesReportForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonDailyReport = new System.Windows.Forms.Button();
            this.buttonMonthlyReport = new System.Windows.Forms.Button();
            this.Profit = new System.Windows.Forms.Label();
            this.Investment = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(109, 129);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 1;
            // 
            // buttonDailyReport
            // 
            this.buttonDailyReport.Location = new System.Drawing.Point(177, 203);
            this.buttonDailyReport.Name = "buttonDailyReport";
            this.buttonDailyReport.Size = new System.Drawing.Size(94, 29);
            this.buttonDailyReport.TabIndex = 2;
            this.buttonDailyReport.Text = "Daily Report";
            this.buttonDailyReport.UseVisualStyleBackColor = true;
            this.buttonDailyReport.Click += new System.EventHandler(this.buttonDailyReport_Click);
            // 
            // buttonMonthlyReport
            // 
            this.buttonMonthlyReport.Location = new System.Drawing.Point(177, 277);
            this.buttonMonthlyReport.Name = "buttonMonthlyReport";
            this.buttonMonthlyReport.Size = new System.Drawing.Size(94, 29);
            this.buttonMonthlyReport.TabIndex = 2;
            this.buttonMonthlyReport.Text = "Monthly Report";
            this.buttonMonthlyReport.UseVisualStyleBackColor = true;
            this.buttonMonthlyReport.Click += new System.EventHandler(this.buttonMonthlyReport_Click);
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Location = new System.Drawing.Point(71, 181);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(48, 20);
            this.Profit.TabIndex = 3;
            this.Profit.Text = "Profit:";
            // 
            // Investment
            // 
            this.Investment.AutoSize = true;
            this.Investment.Location = new System.Drawing.Point(35, 102);
            this.Investment.Name = "Investment";
            this.Investment.Size = new System.Drawing.Size(84, 20);
            this.Investment.TabIndex = 3;
            this.Investment.Text = "Investment:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(145, 31);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 20);
            this.Date.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.Investment);
            this.panel1.Controls.Add(this.Profit);
            this.panel1.Location = new System.Drawing.Point(533, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 281);
            this.panel1.TabIndex = 5;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(794, 35);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(94, 29);
            this.Close.TabIndex = 6;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMonthlyReport);
            this.Controls.Add(this.buttonDailyReport);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "SalesReportForm";
            this.Text = "SalesReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker dateTimePicker;
        private Button buttonDailyReport;
        private Button buttonMonthlyReport;
        private Label Profit;
        private Label Investment;
        private Label Date;
        private Panel panel1;
        private Button Close;
    }
}