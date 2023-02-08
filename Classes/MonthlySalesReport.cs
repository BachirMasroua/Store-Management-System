using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Store_Management_System.Classes
{
    internal class MonthlySalesReport: Report
    {
        public event GetSalesDelegate getSalesEvent;

        private static readonly string query = "SELECT initial_cost, total_cost FROM orders WHERE DATEPART(month, order_date) = @month AND DATEPART(year, order_date) = @year";

        // Month and year for the report
        private int month;
        private int year;

        public MonthlySalesReport(int month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public override List<double[]> GenerateReport()
        {
            // Retrieve the orders data from the database
            DataTable table = GetData();

            // Group the orders by the initial cost
            IEnumerable<IGrouping<decimal, DataRow>> groups = table.Rows.Cast<DataRow>().GroupBy(row => (decimal)row["initial_cost"]);
            getSalesEvent += new GetSalesDelegate(GetSales);
            List<double[]> sales = getSalesEvent(groups);
            return sales;
        }

        public override DataTable GetData()
        {
            // Create a new data table
            DataTable table = new DataTable();

            // Create the connection and command
            using (SqlConnection connection = new SqlConnection(Database.DatabaseConnection))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add the parameters for the month and year
                command.Parameters.Add("@month", SqlDbType.Int).Value = month;
                command.Parameters.Add("@year", SqlDbType.Int).Value = year;

                // Create the data adapter and fill the table with the orders data
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }

            return table;
        }
     
    }
}
