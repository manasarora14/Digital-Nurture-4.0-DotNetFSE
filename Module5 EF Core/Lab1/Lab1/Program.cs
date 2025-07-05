public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int StockQuantity { get; set; }

    // Foreign key
    public int Cateusing System;
using System.Linq;

class Program
    {
        static void Main()
        {
            using var context = new RetailDbContext();

            // Add a category
            var electronics = new Category { Name = "Electronics" };
            context.Categories.Add(electronics);
            context.SaveChanges();

            // Add a product
            var product = new Product
            {
                Name = "Bluetooth Speaker",
                StockQuantity = 20,
                CategoryId = electronics.CategoryId
            };
            context.Products.Add(product);
            context.SaveChanges();

            // Read data
            var products = context.Products
                .Where(p => p.StockQuantity > 10)
                .ToList();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - {p.StockQuantity}");
            }
        }
    }
    goryId { get; set; }
    public Category Category { get; set; }
}
