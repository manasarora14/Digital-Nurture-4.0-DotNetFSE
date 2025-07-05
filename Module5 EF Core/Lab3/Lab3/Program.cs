using System;
using System.Threading.Tasks;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // Step 1: Create categories
        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);

        // Step 2: Create products with relationships
        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

        await context.Products.AddRangeAsync(product1, product2);

        // Step 3: Save to database
        await context.SaveChangesAsync();

        Console.WriteLine("✅ Initial data inserted successfully.");
    }
}
