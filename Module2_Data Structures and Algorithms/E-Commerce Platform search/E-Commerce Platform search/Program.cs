using System;

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Headphones", "Electronics"),
            new Product(103, "Shirt", "Clothing"),
            new Product(104, "Shoes", "Footwear"),
            new Product(105, "Mouse", "Electronics")
        };

        // Sort products by ProductName for Binary Search
        Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

        Console.WriteLine("Linear Search for 'Shirt':");
        var linearResult = SearchService.LinearSearch(products, "Shirt");
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found");

        Console.WriteLine("\nBinary Search for 'Shirt':");
        var binaryResult = SearchService.BinarySearch(products, "Shirt");
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found");
    }
}
