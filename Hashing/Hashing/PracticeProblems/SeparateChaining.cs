using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    public partial class PracticeProblems
    {
        public static List<List<int>> SeparateChaining(int hashSize, int[] arr)
        {
            //Your code here
            var result = new List<List<int>>(hashSize);
            for (int i = 0; i < hashSize; i++)
            {
                var listOfInt = new List<int>();
                result.Add(listOfInt);
            }

            foreach (int key in arr)
            {
                int bucket = GetHashCode(key, hashSize);
                result[bucket].Add(key);
            }

            return result;
        }

        private static int GetHashCode(int key, int hashSize)
        {
            return key % hashSize;
        }
    }
}
