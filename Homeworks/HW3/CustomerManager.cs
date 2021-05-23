using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    class CustomerManager //Business Class
    {
        List<Customer> _customers = new List<Customer> { };
        public CustomerManager(int numberOfCustomers)
        {
           
            GenerateCustomers(numberOfCustomers);
        }

        private void GenerateCustomers(int numberOfCustomers)
        {
            for (int i = 1; i <= numberOfCustomers; i++)
            {
                _customers.Add(new Customer { CustomerName = "Gokhan" + i.ToString(), CustomerSurname = "Goy" + i.ToString(), CustomerID = i, CustomerUniqueIdentifier = "12345678910", City = "Ankara" });
               
            }
        }

        public void AddCustomer(Customer customer)
        {
            //Simulation
            // Console.WriteLine("Customer: "+customer.CustomerName +" " + customer.CustomerSurname+" has been added to the database.");
            _customers.Add(customer);
        }

        public void UpdateCustomerInformation(Customer customer)
        {
            //Simulation
            Console.WriteLine("Customer name has changed to: " + customer.CustomerName + " and customer surname has changed to :" + customer.CustomerSurname);
        }

        public void DeleteCustomer(Customer customer)
        {
            //Simulation
            Console.WriteLine("Customer: " + customer.CustomerName + " " + customer.CustomerSurname + " has been deleted from the database.");
        }

        public void ListAllCustomers()
        {
            foreach (Customer customer in _customers)
            {
                Console.WriteLine("Customer ID: "+ customer.CustomerID + 
                                  " Customer Name: " + customer.CustomerName + 
                                  " Customer Surname: "+customer.CustomerSurname);
            }
        }
    }
}
