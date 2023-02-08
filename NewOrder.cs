using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_Management_System.Classes;

namespace Store_Management_System
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
            // Create an unbound DataGridView by declaring a column count.
            dataGridViewItems.ColumnCount = 4;
            dataGridViewItems.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridViewItems.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridViewItems.Columns[0].Name = "ID";
            dataGridViewItems.Columns[1].Name = "Name";
            dataGridViewItems.Columns[2].Name = "Price";
            dataGridViewItems.Columns[3].Name = "Quantity";
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            OExceptions oexception = new OExceptions();
            try
            {
                int[] p = { Int32.Parse(ProdId.Text), Int32.Parse(Quantity.Text) };
                oexception.checkPositiveNumber(this, p[0], "Product ID");
                oexception.checkPositiveNumber(this, p[1], "Quantity");
                try
                {
                    using (SqlConnection con = new SqlConnection(Database.DatabaseConnection))
                    {
                        Dictionary<string,object> values = new Dictionary<string,object>();                       
                        con.Open();
                        using var cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT name, selling_price, quantity FROM products WHERE product_id = " + p[0];
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        try
                        {
                            if (reader.Read())
                            {
                                values.Add("name",reader.GetString(0));
                                values.Add("price",reader.GetDecimal(1));
                                values.Add("quantity",reader.GetInt32(2));
                            }
                            int n = Convert.ToInt32(values["quantity"]) - p[1];
                            if (n<0)
                            {
                                MessageBox.Show("not enough quantity in the stock!!");
                                return;
                            }
                            reader.Close();
                            cmd.CommandText = "UPDATE products SET quantity = "+ n + " WHERE product_id = " + p[0];
                            cmd.ExecuteNonQuery();
                            string[] Item = new string[] { p[0].ToString(), (string)values["name"], values["price"].ToString(), p[1].ToString() };
                            dataGridViewItems.Rows.Add(Item);

                            NbOfProducts.Text = (Convert.ToInt32(NbOfProducts.Text) + 1).ToString();

                            double price = Convert.ToDouble(Cost.Text);
                            price += Convert.ToDouble(values["price"]) * p[1];
                            Cost.Text = price.ToString();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product ID and Quantity should be Numbers!!");
                return;
            }
            finally
            {
                ProdId.Text = "";
                Quantity.Text = "1";
            }
        }

        private void submitOrder_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = firstName.Text;
            customer.LastName = lastName.Text;
            customer.PhoneNumber = Int32.Parse(phoneNumber.Text);
            try
            {
                using (SqlConnection con = new SqlConnection(Database.DatabaseConnection))
                {
                    con.Open();
                    using var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "IF NOT EXISTS(SELECT * FROM customers WHERE phone = " + customer.PhoneNumber + ") BEGIN INSERT INTO customers(first_name, last_name, phone) VALUES('" + customer.FirstName + "', '" + customer.LastName + "', " + customer.PhoneNumber + ") END";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT customer_id FROM customers WHERE first_name= '"+ customer.FirstName +"' AND last_name='"+ customer.LastName +"' AND phone ="+ customer.PhoneNumber;
                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        if (reader.Read())
                        {
                            customer.Id = reader.GetInt32(0);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                        con.Close();
                    }                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Order order = new Order();
            order.Customer = customer;
            DateTime today = DateTime.Today;
            order.Date = today;
            double price = Convert.ToDouble(Cost.Text);
            double initial_price = 0;

            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                OrderItems item = new OrderItems();
                Product product = new Product();
                int id = Convert.ToInt32((string)row.Cells[0].Value);

                try
                {
                    using (SqlConnection con = new SqlConnection(Database.DatabaseConnection))
                    {
                        Dictionary<string, object> values = new Dictionary<string, object>();
                        con.Open();
                        using var cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT name, initial_price, selling_price, quantity FROM products WHERE product_id = " + id;
                        SqlDataReader reader = cmd.ExecuteReader();

                        try
                        {
                            if (reader.Read())
                            {
                                product.Name = reader.GetString(0);
                                initial_price += Convert.ToDouble(reader.GetDecimal(1)) * Convert.ToInt32(row.Cells[3].Value);
                                product.SellingPrice = (double)reader.GetDecimal(2);
                                product.Quantity = reader.GetInt32(3);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            reader.Close();
                            product.ProductId = id;
                            item.Product = product;
                            item.Quantity = Convert.ToInt32(row.Cells[3].Value);
                            order.Add(item);
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            order.TotalCost = price;
            order.InitialCost = initial_price;

            try
            {
                using (SqlConnection con = new SqlConnection(Database.DatabaseConnection))
                {
                    con.Open();
                    using var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO orders (customer_id, order_date, initial_cost, total_cost) VALUES (" + order.Customer.Id + ",'" + order.Date + "'," + order.InitialCost + "," + order.TotalCost + ")";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT order_id FROM orders WHERE customer_id= " + order.Customer.Id + " AND order_date='" + order.Date + "' AND initial_cost =" + order.InitialCost +" AND total_cost =" + order.TotalCost;
                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        if (reader.Read())
                        {
                            order.Id = reader.GetInt32(0);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                    }
                    foreach (OrderItems oitem in order)
                    {
                        cmd.CommandText = "INSERT INTO order_items (order_id, product_id, quantity) VALUES (" + order.Id + "," + oitem.Product.ProductId + "," + oitem.Quantity + ")";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //order.Invoice();
            order.WriteInvoice();


            this.Close();
            MessageBox.Show("Invoice created successfully");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
