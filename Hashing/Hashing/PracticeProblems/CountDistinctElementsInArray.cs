using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    public partial class PracticeProblems
    {
        public static int DistinctOOfNSquare(int[] array)
        {
            int distinct = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isPresent = false;
                for (int j = 0; j < i; j++)
                {
                    isPresent = array[i] == array[j];
                    if (isPresent)
                        break;
                }
                if (!isPresent)
                {
                    ++distinct;
                }
            }
            return distinct;
        }

        public static int DistinctOOfn(int[] elements)
        {
            return new HashSet<int>(elements).Count;
        }
    }
}
