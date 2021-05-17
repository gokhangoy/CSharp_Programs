using System;

namespace ObjectOrientedProgramming1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//We are just generating a new reference here using mew keyword.
            product1.productId = 1;// As an example this product could be the first item(E.g.:table)
            product1.productCategoryId = 2; // Table's category is two(E.g. Furniture)
            product1.productName = "Table";
            product1.productUnitPrice = 650;
            product1.productStock = 100;
            //In real life examples these records come by a data source then we can easily manipulate data without writing line 10 to 14.


            //This is another usage of generating an instance which does the same thing with lines [10,14]
            Product product2 = new Product { productId = 2, productCategoryId = 5, productName = "Laptop", productDescription = "Gaming Laptop", productStock = 10, productUnitPrice = 5000 };



            ProductManager productManager = new ProductManager();// We just need a reference to use all of product's operations....
            
            productManager.AddProduct(product1);
            productManager.AddProduct(product2);

            productManager.UpdateProductInfo(product1);
            productManager.UpdateProductInfo(product2);

        }
    }
}
