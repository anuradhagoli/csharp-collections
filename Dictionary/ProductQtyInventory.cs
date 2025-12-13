using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class ProductQtyInventory
    {
        public void revealProductQtyInventory()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int> {
            { "Apples", 50 },
            { "Bananas", 100 },
            { "Oranges", 75 }
        };
            Console.WriteLine(GetTotalQuantity(inventory));  // It should print 225

            Dictionary<string, int> anotherInventory = new Dictionary<string, int> {
            { "Pizzas", 20 },
            { "Burgers", 30 },
            { "Tacos", 50 }
        };
            Console.WriteLine(GetTotalQuantity(anotherInventory));  // It should print 100

            Dictionary<string, int> emptyInventory = new Dictionary<string, int>();
            Console.WriteLine(GetTotalQuantity(emptyInventory));  // It should print 0

        }
        public static int GetTotalQuantity(Dictionary<string, int> inventory)
        {
            // TODO: Implement this
            int sum = 0;
            foreach (var i in inventory)
            {
                sum += i.Value;
            }
            return sum;
        }
    }
}
