using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System.Classes
{
    class ProductIdComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.ProductId.CompareTo(y.ProductId);
        }
    }
}
