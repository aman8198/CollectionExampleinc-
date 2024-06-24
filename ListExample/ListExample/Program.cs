using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create reference variable and object of List Class 
            List<int> myList = new List<int>() { 10, 20, 30};

            //read elements using foreach loop
            Console.WriteLine("Using foreach loop");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            //read elements using for loop
            Console.WriteLine("Using for loop");
            for (int i=0; i<myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            //add new element at the end of the existing collection 
            myList.Add(40);
            myList.Add(50);
            myList.Add(60);

            //adding another collection to existing collection
            List<int> otherList = new List<int>() { 70, 80, 90};
            myList.AddRange(otherList);

            //insert element at 1st index
            myList.Insert(1, 200);

            //insert multiple elements at Postion 2 (2nd index)
            List<int> newList = new List<int>() { 400, 500, 600};
            myList.InsertRange(2, newList);

            //read elements
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            //Remove Collection demonstration
            //collection
            List<int> removeEx = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90,
            100, 110, 120, 130};

            //remove 30 
            removeEx.Remove(30);
            //remove at example pass index of the element to remove 
            removeEx.RemoveAt(1);

            //remove range example we have to pass 2 parameters one is the 
            //index from which we want to delete elements second is the number 
            //of elements we want to delete from this index lets see example
            removeEx.RemoveRange(1, 2);

            //remove all method example 
            //this method removes all the elements that are matching 
            //with the given conditions.
            // we can write our condition in the lambda expression of
            //predicate type

            //remove all element > 110
            removeEx.RemoveAll(n => n > 110);

            //clear method in collection clears all elements
            //in the collections makes it empty
            myList.Clear();
            Console.WriteLine("remove example");

            //read element
            foreach(var item in removeEx)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("myList is cleared");

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }


            //indexOf example it is used for searching an element in a collection 
            //if the element is present in the collection it returns the index
            List<int> simpleList = new List<int>() { 10, 20, 30, 40, 50, 40 };
            int n = simpleList.IndexOf(40);
            Console.WriteLine(" 40 is present at index " + n);

            //if the element we are searching is not found the indexOf returns -1 
            //lets write a snippet of code  for non existing element in collection
            int n1 = simpleList.IndexOf(80);

            if (n1 >= 0)
            {
                Console.WriteLine(" 80 is found at index " + n1);
            }
            else
            {
                Console.WriteLine(" 80 is not found ");
            }

            //search for second occurence of 40
            //here n is the value of index where 40 is first occured 
            int n3 = simpleList.IndexOf(40, n + 1);
            Console.WriteLine("Second Occurence of 40 is " + n3);


            //binary search example 
            List<int> myList2 = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int n4 = myList2.BinarySearch(80);
            Console.WriteLine("Binary Search of 80 is " + n4);

            //contains example
            bool b = myList2.Contains(110);

            Console.WriteLine("110 is found in myList2: " + b);

            //Sorting Example
            //create a list 
            List<double> myList3 = new List<double>() { 150, 177, 65, 340, 206, 20, 754 };
            //sorting in ascending order
            myList3.Sort();

            foreach (int i in myList3)
            {
                Console.WriteLine($"{i}");
            }

           //sort in descending order
           //call reverse method after sort method in order to sort in descending order

           myList3.Reverse();

            foreach (int i in myList3)
            {
                Console.WriteLine($"{i}");
            }

            //converting to array
            //example
            //create List
            List<string> myFriends = new List<string>()
            { "Scott", "Allen", "James", "Jones"};

            //convert to array
            string[] myFrindsArray = myFriends.ToArray();

            //display array
            foreach( string item in myFrindsArray)
            {
                Console.WriteLine(item);
            }

            //ForEachMethod
            myFriends.ForEach(friend => { Console.WriteLine(friend); });

            //Exists example
            List<int> marks = new List<int>() { 45, 65, 40, 24, 75, 80, 95, 50, 15 };
            bool res = marks.Exists(m => m < 35);
            if (res == true)
            {
                Console.WriteLine("Student is failed in one or more subjects");
            }
            else
            {
                Console.WriteLine("Student is Pass");                              
            }

            //find Method
            int firstfailedSubject = marks.Find(m => m < 35);
            Console.WriteLine("First failed marks " + firstfailedSubject);

            //findIndex Method
            int firstfailedSubjectIndex = marks.FindIndex(m => m < 35);
            Console.WriteLine("First failed marks index " + firstfailedSubjectIndex);

            //FindLast Method Example
            int lastfailedSubject = marks.FindLast(m => m < 35);
            Console.WriteLine("First failed marks " + lastfailedSubject);

            //FindLastIndex Method Example
            int lastfailedSubjectIndex = marks.FindLastIndex(m => m < 35);
            Console.WriteLine("First failed marks index " + lastfailedSubjectIndex);

            //FindAll Method Example
            Console.WriteLine("Failed marks");
            List<int> failedMarks = marks.FindAll(m => m < 35);
            failedMarks.ForEach(mark => { Console.WriteLine(mark); });

            //ConvertAll method example 
            List<int> intCollection = new List<int>() { 1, 8, 2, 7};
            /*
            List<string> strCollection = 
            intCollection.ConvertAll<string>((n) =>
            {
                return Convert.ToString(n);
            });

            strCollection.ForEach(str => { Console.WriteLine(str); }); 
            */
            List<string> strCollection =
                intCollection.ConvertAll<string>(
                    (n) =>
                    {
                        string word;
                        switch(n)
                        {
                            case 1: word = "One"; break;
                            case 2: word = "Two"; break;
                            case 3: word = "Three"; break;
                            case 4: word = "Four"; break;
                            case 5: word = "Five"; break;
                            case 6: word = "Six"; break;
                            case 7: word = "Seven"; break;
                            case 8: word = "Eight"; break;
                            case 9: word = "Nine"; break;
                            default: word = ""; break;
                        }
                        return word;
                    }
                    );
            strCollection.ForEach(str => { Console.WriteLine(str); });
            Console.ReadKey();
        }
    }
}