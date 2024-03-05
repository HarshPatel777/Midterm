using System.Xml.Linq;

using System;

namespace Midterm
{
 
    class InventoryItem
    { 
        private string name;
        private int id;
        private double price;
        private int quantity;

        public InventoryItem(string name, int id, double price, int quantity)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }


        public void UpdatePrice(double newPrice)
        {
            this.price = newPrice; 
            Console.WriteLine($"Price of {name} updated to {newPrice:C}");
        }

        public void RestockItem(int additionalQuantity)
        {
            this.quantity += additionalQuantity;
            Console.WriteLine($"{additionalQuantity} {name}(s) added to stock. Total quantity: {quantity}");
        }

        public void SellItem(int quantitySold)
        {
            if (quantity >= quantitySold)
            {
                this.quantity -= quantitySold;
                Console.WriteLine($"{quantitySold} {name}(s) sold. Remaining quantity: {quantity}");
            }
            else
            {
                Console.WriteLine($"Not enough {name} in stock to sell {quantitySold}.");
            }
        }

        public bool IsInStock()
        {
            return quantity > 0;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine($"Quantity: {quantity}");
        }
    }

class Program
        {
            static void Main()
            {
                // Example usage
                InventoryItem item1 = new InventoryItem("LAPTOP", 101, 20.99, 50);
                InventoryItem item2 = new InventoryItem("SMARTPHONE", 102, 15.49, 30);

                Console.WriteLine("Initial Details:");
                item1.PrintDetails();
                item2.PrintDetails();

                // Update price
                item1.UpdatePrice(22.99);
                Console.WriteLine("\nDetails after price update:");
                item1.PrintDetails();

                // Restock items
                item2.RestockItem(20);
                Console.WriteLine("\nDetails after restocking:");
                item2.PrintDetails();

                // Sell items
                item1.SellItem(10);
                item2.SellItem(25);
                Console.WriteLine("\nDetails after selling items:");
                item1.PrintDetails();
                item2.PrintDetails();

                // Check if items are in stock
                Console.WriteLine($"\nIs item1 in stock? {item1.IsInStock()}");
                Console.WriteLine($"Is item2 in stock? {item2.IsInStock()}");
            }
        }

       
  
    }

