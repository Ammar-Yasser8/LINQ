using Day_01_G03;
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
////3. Retrieve the second number greater than 5 
int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var secondNumberGretterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
Console.WriteLine($"The second number greater than 5 is: {secondNumberGretterThan5}");
