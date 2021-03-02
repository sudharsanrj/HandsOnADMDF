﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArg
{
    class Program
    {
        public static void OrderDetails(string SellerName, string ProductName, int OrderQuantity = 1, bool IsReturnable = true)
        {
            Console.WriteLine("Here is the order details- {0} number of {1} by {2} is ordered. It's returnable status is {3}",OrderQuantity, ProductName, SellerName, IsReturnable);
        }
        static void Main(string[] args)
        {
            OrderDetails("Amazon","laptop");
            OrderDetails("Flipkart", "watch",2,false);
            Console.ReadLine();

        }
    }
}
