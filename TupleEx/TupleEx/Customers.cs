using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleEx
{
    internal class Customers
    {
        //Value Tuple
        public (int customerID, string customerName, string email) GetCustomerDetails()
        {
            return (101, "Aman", "jhaaman8198@gmail.com");
        }
    }
}
