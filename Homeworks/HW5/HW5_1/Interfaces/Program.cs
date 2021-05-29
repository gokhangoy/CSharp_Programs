using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //CustomerManager manager = new CustomerManager();
            //manager.Add(new OracleCustomerDal ());



        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer1 = new Customer() { Id = 1, FirstName = "Gokhan", LastName = "Goy", Address = "Ankara" };

            Student student1 = new Student() { Id = 12, FirstName = "Deloi", LastName = "Wex", Department = "Computer Engineering" };

            manager.Add(customer1);//I am able to use same method for same operation using
            manager.Add(student1); //different instances of different classes.
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        //If we code it like line 39-40 we need to repeat same operation for other class.
        //So this is violates DRY principle. We need to code it like line 42
        //public void Add(Customer customer)
        //public void Add(Student Student)
        public void Add(IPerson person)
        {
            Console.WriteLine("Person: "+ person.FirstName+" "+person.LastName+
                " has been added successfully.");
        }
    }
}
