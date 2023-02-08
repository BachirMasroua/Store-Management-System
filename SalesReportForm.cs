using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_Management_System.Classes;
using System.Windows.Forms.DataVisualization.Charting;

namespace Store_Management_System
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        public void ShowDailyReport(DateTime date)
        {
            Date.Text = date.ToShortDateString();

            // Create a new DailySalesReport and generate the report
            DailySalesReport report = new DailySalesReport(date);
            List <double[]> sales = report.GenerateReport();

            double initial_price = 0;
            double profit = 0;

            foreach (double[] s in sales)
            {
                initial_price += s[0];
                profit += s[1];
            }


            Investment.Text = "Investment = "+ initial_price+ " $";
            Profit.Text = "Profit = " + profit+" $";
            
        }

        public void ShowMonthlyReport(int month, int year)
        {

            Date.Text = new DateTime(year, month, 1).ToString("MMMM yyyy");

            // Create a new MonthlySalesReport and generate the report
            MonthlySalesReport report = new MonthlySalesReport(month, year);
            List<double[]> sales = report.GenerateReport();

            double initial_price = 0;
            double profit = 0;

            foreach (double[] s in sales)
            {
                initial_price += s[0];
                profit += s[1];
            }


            Investment.Text = "Investment = " + initial_price + " $";
            Profit.Text = "Profit = " + profit + " $";

        }

        private void buttonDailyReport_Click(object sender, EventArgs e)
        {
            ShowDailyReport(dateTimePicker.Value);
        }

        private void buttonMonthlyReport_Click(object sender, EventArgs e)
        {
            ShowMonthlyReport(dateTimePicker.Value.Month, dateTimePicker.Value.Year);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
