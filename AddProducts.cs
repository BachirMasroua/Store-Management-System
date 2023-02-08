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
using System.Data.SqlClient;

namespace Store_Management_System
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OExceptions oexception = new OExceptions();
            oexception.checkEmptyString(this, textBoxName.Text, "Name");
            oexception.checkEmptyString(this, richTextBoxDescription.Text, "Description");
            try
            {
                double[] p = { Convert.ToDouble(InitialPrice.Text), Convert.ToDouble(SellingPrice.Text)};
                int quantity = Int32.Parse(Quantity.Text);
                oexception.checkPositiveNumber(this, p[0], "Initial Price");
                oexception.checkPositiveNumber(this, p[1], "Selling Price");
                oexception.checkPrices(this, p[0], p[1]);
                oexception.checkPositiveNumber(this, quantity, "Quantity");
                Product product = new Product();
                product.fill_informations(textBoxName.Text, richTextBoxDescription.Text, p[0], p[1], quantity);

                try
                {
                    using (SqlConnection con = new SqlConnection(Database.DatabaseConnection))
                    {
                        con.Open();
                        using var cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO products (name, description, initial_price, selling_price, quantity) VALUES ('" + product.Name + "','" + product.Description + "'," + product.InitialPrice + "," + product.SellingPrice + "," + product.Quantity + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("product successfully added to the store");
                        con.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("All Prices and Quantity should be Numbers!!"); 
            }
            finally
            {
                this.Close();
            }
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
