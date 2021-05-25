using System;

namespace Constructor_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();//Line 18
            Person person2 = new Person("Gokhan","Goy",26);
            Person person3 = new Person("Gokhan1", "Goy1");



            //Line 17 and lines 20-23 are actually the same. And they are both uses default empty costructor.

            Person person4 = new Person() { FirstName = "Gokhan4", LastName = "Goy4", Age = 12 };


            Person person5 = new Person();
            person5.FirstName = "Gokhan5";
            person5.LastName = "Goy5";
            person5.Age = 26;
        }
    }


    class Person
    {   // When you generate a new instance from a class, the empty(default) constructor will execute immediately.
        //We could actually overrride constructor method. You just need to have different signature.
        public Person()
        {
            Console.WriteLine("Empty constructor has executed...");
        }

        public Person(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
            Age = 0; 
        }

        public Person(string name, string lastName, int age=0)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Console.WriteLine("Person: "+FirstName+" "+LastName+" has been generated...");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}

