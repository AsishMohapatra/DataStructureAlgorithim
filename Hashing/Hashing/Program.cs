using System;
using System.Collections.Generic;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            var directAddressTable = new DirectAddressTable(1000);
            directAddressTable.Insert(10);
            directAddressTable.Insert(20);
            directAddressTable.Insert(505);
            directAddressTable.Search(20);
            directAddressTable.Delete(20);
            directAddressTable.Search(20);

            var hashUsingChaining = new HashUsingChaining(7);
            hashUsingChaining.Insert(70);
            hashUsingChaining.Insert(71);
            hashUsingChaining.Insert(9);
            hashUsingChaining.Insert(56);
            hashUsingChaining.Insert(72);
            hashUsingChaining.Insert(10);

            hashUsingChaining.Delete(70);

            hashUsingChaining.Search(70);


            var openAddressingLinearProbing = new OpenAddressingLinearProbing(7);
            openAddressingLinearProbing.Insert(49);
            openAddressingLinearProbing.Insert(50);
            openAddressingLinearProbing.Insert(63);
            openAddressingLinearProbing.Insert(64);
            openAddressingLinearProbing.Insert(69);
            openAddressingLinearProbing.Insert(68);
            openAddressingLinearProbing.Insert(70);
            openAddressingLinearProbing.Insert(70);

            openAddressingLinearProbing.Search(70);

            openAddressingLinearProbing.Delete(70);
            openAddressingLinearProbing.Search(70);

            var listOfListIntegers=PracticeProblems.SeparateChaining(5, new int[] { 12,10,19,14,17 });

            var distict = PracticeProblems.DistinctOOfNSquare(new int[] { 5, 5, 5, 5, 6 });
            var distictQuick = PracticeProblems.DistinctOOfn(new int[] { 5, 5, 5, 5, 6 });

            var countOfElementINArray=PracticeProblems.FrequencyOfAnElementInAnArray(new int[] { 5, 5, 5, 5, 6 });

            var sumExists = PracticeProblems.SumExists(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },10,14);

        }


    }
}
