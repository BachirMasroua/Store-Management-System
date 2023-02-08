using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System.Classes
{
    internal class SearchEvent
    {
        private DataGridView dg;
        private NumericUpDown txtSearch;
        private List<Product> products;

        public SearchEvent(DataGridView DG, NumericUpDown TxtSearch, List<Product> Products)
        {
            dg = DG;
            txtSearch = TxtSearch;
            products = Products;
        }



        public void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Convert the search text to an integer
            int searchId;
            try
            {
                searchId = int.Parse(txtSearch.Text);
            }
            catch
            {
                searchId = 0;
            }
                
            Product sproduct = new Product();
            sproduct.ProductId = searchId;

            // Perform a binary search on the list of products
            int index = Array.BinarySearch(products.ToArray(), sproduct, new ProductIdComparer());

            // Or using Predicate
            /*

            // Define the predicate
            Predicate<Product> match = (p) => p.ProductId == searchId;

            // Perform a search on the list of products
            int index = products.FindIndex(match);

            */

            // If the product was found, select it in the data grid
            if (index >= 0)
            {
                dg.ClearSelection();
                dg.Rows[index].Selected = true;
            }
        }

    }
}
