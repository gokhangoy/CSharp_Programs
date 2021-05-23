using System;
using System.Collections.Generic;

namespace Generics_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int> {};
            // Console.WriteLine(numbers.Count); At the beginnig we have a list which contains zero element.


            Console.WriteLine("\nThe Length: " + numbers.GetLength());
            numbers.AddItem(12);
            numbers.DisplayList();
            Console.WriteLine("\nThe Length: "+numbers.GetLength());
            numbers.AddItem(25);
            numbers.DisplayList();
            Console.WriteLine("\nThe Length: " + numbers.GetLength());
            numbers.AddItem(36);
            numbers.DisplayList();
            Console.WriteLine("\nThe Length: " + numbers.GetLength());
            numbers.AddItem(52);
            numbers.DisplayList();
            Console.WriteLine("\nThe Length: " + numbers.GetLength());
            numbers.AddItem(536);
            numbers.DisplayList();
            Console.WriteLine("\nThe Length: " + numbers.GetLength());

        }
    }
}
