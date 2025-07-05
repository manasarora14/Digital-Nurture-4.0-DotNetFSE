using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        Console.WriteLine("📦 All Products in Inventory:\n");

        var products = await context.Products.ToListAsync();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        Console.WriteLine("\n🔍 Find Product by ID = 1:");
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"Found: {product?.Name ?? "Not Found"}");

        Console.WriteLine("\n💰 First Product over ₹50,000:");
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"Expensive: {expensive?.Name ?? "None"}");

        Console.WriteLine("\n✅ Data retrieved successfully.");
    }
}
