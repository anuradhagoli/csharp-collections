using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class ProductInventory
    {
        public void InventoryMgmt()
        {
            // Create a Dictionary to track the quantity of products by their unique IDs
            Dictionary<int, int> productInventory = new Dictionary<int, int>();

            // Adding products with their unique IDs as keys and quantities as values
            productInventory[1001] = 10; // ID 1001 has 10 units
            productInventory[1002] = 6;  // ID 1002 has 6 units

            // TODO: Remove the product with ID 1001 from the inventory
            productInventory.Remove(1001);
            // Print the updated inventory
            Console.WriteLine("Updated product inventory: ");
            foreach (var pair in productInventory)
            {
                Console.WriteLine("ID {0}: {1} units", pair.Key, pair.Value);
            }
        }
    }
}
