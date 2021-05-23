using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Introduction
{
    class MyList<T>
    {
        T[] items;       //In this class we need an array to store items. Type of the elements could be different.
        public MyList()
        {
            items = new T[0];  //Line 11 in Program.cs
        }

        public void AddItem(T item)
        {
            T[] tempArray = items;  //We are not going to loose the old reference for items so we are not going to loose old values...
            items = new T[items.Length + 1];

            for (int i = 0; i < items.Length-1; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int GetLength()
        {
            return items.Length;
        }

        public void DisplayList()
        {
            foreach (var item in items)
            {
                Console.Write(item+"\t");
            }
        }
    }
}
