using System;
using System.Collections.Generic;

namespace Moment4
{
    // En generisk klass som kan lagra valfri typ T
    public class Storage<T>
    {
        private List<T> items = new List<T>();

        // Lägger till ett objekt till listan
        public void AddItem(T item)
        {
            items.Add(item);
        }

        // Skriver ut alla objekt i listan
        public void PrintAll()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
