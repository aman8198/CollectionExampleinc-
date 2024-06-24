using System;

namespace AnonymousObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            Person person = new Person();

            //call Methods
            var p = new {PersonName = person.GetPersonName(), Age=person.GetPersonAge()};
            /*
            person.GetPersonName();
            person.GetPersonAge();*/

            //nested anonymous type
            var p1 = new { Address = new { Street = "abc", City = "xyz" } };

            //print
            Console.WriteLine(p.PersonName); Console.WriteLine(p.Age);
            Console.WriteLine(p1.Address.City); Console.WriteLine(p1.Address.Street);

            //create anonymous array /implicitly typed array
            var persons = new[] { 
             new {Name = "Aman", Email = "abc@abc.com"},
             new {Name = "A1", Email = "abc@ghf.com"},
             new {Name = "A2", Email = "abd@ghf.com"},
             new {Name = "A3", Email = "abe@ghf.com"}
            };

            foreach(var item in persons)
            {
                Console.Write(item.Name);
                Console.Write(",");
                Console.Write(item.Email);
            }
            Console.ReadKey();
        }
    }
}