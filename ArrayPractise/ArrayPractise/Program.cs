using System;
using System.Diagnostics.Contracts;

namespace ArrayPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var index = Search(new[] { 1, 2, 3, 4, 5, 10 }, 5);
            Contract.Requires(index == 4);
            index = Search(new[] { 1, 2, 3, 4, 5, 10 }, 50);
            Contract.Requires(index == -1);
            index = Search(null, 10);
            Contract.Requires(index == -1);

            var arrayData = new int[] { 3, 8, 12, 5, 6 };
            DeleteAnElementFromArray(arrayData, 12);

            arrayData = new int[] { 1, 2, 3, 4, 5 };
            ReverseInGroups(arrayData, 5, 3);
        }

        public static int Search(int[] arr, int key)
        {
            if (arr == null) return -1;
            for (var index = 0; index < arr?.Length; index++)
            {
                if (arr[index] == key)
                {
                    return index;
                }
            }
            return -1;
        }

        public static void DeleteAnElementFromArray(int[] arr, int element)
        {
            int indexOfElement = Search(arr, element);
            if (indexOfElement == -1) return;
            for (int i = indexOfElement; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = -1;
        }

        public static void ReverseInGroups(int[] A, int N, int K)
        {
            //Your code here
            int[] newArr = new int[N];
            
            int index = 0;
            for (int i = 0; i < N; i = i + K)
            {
                for (var j = i + K; j > i; j--)
                {
                    if (j <= N)
                    {
                        newArr[index++] = A[j - 1];
                        Console.WriteLine(A[j - 1]);
                    }
                }
            }
            Array.Copy(newArr, A,N);
        }
    }
}
