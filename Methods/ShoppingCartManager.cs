using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class ShoppingCartManager
    {
        //Naming Convention - Pascal Case
        public void addToShoppingCart(Product product)
        {
            Console.WriteLine("Product added to shopping cart: " + product.productName);

        }

        public void addToShoppingCart2(string productName, double productPrice, string productDescription)
        {
            Console.WriteLine("Product added to shopping cart: "+ productName);
        }
    }
}
