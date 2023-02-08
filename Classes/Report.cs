using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Store_Management_System.Classes
{
    public delegate List<double[]> GetSalesDelegate(IEnumerable<IGrouping<decimal, DataRow>> groups);

    abstract class Report
    {

        public virtual DataTable GetData()
        {
            return new DataTable();
        }

        public virtual List<double[]> GenerateReport()
        {
            return new List<double[]>();
        }

        public static List<double[]> GetSales(IEnumerable<IGrouping<decimal, DataRow>> groups)
        {
            List<double[]> sales = new List<double[]>();
            foreach (IGrouping<decimal, DataRow> group in groups)
            {
                foreach (DataRow row in group)
                {
                    double initialCost = Convert.ToDouble(row["initial_cost"]);
                    double totalCost = Convert.ToDouble(row["total_cost"]);
                    double profit = totalCost - initialCost;

                    sales.Add(new double[] { initialCost, profit });
                }
            }
            return sales;
        }
    }
}
