using System;
using System.Collections.Generic;

namespace LINQLab
{
    class Customer
    {


        // Define CustomerId, Name and City Properties.
        public object Name { get; internal set; }
        public object CustomerId { get; internal set; }
        public string City { get; internal set; }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, Name = "Amit ", City = "Ahmedabad" },
                     new Customer { CustomerId = 2, Name = "mohan ", City = "baroda" },
                          new Customer { CustomerId = 3, Name = "ravi", City = "mumbai" },
                               new Customer { CustomerId = 4, Name = "arjun", City = "delhi" },
				// Add more customers
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 102, CustomerId = 2, ProductName = "iphone", Category = "Electronics", OrderAmount = 65000 },

              new Order { OrderId = 103, CustomerId = 3, ProductName = "telivision", Category = "Electronics", OrderAmount = 65000 },

                 new Order { OrderId = 104, CustomerId = 4, ProductName = "mobile", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 105, CustomerId = 1, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },

				// Add more Orders

            };

           

            var result = from cust in customers
                         join ord in orders on cust.CustomerId equals ord.CustomerId
                         select new { cust.Name, ord.ProductName }; // Properties are Name and ProductName

            foreach (var item in result)
            {
                // FIX: Changed item.DeptName to item.ProductName
                Console.WriteLine($"{item.Name} ordered {item.ProductName}");
            }



            var expensiveOrder = orders.FirstOrDefault(o => o.OrderAmount > 20000);

            if (expensiveOrder != null)
            {
                Console.WriteLine($"Order ID: {expensiveOrder.OrderId}, Product: {expensiveOrder.ProductName}, Amount: ₹{expensiveOrder.OrderAmount}");
            }
            else
            {
                Console.WriteLine("No order found above ₹20,000.");
            }


            var ahmedabadSpending = from cust in customers
                                    join ord in orders on cust.CustomerId equals ord.CustomerId
                                    where cust.City.Equals("Ahmedabad", StringComparison.OrdinalIgnoreCase)
                                    group ord by cust.Name into g
                                    select new
                                    {
                                        CustomerName = g.Key,
                                        TotalSpent = g.Sum(x => x.OrderAmount)
                                    };

            Console.WriteLine("\nAhmedabad Customers Total Spending:");
            foreach (var item in ahmedabadSpending)
            {
                Console.WriteLine($"{item.CustomerName} spent a total of ₹{item.TotalSpent}");
            }


            var highestOrderDetails = (from cust in customers
                                       join ord in orders on cust.CustomerId equals ord.CustomerId
                                       orderby ord.OrderAmount descending
                                       select new
                                       {
                                           CustomerName = cust.Name,
                                           ord.ProductName,
                                           ord.OrderAmount
                                       }).FirstOrDefault();

            Console.WriteLine("\nHighest-Value Order Details:");
            if (highestOrderDetails != null)
            {
                Console.WriteLine($"{highestOrderDetails.CustomerName} placed the highest order for a {highestOrderDetails.ProductName} worth ₹{highestOrderDetails.OrderAmount}");
            }


        }
    }
}

