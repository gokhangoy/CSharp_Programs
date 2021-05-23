using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //Class instance
            product1.productName = "Apple";
            product1.productPrice = 15;
            product1.productDescription = "Amasya Apple";
            

            Product product2 = new Product();
            product2.productName = "Watermelon";
            product2.productPrice = 80;
            product2.productDescription = "Diyarbakır Watermelon";

            Product[] products = new Product[] {product1, product2};

            foreach (Product product in products)
            { 
                Console.WriteLine(product.productName );
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.productDescription);
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("-------------------Methods----------------------");
            ShoppingCartManager cartInstance = new ShoppingCartManager();
            cartInstance.addToShoppingCart(product1);
            cartInstance.addToShoppingCart(product2);

            cartInstance.addToShoppingCart2("Pineapple", 20, "Green one");
            cartInstance.addToShoppingCart2("Apple2", 15, "Green one");
            cartInstance.addToShoppingCart2("Watermelon2", 80, "Green one");
            
        }
    }
}
