using InventoryManagementSystem;
using System;

class Program
{
    static void Main(string[] args)
    {
        InventoryManager manager = new InventoryManager(); //Inventory Manager object
        manager.addInventoryItem(new InventoryItem("100", "computer", 10, 100));
        manager.addInventoryItem(new InventoryItem("101", "smart phone", 5, 50));
        manager.addInventoryItem(new InventoryItem("102", "tablet", 23, 75));
        manager.addInventoryItem(new InventoryItem("103", "samsung tv", 12, 135));
        manager.addInventoryItem(new InventoryItem("104", "apple watch", 45, 110));
        Console.WriteLine("All inventory items:");
          manager.displayItems();
        //manager.calculateInventoryValue();

        Console.WriteLine("Sorted Inventory by name:");
        manager.sortInventoryByName();

        Console.WriteLine();

        Console.WriteLine("Sorted Inventory by price");
        manager.sortInventoryByPrice();

        decimal totalValue = manager.calculateInventoryValue();
        Console.WriteLine($"Total inventory value: {totalValue:C}");
    }
}