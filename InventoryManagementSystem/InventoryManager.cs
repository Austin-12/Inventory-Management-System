using System;
using System.Collections.Generic;
using System.Linq;


namespace InventoryManagementSystem
{
    public class InventoryManager
    {
        private List<InventoryItem> inventory;

        //constructor
        public InventoryManager()
        {
            inventory = new List<InventoryItem>();
        }
        //add item to inventory list
        public void addInventoryItem(InventoryItem item)
        {
            inventory.Add(item);
        }
        //remove item from inventory list
        public void removeInventoryItem(string itemID)
        {
            InventoryItem itemToDelete = inventory.FirstOrDefault(item => item.ItemID == itemID); //search items for matching itemid
            if (itemToDelete != null)
            {
                inventory.Remove(itemToDelete);
            }
        }
        //update quantity
        public void updateQuantity(string itemID, int newQuantity)
        {
            InventoryItem itemToUpdate = inventory.FirstOrDefault(item => item.ItemID == itemID);
            if (itemToUpdate != null)
            {
                itemToUpdate.Quantity = newQuantity;
            }
        }
        //search item based on itemID
        public InventoryItem searchItem(string itemID)
        {
            return inventory.FirstOrDefault(item => item.ItemID == itemID);
        }
        //display all items in the list
        public void displayItems()
        {
            foreach (InventoryItem item in inventory)
            {
                Console.WriteLine(item + "\n");
            }
        }
        //calculate total inventory value
        public decimal calculateInventoryValue()
        {
            decimal sum = inventory.Sum(item => item.Price * item.Quantity);
            return sum;
        }
        //sort inventory list by item name
        public void sortInventoryByName()
        {   //use LINQ to sort
            var nameSorted = inventory.OrderBy(item => item.ItemName);
            foreach (var item in nameSorted)
            {
                Console.WriteLine(item);
            }

        }

        public void sortInventoryByPrice()
        {
            var priceSorted = inventory.OrderBy(item => item.Price);
            foreach (var item in priceSorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
   
/* Develop an inventory management system to help
 * businesses track and manage their inventory of
 * products. The system will allow users to add, remove
 * update, search, and display inventory items. Additionally
 * the system will utilize linq for querying and manipulating
 * the inventory data, providing functionalities such as
 * sorting, filtering, and calculating total inventory value
 * 
 */
