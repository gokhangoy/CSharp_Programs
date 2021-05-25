using System;
using System.Collections.Generic;

namespace Dictionary_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberAndNames = new Dictionary<int, string>();
            numberAndNames.Add(1, "Gokhan");
            numberAndNames.Add(2, "Gokhan2");
            //Console.WriteLine(numberAndNames.Count);
            

            MyDictionary<int, string> keyValuePairs = new MyDictionary<int, string>();
            keyValuePairs.Add(1,"Gokhan");
            keyValuePairs.Add(2,"Gokhan2");
            keyValuePairs.Add(1,"Gokhan2");
            keyValuePairs.Display();
            Console.WriteLine("The length of key-value pairs is : "+keyValuePairs.Count);
            

        }
    }

    class MyDictionary<K, KV>
    {
        K[] keys;  //To store old key values...
        KV[] keyValues; //To store old values 
        bool flag=false; //To check whether we have duplicate value or not
        
        public MyDictionary()
        {
            keys = new K[0];
            keyValues = new KV[0]; 
        }
        public void Add(K key, KV keyValue)
        {
            K[] tempKeys = keys;
            KV[] tempKeyValues=keyValues;

            //We need to check whether we have same key or not...
            for (int i = 0; i < keys.Length; i++)
            {
                if (tempKeys[i].Equals(key))
                {
                    Console.WriteLine("You cannot an element which has same key...");
                    flag = true;
                    break;

                }
            }
            if(flag != true)
            {
                keys = new K[keys.Length + 1];
                keyValues = new KV[keyValues.Length + 1];


                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                    keyValues[i] = tempKeyValues[i];
                }



                keys[tempKeys.Length] = key;
                keyValues[tempKeyValues.Length] = keyValue;
            }
        }

   
        public int Count
        {
            get { return keys.Length; }
            
        }

        public void Display()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Pair "+(i+1)+"->"+"\t"+ keys[i]+"\t"+keyValues[i]);
            }
        }

    }
}
