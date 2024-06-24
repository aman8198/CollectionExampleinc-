using System;
using TupleEx;

namespace TupleExample
{
    class Sample
    {
        public Tuple<string, int> GetPersonDetails()
        {
            Tuple<string, int> tuple = new Tuple<string, int>("Scott", 20);
            return tuple;
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Sample s= new Sample();
            Tuple<string, int> person= s.GetPersonDetails();

            Customers customers= new Customers();
            (int customerID, string customerName, string customerEmail) cust =
                customers.GetCustomerDetails();
            Console.WriteLine(cust.customerID);
            Console.WriteLine(cust.customerName);
            Console.WriteLine(cust.customerEmail);

            //Deconstructing 
            (int CustId, string name, string 
                email) = customers.GetCustomerDetails();
            Console.WriteLine(CustId);
            Console.WriteLine(name); Console.WriteLine(email);

            //Discard using _ in tuple
            (int custId, _, string mail) = customers.GetCustomerDetails();
            Console.WriteLine(custId); Console.WriteLine(mail);
            

            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            Console.ReadKey();
        }
    }
}