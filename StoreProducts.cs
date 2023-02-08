using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store_Management_System.Classes;


namespace Store_Management_System
{
    public partial class StoreProducts : Form
    {
        public StoreProducts()
        {
            InitializeComponent();

            // Create a list to store the products
            List<Product> products = new List<Product>();
            SearchEvent searchEvent = new SearchEvent(dataGridViewProducts, txtSearch, products);
            txtSearch.TextChanged += searchEvent.TxtSearch_TextChanged;

            // Create the connection and data adapter
            using (SqlConnection connection = new SqlConnection(Database.DatabaseConnection)) 
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM products", connection))
            {
                // Create a new data table
                DataTable table = new DataTable();
                // Fill the table with the products
                adapter.Fill(table);

                // Bind the table to the data grid
                dataGridViewProducts.DataSource = table;

                // Iterate through the rows of the table and create a Product object for each row
                foreach (DataRow row in table.Rows)
                {
                    int productId = (int)row["product_id"];
                    string name = (string)row["name"];
                    string description = (string)row["description"];
                    double iprice = Convert.ToDouble(row["initial_price"]);
                    double sprice = Convert.ToDouble(row["selling_price"]);
                    int quantity = (int)row["quantity"];

                    Product product = new Product();
                    product.ProductId = productId;
                    product.fill_informations( name, description, iprice, sprice, quantity);
                    products.Add(product);
                }
            }
        
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}