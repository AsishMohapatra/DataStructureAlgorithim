using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hashing
{
    public partial class PracticeProblems
    {
        public static Dictionary<int,int> FrequencyOfAnElementInAnArray(int[] array)
        {
            var elementWithItsFrequency = new Dictionary<int, int>();
            foreach (var element in array)
            {
                if (elementWithItsFrequency.ContainsKey(element))
                {
                    elementWithItsFrequency[element]++;
                }
                else
                {
                    elementWithItsFrequency.Add(element, 1);
                }
            }
            return elementWithItsFrequency;
        }
    }
}
