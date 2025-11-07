using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_01
{
    class Product : IComparable<Product>
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int CompareTo(Product? other)
            => this.UnitPrice.CompareTo(other?.UnitPrice);

        public override string ToString()
            => $"ProductID:{ProductID}, ProductName:{ProductName}, Category:{Category}, UnitPrice:{UnitPrice}, UnitsInStock:{UnitsInStock}";
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }

        public override string ToString()
            => $"{CustomerID}, {CustomerName}, {City}, {Country}, Orders: {Orders?.Length ?? 0}";
    }

    class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
            => $"Order Id: {OrderID}, Date: {OrderDate.ToShortDateString()}, Total: {Total}";
    }


    internal static class ListGenerator
    {
        public static List<Product> ProductsList { get; set; }
        public static List<Customer> CustomersList { get; set; }

        static ListGenerator()
        {
            // -----------------------------
            // Product dummy data (your original)
            // -----------------------------
            ProductsList = new List<Product>()
            {
                new Product() { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00M, UnitsInStock = 100 },
                new Product() { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00M, UnitsInStock = 17 },
                new Product() { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00M, UnitsInStock = 13 },
                new Product() { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.00M, UnitsInStock = 53 },
                new Product() { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35M, UnitsInStock = 0 },
                new Product() { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.00M, UnitsInStock = 120 },
                new Product() { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.00M, UnitsInStock = 15 },
                new Product() { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.00M, UnitsInStock = 6 },
                new Product() { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.00M, UnitsInStock = 29 },
                new Product() { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00M, UnitsInStock = 31 },
            };

            // -----------------------------
            // Customer dummy data (from your XML)
            // -----------------------------
            CustomersList = new List<Customer>()
            {
                new Customer
                {
                    CustomerID = "212",
                    CustomerName = "Ahmed Ali",
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    PostalCode = "12209",
                    Country = "Germany",
                    Phone = "030-0074321",
                    Fax = "030-0076545",
                    Orders = new Order[]
                    {
                        new Order { OrderID = 10643, OrderDate = new DateTime(1997,8,25), Total = 814.50M },
                        new Order { OrderID = 10692, OrderDate = new DateTime(1997,10,3), Total = 878.00M },
                        new Order { OrderID = 10702, OrderDate = new DateTime(1997,10,13), Total = 330.00M },
                        new Order { OrderID = 10835, OrderDate = new DateTime(1998,1,15), Total = 845.80M },
                        new Order { OrderID = 10952, OrderDate = new DateTime(1998,3,16), Total = 471.20M },
                        new Order { OrderID = 11011, OrderDate = new DateTime(1998,4,9), Total = 933.50M }
                    }
                },
                new Customer
                {
                    CustomerID = "323",
                    CustomerName = "Ana Trujillo Emparedados y helados",
                    Address = "Avda. de la Constitución 2222",
                    City = "México D.F.",
                    PostalCode = "05021",
                    Country = "Mexico",
                    Phone = "(5) 555-4729",
                    Fax = "(5) 555-3745",
                    Orders = new Order[]
                    {
                        new Order { OrderID = 10308, OrderDate = new DateTime(1996,9,18), Total = 88.80M },
                        new Order { OrderID = 10625, OrderDate = new DateTime(1997,8,8), Total = 479.75M },
                        new Order { OrderID = 10759, OrderDate = new DateTime(1997,11,28), Total = 320.00M },
                        new Order { OrderID = 10926, OrderDate = new DateTime(1998,3,4), Total = 514.40M }
                    }
                },
                new Customer
                {
                    CustomerID = "ANTON",
                    CustomerName = "Antonio Moreno Taquería",
                    Address = "Mataderos 2312",
                    City = "México D.F.",
                    PostalCode = "05023",
                    Country = "Mexico",
                    Phone = "(5) 555-3932",
                    Orders = new Order[]
                    {
                        new Order { OrderID = 10365, OrderDate = new DateTime(1996,11,27), Total = 403.20M },
                        new Order { OrderID = 10507, OrderDate = new DateTime(1997,4,15), Total = 749.06M },
                        new Order { OrderID = 10535, OrderDate = new DateTime(1997,5,13), Total = 1940.85M },
                        new Order { OrderID = 10573, OrderDate = new DateTime(1997,6,19), Total = 2082.00M },
                        new Order { OrderID = 10677, OrderDate = new DateTime(1997,9,22), Total = 813.36M },
                        new Order { OrderID = 10682, OrderDate = new DateTime(1997,9,25), Total = 375.50M },
                        new Order { OrderID = 10856, OrderDate = new DateTime(1998,1,28), Total = 660.00M }
                    }
                }
            };
        }
    }
}
