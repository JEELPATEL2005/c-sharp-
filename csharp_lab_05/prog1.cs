
using System;
using System.Collections.Generic;


    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        public Product(int id, string name, string category, double price, double discount)
        {
            ProductID = id;
            ProductName = name;
            Category = category;
            Price = price;
            DiscountPercentage = discount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(101, "Laptop", "Electronics", 75000.00, 10.0),
                new Product(102, "Smartphone", "Electronics", 45000.00, 5.0),
                new Product(103, "Running Shoes", "Footwear", 5000.00, 15.0),
                new Product(104, "Coffee Maker", "Appliances", 8000.00, 12.0)
            };

            Func<Product, double> calculateDiscountAmount =
                p => p.Price * (p.DiscountPercentage / 100);

            Func<Product, double> calculateFinalPrice =
                p => p.Price - calculateDiscountAmount(p);

            Action<Product> displayProductDetails = p =>
            {
                double discountAmt = calculateDiscountAmount(p);
                double finalPrice = calculateFinalPrice(p);

                Console.WriteLine($"Product ID         : {p.ProductID}");
                Console.WriteLine($"Product Name       : {p.ProductName}");
                Console.WriteLine($"Category           : {p.Category}");
                Console.WriteLine($"Original Price     : {p.Price:N2}");
                Console.WriteLine($"Discount           : {p.DiscountPercentage}");
                Console.WriteLine($"Discount Amount    : {discountAmt:N2}");
                Console.WriteLine($"Final Price        : {finalPrice:N2}");
            };

            foreach (var product in products)
            {
                displayProductDetails(product);
            }
        }
    }
