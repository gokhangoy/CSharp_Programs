using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can not generate an instance from an interface. Because you have all unimplemented methods and the compiler wouldn't understand
            //what needs to be done using which reference. 

            //IPersonManager personManager = new IPersonManager();
            //personManager.Add(); // Which add method ?
            
            //-----------------------------------------------------------------------------------------------------------------------------------

           /* IPersonManager person1 = new CustomerManager();
            person1.Add();
            person1.Update();

            IPersonManager person2 = new EmployeeManager();
            person2.Add();
            person2.Update();*/

            //Let's say after coding customer and employee, our company will accept interns in our company so we need to manage those people as well.
            //Because of this structure I don't need to change anything. I only add a class of it and make sure that class implements IPersonManager.
            //Line between 78-89 and line 33 and line 37  --> I only added these lines and problems solved.

            ProjectManager manager = new ProjectManager();
            
            manager.AddPerson(new CustomerManager());
            manager.AddPerson(new EmployeeManager());
            manager.AddPerson(new InternManager());

            manager.UpdatePerson(new CustomerManager());
            manager.UpdatePerson(new EmployeeManager());
            manager.UpdatePerson(new InternManager());

        }
    }

    interface IPersonManager
    {
        //Unimplemented Operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        //Implemented Operation
        public void Add()
        {
            Console.WriteLine("Customer added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated.");
        }
    }


    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added.");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated.");
        }
    }


    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added.");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated.");
        }
    }

    class ProjectManager
    {
        public void AddPerson(IPersonManager person)
        {
            person.Add();
        }

        public void UpdatePerson(IPersonManager person)
        {
            person.Update();
        }
    }
}
