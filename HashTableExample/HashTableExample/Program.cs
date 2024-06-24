using System;
using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main()
        {
            //create a hashtable
            Hashtable employees = new Hashtable()
            {
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" },
                { "hello", 10.934 }
            };

            //Add element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //get value based on key
            if (employees[105] is string)
            {
                string value = Convert.ToString(employees[105]);
                Console.WriteLine(value);
            }
            else if (employees[105] is double)
            {
                double value = Convert.ToDouble(employees[105]);
                Console.WriteLine(value);
            }

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n105 exists: " + k);

            //search for specific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine("\nScott exists: " + v);

            //Keys
            Console.WriteLine("\nKeys:");
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("\nValues:");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }

            //create object of hash set
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How Are You", "Have a good day"
            };

            //Add
            messages.Add("Good Luck");

            //Remove
            messages.Remove("Good Morning");

            //Remove Where 
            messages.RemoveWhere(m => m.EndsWith("You"));

            //Search
            bool b = messages.Contains("Good Morning");


            //Union Example
            HashSet<string> employee = new HashSet<string>() { "Emp1", "Emp2", "Empl3" };
            HashSet<string> newEmployee = new HashSet<string> { "Emp4", "Emp5", "Emp1" };

            employee.UnionWith(newEmployee);

            foreach(var item in employee) { Console.WriteLine(item); }

            //Intersection Example
            employee.IntersectWith(newEmployee);

            foreach (var item in employee) { Console.WriteLine(item); }

            //count 
            Console.WriteLine("Count: " + messages.Count);

            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}
