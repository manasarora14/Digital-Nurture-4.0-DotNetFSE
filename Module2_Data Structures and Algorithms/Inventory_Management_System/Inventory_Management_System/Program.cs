using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(new Product(101, "Laptop", 10, 75000));
        inventory.AddProduct(new Product(102, "Mouse", 50, 500));
        inventory.ViewInventory();

        inventory.UpdateProduct(102, "Wireless Mouse", 40, 650);
        inventory.ViewInventory();

        inventory.DeleteProduct(101);
        inventory.ViewInventory();
    }
}
