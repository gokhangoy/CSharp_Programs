using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        //    //Arrays are static.So you cannot play dynamically.If you want to add  another name into names
        //    //array,you cannot do it.
        //    string[] names = new string[] { "Gokhan1", "Gokhan2", "Gokhan3", "Gokhan4" };
        //    Console.WriteLine(names[0]);
        //    Console.WriteLine(names[1]);
        //    Console.WriteLine(names[2]);
        //    Console.WriteLine(names[3]);
        //    //names[4] = "Gokhan5"; --> Error..!

            List<string> names2 = new List<string> { "Gokhan1", "Gokhan2", "Gokhan3", "Gokhan4" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Gokhan5");
            Console.WriteLine(names2[4]);
        }
    }
}
