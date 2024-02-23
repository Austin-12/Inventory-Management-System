using System;



namespace InventoryManagementSystem
{
    public class InventoryItem
    {
        private string _itemID;
        private string _itemName;
        private int _quantity;
        private decimal _price;

        //public getters & setters(accessors)
        public string ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemID = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        //constructor
        public InventoryItem(string  itemID, string itemName, int quantity, decimal price)
        {
            _itemID = itemID;
            _itemName = itemName;
            _quantity = quantity;
            _price = price;

        }

        //override ToString()
        public override string ToString()
        {
            return $"{ItemID}: {ItemName}: Quantity: {Quantity}, Price: {Price:C}";
        }
    }
}
