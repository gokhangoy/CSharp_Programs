using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming1
{
    class ProductManager // This class should contain the operations on Product(s).
    {
        public void AddProduct(Product product)
        {
            Console.WriteLine("Item : " + product.productName + " added to database. The stock information is : " + product.productStock);
        }

        public void UpdateProductInfo(Product product)
        {
            Console.WriteLine("The price of "+product.productName + " changed." );

        }
    }
}
