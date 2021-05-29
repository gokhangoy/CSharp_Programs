using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager();
            starbucksCustomerManager.Save(new Customer 
            {
                DateOfBirth= new DateTime(1994,10,21),
                FirstName="Gökhan",LastName="Göy",
                NationalitytId="12554330878"});

            BaseCustomerManager neroCustomerManager = new NeroCustomerManager();
            neroCustomerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1994, 10, 21),
                FirstName = "Gökhan",
                LastName = "Göy",
                NationalitytId = "12554330878"
            });
        }
    }
}
