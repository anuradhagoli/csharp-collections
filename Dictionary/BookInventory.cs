using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class BookInventory
    {
        public void InventoryMgmt()
        {
            // TODO: Create a Dictionary with string as the key type and string as the value type
            Dictionary<string, string> books = new Dictionary<string, string>();
            books.Add("978-0-262-03384-8", "Introduction to Algorithms");
            books.Add("978-0-13-110362-7", "The C Programming Language");
            books.Add("978-0-201-63361-0", "Design Patterns");
            // TODO: Add at least three books to the inventory with their ISBN and name
            // Examples: (978-0-262-03384-8, Introduction to Algorithms), (978-0-13-110362-7, The C Programming Language), (978-0-201-63361-0, Design Patterns)

            // TODO: Display the entire bookstore inventory
            foreach (var book in books)
            {
                Console.WriteLine(book.Value);
            }

            /*
                In a Dictionary, each item in the loop is a KeyValuePair<string, string>, not just a string.
                Using var lets C# automatically use the correct type (KeyValuePair<string, string>).
                If you use string, you'll get an error because each element has both a key and a value.
             */
            // TODO: Remove any book from the inventory
            books.Remove("978-0-201-63361-0");
            // TODO: Display the updated bookstore inventory
            foreach (var book in books)
            {
                Console.WriteLine(book.Value);
            }
        }
    }
}