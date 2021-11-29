using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    class HashUsingChaining
    {
        private List<int>[] arrayOfList;
        private int noOfSlot;

        public HashUsingChaining(int noOfSlot)
        {
            Console.WriteLine();
            Console.WriteLine("***** Hash Using Chaining *******");
            this.noOfSlot = noOfSlot;
            arrayOfList = new List<int>[noOfSlot];
            for (int i = 0; i < noOfSlot; i++)
            {
                arrayOfList[i] = new List<int>();
            }
        }

        private int GetHashCode(int key)
        {
            return key % noOfSlot;
        }
        public void Insert(int key)
        {
            var bucket = GetHashCode(key);
            arrayOfList[bucket].Add(key);
            Console.WriteLine($"Inserting {key} in the bucket {bucket}");
        }

        public int Search(int key)
        {
            var bucket = GetHashCode(key);
            var index = arrayOfList[bucket].IndexOf(key);
            if (index > 0)
                Console.WriteLine($"Key {key} is available at bucket {bucket} and index {index}");
            else
                Console.WriteLine($"{key} not available");
            return index;
        }

        public void Delete(int key)
        {
            var bucket = GetHashCode(key);
            if (arrayOfList[bucket].Remove(key))
            { 
                Console.WriteLine($"Deleted {key}");
            }
            else
            {
                Console.WriteLine($""); 
            }
        }
    }
}
