using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    /// <summary>
    /// Imagine a situation where you have 1000 keys with values from 0 to 999
    /// How would you implement Serach , Insert , Delete with O(1)
    /// </summary>
    public class DirectAddressTable
    {
        private bool[] array ;

        public DirectAddressTable(int noOfElement)
        {
            Console.WriteLine("***** Direct Address Table *******");
            array = new bool[noOfElement];
        }
        public bool Insert(int key)
        {
            Console.WriteLine($"Inserted {key}"); 
            array[key] = true;
            return true;
        }

        public bool Search(int key)
        {
            Console.WriteLine($"Key {key} is available ? {array[key]}");
            return array[key];
        }

        public void Delete(int key)
        {
            Console.WriteLine($"Deleting {key}");
            array[key] = false;
        }
    }
}
