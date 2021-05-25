using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            
            

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Gokhan";
            customer.LastName = "Goy";
            customer.CreditCardNumber = "12345678910";

            Employee employee = new Employee();
            // employee = customer; employee object couldn't hold a reference
            // for a different class in this case Customer
            //employee = person1; Child Class cannot hold a reference for its base or parent class

            person1 = customer;
            person1.FirstName = "Gokhan1";
            //Console.WriteLine(((Customer)person1).ToString());
            Console.WriteLine(customer.FirstName);

            Person person2 = new Person();
            person2.FirstName = "Gokhan";
            person2.LastName = "Goy";
            person2.Age = 26;
            person2.Id = 1;

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); //Output : null
            personManager.Add(customer); //Output : Gokhan1 Goy
            personManager.Add(person2); //Output : Gokhan Goy

        }
    }

    //Person class is the base class for Employee and Customer so every Person object could hold a reference of these
    //two classes.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }

    class PersonManager
    {
        //public void Add(Customer customer) If we just code this method like this then we definitely repeat ourselves of Employee and Person

        //public void Add(Employee employee) If we just code this method like this then we definitely repeat ourselves of Customer and Person

        //So, to be able to avoid reparting we need to write a code which should be suitable for all of these classes. If we think 
        //Person class has the capability to store these classes' references. Hence the argument should be a Person.
        public void Add(Person person)
        {//Simulation
            Console.WriteLine("Person "+person.FirstName + " " +person.LastName+" added." );

        }
    }


}
