using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Store_Management_System.Classes
{
    internal class Order: List<OrderItems>
    {
        private int id;
        private Customer customer;
        private DateTime date;
        private double initialCost;
        private double totalCost;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public double InitialCost
        {
            get { return initialCost; }
            set { initialCost = value; }
        }
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        /*

        public delegate void WriteInvoiceDelegate();

        public void Invoice()
        {
            WriteInvoiceDelegate writeInvoice = new WriteInvoiceDelegate(WriteInvoice);
            // System.PlatformNotSupportedException: 'Operation is not supported on this platform.'
            Task.Run(() => writeInvoice.BeginInvoke(null, null));
        }

        public void WriteInvoice()
        {
            using (StreamWriter writer = new StreamWriter(@"D:Invoice.txt"))
            {
                writer.WriteLine($"Invoice for Order {id}");
                writer.WriteLine($"Customer: {customer.FirstName} {customer.LastName}");
                writer.WriteLine($"Order Date: {date}");

                writer.WriteLine("Items:");

                foreach (OrderItems item in this)
                {
                    writer.WriteLine($"{item.Product.Name} - Quantity: {item.Quantity} - Total Cost: {item.Product.SellingPrice * item.Quantity}$");
                }

                writer.WriteLine($"Total Cost: {totalCost}$");
            }
        }

        */
        public async void WriteInvoice()
        {
            using (StreamWriter writer = new StreamWriter(@"D:Invoice.txt"))
            {
                await writer.WriteLineAsync($"Invoice for Order {id}");
                await writer.WriteLineAsync($"Customer: {customer.FirstName} {customer.LastName}");
                await writer.WriteLineAsync($"Order Date: {date}");

                await writer.WriteLineAsync("Items:");

                foreach (OrderItems item in this)
                {
                    await writer.WriteLineAsync($"{item.Product.Name} - Quantity: {item.Quantity} - Total Cost: {item.Product.SellingPrice * item.Quantity}$");
                }

                await writer.WriteLineAsync($"Total Cost: {totalCost}$");
            }
        }
    }
}
