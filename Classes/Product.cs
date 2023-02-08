using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System.Classes
{
    internal class Product
    {
        private int productId;
        private string name;
        private string description;
        private double initial_price;
        private double selling_price;
        private int quantity;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double InitialPrice
        {
            get { return initial_price; }
            set { initial_price = value; }
        }
        public double SellingPrice
        {
            get { return selling_price; }
            set { selling_price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public void fill_informations(string name, string description, double iprice,double sprice, int quantity)
        {
            this.name = name;
            this.description = description;
            this.initial_price = iprice;
            this.selling_price = sprice;
            this.quantity = quantity;
        }
    }
}
