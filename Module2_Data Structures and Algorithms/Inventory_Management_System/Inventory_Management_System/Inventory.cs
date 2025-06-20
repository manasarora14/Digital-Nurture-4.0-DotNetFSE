using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<int, Product> products = new Dictionary<int, Product>();

    // Add product
    public void AddProduct(Product product)
    {
        if (!products.ContainsKey(product.ProductId))
        {
            products[product.ProductId] = product;
            Console.WriteLine("Product added.");
        }
        else
        {
            Console.WriteLine("Product ID already exists.");
        }
    }

    // Update product
    public void UpdateProduct(int productId, string name, int quantity, double price)
    {
        if (products.ContainsKey(productId))
        {
            products[productId].ProductName = name;
            products[productId].Quantity = quantity;
            products[productId].Price = price;
            Console.WriteLine("Product updated.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    // Delete product
    public void DeleteProduct(int productId)
    {
        if (products.Remove(productId))
        {
            Console.WriteLine("Product deleted.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    // View all products
    public void ViewInventory()
    {
        Console.WriteLine("Current Inventory:");
        foreach (var p in products.Values)
        {
            Console.WriteLine(p);
        }
    }
}
