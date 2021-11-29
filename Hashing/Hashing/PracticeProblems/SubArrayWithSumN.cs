using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    public partial class PracticeProblems
    {
        // Complete this function
        // Function to check if there is a pair with the given sum in the array.
        // Time Complexity O(n2) 
        public static int SumExists(int[] arr, int N, int sum)
        {
            // Your code here, Geeks
            int flagExists = 0;
            for (int i = 0; i < N; i++)
            {
                var element = arr[i];
                for (int j = i + 1; j < N; j++)
                    if (arr[j] == sum - element)
                    {
                        flagExists = 1;
                        break;
                    }
            }
            return flagExists;
        }

        public static int SumExistsOrderOfN(int[] arr, int N, int sum)
        {
            // Your code here, Geeks
            int flagExists = 0;
            for (int i = 0; i < N; i++)
            {
                var element = arr[i];
                for (int j = i + 1; j < N; j++)
                    if (arr[j] == sum - element)
                    {
                        flagExists = 1;
                        break;
                    }
            }
            return flagExists;
        }
    }
}
