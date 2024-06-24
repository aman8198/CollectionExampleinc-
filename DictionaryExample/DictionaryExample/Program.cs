using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {101, "Aman" },
                {102, "Khushboo" },
                {103, "Manoj" },
                {104, "Biva" }
            };

            foreach (var item in employees) 
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //get value based on key 
            string s = employees[101];
            Console.WriteLine("\n Value at 101: " + s);

            //Keys
            Dictionary<int, string>.KeyCollection keys = employees.Keys;
            Console.WriteLine("\n Keys:");
            foreach(var item in keys)
            {
                Console.WriteLine(item);
            }

            //Duplicate key: exception
            // employees.Add(103, "Anna");

            //Remove method pass only key
            //employees.Remove(102);

            //ContainsKey
            bool a = employees.ContainsKey(101);
            Console.WriteLine("ContainsKey 101: " + a);

            //ContainsValue 
            bool val = employees.ContainsValue("Aman");
            Console.WriteLine("Contains Value Aman: " + val);

            //Clear
            //employees.Clear();

            //SortedList Example
            SortedList<int, string> emp = new SortedList<int, string>()
            {
                {101, "Scott" },
                {102, "Smith" },
                {103, "Allen" },
                {104, "Jones" },
                {105, "James" },
            };

            //Add element 
            emp.Add(106, "Aman");

            //Remove element
            emp.Remove(101);

            //foreach loop to view elements in a SortedList
           // emp.ForEach(emp => { Console.WriteLine(emp.Key + " " + emp.Value); });
           foreach (var item in emp)
           {
                Console.WriteLine(item.Key + " " + item.Value);
           }

            //get value based on key
            string eName = emp[105];
            Console.WriteLine("\n Employee Name at 105:" + eName);

            //ContainsKey example search for specifc key
            bool k = emp.ContainsKey(105);
            Console.WriteLine("\n 105 exists " + k);

            //ContainsValue example search for specific value
            bool v = emp.ContainsValue("Scott");
            Console.WriteLine("\n Scott exists " + v);

            //Index of specific key
            int indexOfkey = emp.IndexOfKey(101);
            Console.WriteLine("Index " + indexOfkey);

            //Index of specific value
            int indexOfValue = emp.IndexOfValue("Aman");
            Console.WriteLine("Value Index" + indexOfValue);

            //keys returned
            Console.WriteLine("\n keys");
            foreach (var item in emp.Keys)
            {
                Console.WriteLine(item);
            }

            //values returned 
            Console.WriteLine("\n Values");
            foreach(var item in emp.Values)
            {
                Console.WriteLine(item);
            }

            //clear method
            //emp.Clear();
            Console.ReadKey();
        }
    }
}