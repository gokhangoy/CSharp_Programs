using System;
using System.Collections.Generic;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCustomers = 0;
            Console.Write("How many customers do you want to add : ");
            numberOfCustomers =Convert.ToInt32(Console.ReadLine());

            CustomerManager customerManager = new CustomerManager(numberOfCustomers); // We are getting these data from somewhere else
            customerManager.ListAllCustomers();

            Console.WriteLine("------------------After Addition Operation------------------");
            Customer newCustomer = new Customer();
            newCustomer.CustomerName = "Engin";
            newCustomer.CustomerSurname = "Demirog";
            newCustomer.CustomerID = numberOfCustomers+1;
            newCustomer.CustomerUniqueIdentifier = "1234567982";

            customerManager.AddCustomer(newCustomer);
            customerManager.ListAllCustomers();

            customerManager.UpdateCustomerInformation(newCustomer);
            customerManager.DeleteCustomer(newCustomer);

            
        }


    }
}
