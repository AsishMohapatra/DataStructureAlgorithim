using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    class OpenAddressingLinearProbing
    {
        private int[] array;
        private int noOfSlot;
        int size = 0;
        public OpenAddressingLinearProbing(int noOfSlot)
        {
            Console.WriteLine();
            Console.WriteLine("****** Open Addressing Linear Probing   ********");
            this.noOfSlot = noOfSlot;
            array = new int[noOfSlot];
            for (int i = 0; i < noOfSlot; i++)
            {
                array[i] = -1;
            }
        }

        public bool Insert(int key)
        {

            if (size == noOfSlot)
            {
                Console.WriteLine("No Space to insert");
                return false;
            }
            int h = GetHashCode(key);
            int index = h;
            while (array[index] != -1 && array[index] != -2 && array[index] != key)
            {
                index = GetHashCode(index + 1);
            }
            if (array[index] == key)
            {
                return false;
            }
            else
            {
                array[index] = key;
                Console.WriteLine($"Inserted {key} at {index}");
                return true;
            }
        }

        public int Search(int key)
        {
            int index = -1;
            int h = GetHashCode(key);
            int i = h;

            while (array[i] != -1)
            {
                if (array[i] == key)
                {
                    index = i;
                    break;
                }
                i = GetHashCode(i + 1);
                if (i == h)
                {
                    index = -1;
                    break;
                }
            }
            Console.WriteLine(index==-1? $"Key {key} is available ? {index}": "key is not available");
            return index;
        }

        public bool Delete(int key)
        {
            //When deleted then mark them as -2
            int h = GetHashCode(key);
            int i = h;

            while (array[i] != -1)
            {
                if (array[i] == key)
                {
                    Console.WriteLine($"Deleting {key} at index {i} i.e. Marking as -2");
                    array[i] = -2;
                    return true;
                }
                i = GetHashCode(i + 1);
                if (i == h)
                {
                    return false;
                }
            }
            return false;
            
        }

        private int GetHashCode(int key)
        {
            return key % noOfSlot;
        }
    }
}
