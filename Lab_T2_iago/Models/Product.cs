using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_T2_iago.Models
{
    public class Product
    {
        public string ProductName { get; private set; }
        public int ProductID { get; private set; }
        public string Section { get; private set; }

        public Product()
        {
            ProductName = "Default";
            Section = "N/A";
            ProductID = 0;
        }

        // Constructor förberedd för errors.
        public Product(string productName, string productSection, int productId)
        {
            if (productName != null)
            {
                ProductName = productName;
            }
            else
            {
                throw new Exception("Product Name cannot be null.");
            }

            if (productId > 0)
            {
                ProductID = productId;
            }
            else
            {
                throw new Exception("Product Id cannot be less than zero.");
            }

            if (productId <= int.MaxValue)
            {
                ProductID = productId;
            }
            else
            {
                throw new Exception("Product Id cannot be that large.");
            }

            if (productSection != null)
            {
                Section = productSection;
            }
            else
            {
                throw new Exception("Product Section cannot be null.");
            }

        }
    }
}
