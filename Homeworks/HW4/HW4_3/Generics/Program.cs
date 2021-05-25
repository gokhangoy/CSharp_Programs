using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {//Generics are based on arrays.
            List<string> cities = new List<string>();
            cities.Add("Istanbul");
            cities.Add("Mallorca");
            cities.Add("Nice");

            Console.WriteLine(cities.Count);

            NewList<int> numbers = new NewList<int>();
            numbers.Add(12);
            numbers.Add(21);
            numbers.Add(96);
            numbers.Add(21);

            numbers.DisplayList();
            Console.WriteLine("\n"+numbers.Count);
        }
    }

   class NewList<T>  //Generic class declaration
    {  //We need a new array we we call this class so we state this situation in the constructor method...
        T[] _items;
        T[] _tempArray;


        public NewList()
        {
            _items = new T[0];//At the beginnning list class has a list which contins 0 element.
        }

        public void Add(T item)
        {
            _tempArray = _items; //_tempArray is pointing the old values...

            _items = new T[_items.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _items[i] = _tempArray[i];
            }

            _items[_tempArray.Length] = item;


        }


        public int Count
        {
            get { return _items.Length; }
        }

        public int Count2()
        {
            return _items.Length;
        }


        public void DisplayList()
        {
            foreach (var item in _items)
            {
                Console.Write(item+"\t");
            }
        }
    }
}
