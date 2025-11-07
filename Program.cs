using Day_01;

#region LINQ - Restriction Operators
// ----------------------LINQ - Restriction Operators---------------------------------
var products = ListGenerator.ProductsList;
//// 1. Find all products that are out of stock.
//var outOfStockProuduct = products.Where(p => p.UnitsInStock == 0);
//foreach(var product in outOfStockProuduct)
//{
//    Console.WriteLine($"Out of stock product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
//}
////--------------------------------------------------------------------------------------------------
////--------------------------------------------------------------------------------------------------
//// 2. Find all products that are in stock and cost more than 3.00 per unit.
//var productsInStockOver3 = products.Where(p => p.UnitsInStock > 3 && p.UnitPrice > 3);
//foreach(var product in productsInStockOver3)
//{
//    Console.WriteLine($"Product in stock over 3.00: {product.ProductName}, Price: {product.UnitPrice}, UnitsInStock: {product.UnitsInStock}");
//}

////--------------------------------------------------------------------------------------------------
///---------------------------------------------------------------------------------------------------

//// 3. Returns digits whose name is shorter than their value. 
//String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//// output:  "five", "six", "seven" , "eight", "nine"
//for (int i = 0; i < Arr.Length; i++)
//{
//    if (Arr[i].Length<i)
//    {
//        Console.WriteLine($"Digit name shorter than value: {Arr[i]}");
//    }

//}
//--------------------------------------------------------------------------------------------------
////--------------------------------------------------------------------------------------------------
///

#endregion


#region LINQ - Element Operators
//// ----------------------LINQ - Element Operators----------------------------------------
//// ----------------------LINQ - Element Operators----------------------------------------
//// 1. Retrieve the first product that is out of stock.
//var productOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
//Console.WriteLine($"First product out of stock: {productOutOfStock?.ProductName}, UnitsInStock: {productOutOfStock?.UnitsInStock}");

////--------------------------------------------------------------------------------------------------
/// --------------------------------------------------------------------------------------------------
//// 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
//var productPriceOver1000 = products.FirstOrDefault(p=>p.UnitPrice>1000);
//if (productPriceOver1000 is null)
//{
//    Console.WriteLine("No product found with price over 1000.");
//}
//else
//{
//    Console.WriteLine($"First product with price over 1000: {productPriceOver1000.ProductName}, Price: {productPriceOver1000.UnitPrice}");
//}

////--------------------------------------------------------------------------------------------------
///--------------------------------------------------------------------------------------------------
//////3. Retrieve the second number greater than 5 
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var secondNumberGretterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
//Console.WriteLine($"The second number greater than 5 is: {secondNumberGretterThan5}");

////----------------------------LINQ - Aggregate Operators------------------------------------------------
///-----------------------------LINQ - Aggregate Operators-------------------------------------------------

//// 1- Uses Count to get the number of odd numbers in the array
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//int oddumbers = Arr.Count(n=> n%2 != 0);
//Console.WriteLine($"Number of odd numbers in the array: {oddumbers}");



////--------------------------------------------------------------------------------------------------
/// 2- Return a list of customers and how many orders each has. 
//var customers = ListGenerator.CustomersList;
//foreach(var c in customers)
//{
//       Console.WriteLine($"Customer: {c.CustomerName}, Number of Orders: {c.Orders.Length}");

//}

////--------------------------------------------------------------------------------------------------
//// 3. Return a list of categories and how many products each has
// var categories = products.GroupBy(p=>p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() });
//foreach(var category in categories)
//{
//    Console.WriteLine($"Category: {category.Category}, Number of Products: {category.ProductCount}");
//}

////--------------------------------------------------------------------------------------------------
//// 4. Get the total of the numbers in an array.
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//int total = Arr.Sum();
//Console.WriteLine($"Total of numbers in the array: {total}");

////--------------------------------------------------------------------------------------------------

#endregion



