using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3] 
            { 
            new Customer(){FirstName="Gokhan" },
            new Student(){FirstName="Deloi"},
            new Person(){FirstName="Daniel"}
            
            };

            foreach (var names in people)
            {
                Console.WriteLine(names.FirstName);
            }
            Console.ReadLine();
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
